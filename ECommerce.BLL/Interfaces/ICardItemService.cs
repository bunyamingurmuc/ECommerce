using ECommerce.Common;
using ECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Interfaces
{
    public interface ICardItemService:IService<CardItem>
    {
        Task<IResponse<CardItem>> GetByIdAsyncR(int id);
        Task<IResponse<List<CardItem>>> GetAllAsyncR();
    }
}
