using ECommerce.Common;
using ECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Interfaces
{
    public interface IOrderService:IService<Order>
    {
        Task<IResponse<Order>> CalculateAndCreateAsync(Order order);
        IResponse<Order> CalculateAndUpdate(Order order);
    }
}
