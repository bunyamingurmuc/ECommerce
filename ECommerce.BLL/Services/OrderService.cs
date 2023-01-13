using ECommerce.BLL.Extension;
using ECommerce.BLL.Interfaces;
using ECommerce.BLL.Serives;
using ECommerce.Common;
using ECommerce.DAL.UnitOfWork;
using ECommerce.Entity;
using FluentValidation;

namespace ECommerce.BLL.Services
{
    public class OrderService : Service<Order>, IOrderService
    {

        public readonly IUOW _uow;
        public readonly IValidator<Order> _validator;
        public OrderService(IUOW uow, IValidator<Order> validator ):base(validator, uow)
        {
            _uow = uow;
            _validator = validator;
        }


        public async Task<IResponse<Order>> CalculateAndCreateAsync(Order order)
        {
            var result=await _validator.ValidateAsync(order);
            if (result.IsValid)
            {
                var sum = order.OrderItems.Sum(i => i.Product.Price * i.Quantity);
                order.TotalPrice = sum + order.ShippingPrice;
               await CreateAsync(order);
                return new Response<Order>(Common.Enums.ResponseType.Success,order);
            }
            else
            {
                return new Response<Order>(order, result.ConvertToCustomValidationError());

            }
        }

        public IResponse<Order> CalculateAndUpdate(Order order)
        {
            var result =  _validator.Validate(order);
            if (result.IsValid)
            {
                var sum = order.OrderItems.Sum(i => i.Product.Price * i.Quantity);
                order.TotalPrice = sum + order.ShippingPrice;
                Create(order);
                return new Response<Order>(Common.Enums.ResponseType.Success, order);
            }
            else
            {
                return new Response<Order>(order, result.ConvertToCustomValidationError());
            }
        }
    }
}
