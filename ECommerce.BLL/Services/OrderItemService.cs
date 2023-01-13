using ECommerce.BLL.Interfaces;
using ECommerce.BLL.Serives;
using ECommerce.DAL.UnitOfWork;
using ECommerce.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Services
{
    public class OrderItemService : Service<OrderItem>, IOrderItemService
    {
        public OrderItemService(IValidator<OrderItem> validator, IUOW uow) : base(validator, uow)
        {
        }
    }
}
