using ECommerce.Common;
using ECommerce.Entity;

namespace ECommerce.BLL.Interfaces
{
    public interface ISellerService:IService<Seller>
    {
        Task<IResponse<List<Product>>> SalesThisMonthsAsync(int sellerId);
        Task<IResponse<List<AppUser>>> NewCustomerThisMonthAsync(int sellerId);
        Task<IResponse<Seller>> GetByIdAsyncR(int id);
        Task<IResponse<List<Seller>>> GetAllAsyncR();



    }
}
