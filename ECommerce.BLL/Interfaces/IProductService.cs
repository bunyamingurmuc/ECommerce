using ECommerce.Common;
using ECommerce.Entity;
using Microsoft.AspNetCore.Http;

namespace ECommerce.BLL.Interfaces
{
    public interface IProductService:IService<Product>
    {
        Task<IResponse<List<Product>>> GetRemovalProductAsync(Seller seller);
        Task<IResponse<List<Product>>> GetLowerStockProductsAsync();
        Task<IResponse<Product>> GetByIdAsyncR(int id);
        Task<IResponse<List<Product>>> GetAllAsyncR();

        Task<IResponse<List<Product>>> ImportExcel(IFormFile file);
        //Task<IResponse<List<Product>>> ExportExcel(Seller seller);
        Task<IResponse<Product>> CreateCalculateAsync(Product product, int sellerId);
        Task<IResponse<List<Product>>> GetHomeProduct();
        Task<IResponse<List<Product>>> GetRelatedProducts(int productId);
  


    }
}
