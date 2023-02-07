using ECommerce.BLL.Extension;
using ECommerce.BLL.Interfaces;
using ECommerce.BLL.Serives;
using ECommerce.BLL.ValidationRules;
using ECommerce.Common;
using ECommerce.Common.Enums;
using ECommerce.DAL.Context;
using ECommerce.DAL.UnitOfWork;
using ECommerce.Entity;
using ECommerce.Entity.Interface;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

namespace ECommerce.BLL.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IValidator<Product> _validator;
        private readonly IUOW _uow;
        private readonly ISellerService _sellerService;
        public readonly ECommerceContext _context;

        public ProductService(IValidator<Product> validator, IUOW uow, ISellerService sellerService, ECommerceContext context) : base(validator, uow)
        {
            _validator = validator;
            _uow = uow;
            _sellerService = sellerService;
            _context = context;
        }

        public async Task<IResponse<List<Product>>> GetRemovalProductAsync(Seller seller)
        {
            var get = await GetAllAsync();
            var products = get.Data.Where(i => i.Seller == seller).ToList();
            var removalProduct = products.Where(i => i.RemoveCount > 10).ToList();
            return new Response<List<Product>>(ResponseType.Success, removalProduct);

        }

        public async Task<IResponse<List<Product>>> GetLowerStockProductsAsync()
        {
            var products = await _uow.GetRepository<Product>().GetAllAsync();
            var filtered = products.Where(i => i.IsStock == false || i.StockCount < 10).ToList();
            return new Response<List<Product>>(ResponseType.Success, filtered);
        }

        public async Task<IResponse<Product>> GetByIdAsyncR(int id)
        {
            var data = await _context.Products.Where(i => i.Id == id)
                .Include(i => i.Category)
                .Include(i => i.Reviews)
                .Include(i => i.Seller).ThenInclude(i => i.Products)
                .Include(i => i.OrderItems)
                .Include(i => i.Images)
                .Include(i => i.CardItems).ThenInclude(i => i.Card)
                .FirstOrDefaultAsync();
            if (data != null)
                return new Response<Product>(ResponseType.Success, data);
            return new Response<Product>(ResponseType.NotFound, "Data bulunamadı");
        }

        public async Task<IResponse<List<Product>>> GetAllAsyncR()
        {

            var data = await _context.Products
                .Include(i => i.Category)
                .Include(i => i.Reviews)
                .Include(i => i.Seller)
                .Include(i => i.OrderItems)
                .Include(i => i.Images)
                .Include(i => i.CardItems).ThenInclude(i => i.Card)
                .ToListAsync();


            return new Response<List<Product>>(ResponseType.Success, data);

        }

        public async Task<IResponse<List<Product>>> ImportExcel(IFormFile file)
        {
            var list = new List<Product>();
            using (var stream = new MemoryStream())
            {
                await file.CopyToAsync(stream);
                using (var package = new ExcelPackage(stream))
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    var rowsCount = worksheet.Dimension.Rows;
                    for (int row = 2; row <= rowsCount; row++)
                    {
                        Unit unit;
                        list.Add(new Product()
                        {
                            Name = worksheet.Cells[row, 1].Value.ToString().Trim(),
                            Description = worksheet.Cells[row, 2].Value.ToString().Trim(),
                            StockCount = Int32.Parse(worksheet.Cells[row, 3].Value.ToString().Trim()),
                            Price = double.Parse(worksheet.Cells[row, 4].Value.ToString().Trim()),
                            Discount = Int32.Parse(worksheet.Cells[row, 5].Value.ToString().Trim()),
                            IsHomeProduct = Boolean.Parse(worksheet.Cells[row, 6].Value.ToString().Trim()),
                            CategoryId = Int32.Parse(worksheet.Cells[row, 7].Value.ToString().Trim()),
                            Unit = Enum.TryParse(worksheet.Cells[row, 8].Value.ToString().Trim(), out unit) == true ? unit : null,
                        });
                    }

                    foreach (var product in list)
                    {
                        product.IsStock = (product.StockCount == 0) ? true : false;
                        product.SalePrice = (product.Price * (100 - product.Discount.Value)) / 100;
                    }
                    foreach (var product in list)
                    {
                        var result = await _validator.ValidateAsync(product);
                        if (!result.IsValid)
                            return new Response<List<Product>>(list, result.ConvertToCustomValidationError());
                    }
                    var created = await _uow.GetRepository<Product>().CreateRangeAsync(list);
                    return new Response<List<Product>>(ResponseType.Success, created);
                }
            }
        }

        public async Task<IResponse<Product>> CreateCalculateAsync(Product product,int sellerId)
        {
            product.IsStock = (product.StockCount == 0) ? true : false;
            product.Price = (product.Price * (100 - product.Discount.Value)) / 100;
            product.SellerId = sellerId;
            var result = await _validator.ValidateAsync(product);
            if (!result.IsValid)
                return new Response<Product>(product, result.ConvertToCustomValidationError());
            var created = await _uow.GetRepository<Product>().CreateAsync(product);
            return new Response<Product>(ResponseType.Success, created);
        }

        public async Task<IResponse<List<Product>>> GetHomeProduct()
        {
            var data = _context.Products;
            if (data==null)
            {
                return new Response<List<Product>>(ResponseType.NotFound, "Stokta ürün yok");
            }
            var salesOrdered = await data
                .Where(i => i.IsHomeProduct == true)
                  .Include(i => i.Images)
                  .OrderBy(i=>i.SalesQuantity)
                  .ToListAsync();
            for (int i = 0; i < 10; i++)
            {
                salesOrdered[i].IsNew=true;
            }

            foreach (var product in salesOrdered)
            {
                if (product.CreatedDate>=DateTime.Now.AddMonths(-1))
                {
                    product.IsTop = true;
                }
            }

            return new Response<List<Product>>(ResponseType.Success, salesOrdered);
        }

        public async Task<IResponse<List<Product>>> GetRelatedProducts(int productId)
        {
            var data = _context.Products.Where(i=>i.Id==productId);
            var incluted =await data.Include(i => i.Category).ThenInclude(i => i.Products).FirstOrDefaultAsync();
            var relatedProducts = incluted.Category.Products.Take(10).ToList();
            if (relatedProducts.Count==0)
            {
                var data2 = await _context.Products.Take(10).ToListAsync();
                return new Response<List<Product>>(ResponseType.Success, data2);
            }
            return new Response<List<Product>>(ResponseType.Success, relatedProducts);
        }

    }

}
