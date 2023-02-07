using ECommerce.Common;
using ECommerce.Entity;

namespace ECommerce.BLL.Interfaces
{
    public interface IReviewService:IService<Review>
    {
        Task<IResponse<Review>> GetByIdAsyncR(int id);
        Task<IResponse<List<Review>>> GetAllAsyncR();
    }
}
