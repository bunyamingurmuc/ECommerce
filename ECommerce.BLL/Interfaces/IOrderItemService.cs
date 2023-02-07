using ECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Common;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ECommerce.BLL.Interfaces
{
    public interface IOrderItemService:IService<OrderItem>
    {
         Task<IResponse<OrderItem>> OrderItemCreate(OrderItem orderItem);
         Task<IResponse<List<OrderItem>>> GetRecentOrderItemsWithCategory(int categoryId);
         Task<IResponse<OrderItem>> GetByIdAsyncR(int id);
         Task<IResponse<List<OrderItem>>> GetAllAsyncR();
    }
}
