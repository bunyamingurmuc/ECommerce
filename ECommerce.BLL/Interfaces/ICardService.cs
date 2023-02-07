using ECommerce.Common;
using ECommerce.Entity;

namespace ECommerce.BLL.Interfaces
{
    public interface ICardService:IService<Card>
    {
        Task<IResponse<Card>> CreateCard(Card card, int userId);
        Task<IResponse<Card>> GetByIdAsyncR(int id);
        Task<IResponse<List<Card>>> GetAllAsyncR();
        Task<IResponse<Card>> UpdateCard(Card card);
    }
}
