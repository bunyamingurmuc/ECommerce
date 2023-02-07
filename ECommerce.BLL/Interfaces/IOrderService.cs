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
        Task<IResponse<Order>> CreateOrder(Order order,int userId);
        Task<IResponse<Order>> UpdateOrder(Order order);
        IResponse<int> GetCurrentMountSellerOrderQuantity(Seller seller);
        IResponse<double> GetCompereMountOrderRate(Seller seller);
        Task<IResponse<Order>> GetByIdAsyncR(int id);
        Task<IResponse<List<Order>>> GetAllAsyncR();
       


    }
}
