using System.Security.Cryptography.X509Certificates;
using ECommerce.BLL.Extension;
using ECommerce.BLL.Interfaces;
using ECommerce.BLL.Serives;
using ECommerce.Common;
using ECommerce.Common.Enums;
using ECommerce.DAL.Context;
using ECommerce.DAL.UnitOfWork;
using ECommerce.DTO;
using ECommerce.Entity;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.BLL.Services
{
    public class SellerService : Service<Seller>, ISellerService
    {
        private readonly IValidator<Seller> _validator;
        private readonly IValidator<Product> _productValidator;
        private readonly IValidator<Category> _categoryValidator;
        private readonly IUOW _uow;
        public readonly ECommerceContext _context;

        public SellerService(IValidator<Seller> validator, IUOW uow, ECommerceContext context, IValidator<Product> productValidator) : base(validator, uow)
        {
            _validator = validator;
            _uow = uow;
            _context = context;
            _productValidator = productValidator;
           
        }

        public async Task<IResponse<List<Product>>> SalesThisMonthsAsync(int sellerId)
        {
            var get = await GetByIdAsyncR(sellerId);
            var seller = get.Data;
            var productList = new List<Product>();
            var currentMonth = DateTime.Now.Month;
            var orders = seller.Orders.Where(i => i.CreatedDate.Month == currentMonth).ToList();
            var products = orders.Select(i => i.OrderItems.Select(i => i.Product).ToList()).ToList();
            foreach (var productl in products)
            {
                foreach (var product in productl)
                {
                    productList.Add(product);
                }
            }
            return new Response<List<Product>>(ResponseType.Success, productList);
        }

        public async Task<IResponse<List<AppUser>>> NewCustomerThisMonthAsync(int sellerId)
        {
            var get = await GetByIdAsyncR(sellerId);
            var seller = get.Data;
            var currentMonth = DateTime.Now.Month;
            var newCustomer = seller.AppUsers.Where(i => i.CreatedDate.Month == currentMonth).ToList();
            return new Response<List<AppUser>>(ResponseType.Success, newCustomer);
        }

        public async Task<IResponse<Seller>> GetByIdAsyncR(int id)
        {
            var data = await _context.Sellers.Where(i => i.Id == id)
                .Include(i => i.Categories)
                .Include(i => i.AppUsers)
                .Include(i=>i.Products)
                .Include(i => i.Orders).ThenInclude(i => i.OrderItems).ThenInclude(i => i.Product)
                .FirstOrDefaultAsync();
            if (data != null)
                return new Response<Seller>(ResponseType.Success, data);
            return new Response<Seller>(ResponseType.NotFound, "Data bulunamadı");
        }

        public async Task<IResponse<List<Seller>>> GetAllAsyncR()
        {
            var data = await _context.Sellers
                .Include(i => i.Categories)
                .Include(i => i.AppUsers)
                .Include(i => i.Orders).ThenInclude(i => i.OrderItems).ThenInclude(i => i.Product)
                .ToListAsync();
            return new Response<List<Seller>>(ResponseType.Success, data);
        }

      

        
    }
}
