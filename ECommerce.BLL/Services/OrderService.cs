using ECommerce.BLL.Extension;
using ECommerce.BLL.Interfaces;
using ECommerce.BLL.Serives;
using ECommerce.Common;
using ECommerce.Common.Enums;
using ECommerce.DAL.Context;
using ECommerce.DAL.UnitOfWork;
using ECommerce.Entity;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.BLL.Services
{
    public class OrderService : Service<Order>, IOrderService
    {

        public readonly IUOW _uow;
        public readonly IValidator<Order> _validator;
        public readonly ECommerceContext _context;
        public OrderService(IUOW uow, IValidator<Order> validator, ECommerceContext context):base(validator, uow)
        {
            _uow = uow;
            _validator = validator;
            _context = context;
        }


        public async Task<IResponse<Order>> CreateOrder(Order order, int userId)
        {
            var result=await _validator.ValidateAsync(order);
            if (result.IsValid)
            {
                var sum = order.OrderItems.Sum(i => i.ProductPrice* i.Quantity);
                order.TotalPrice = sum + order.ShippingPrice;
                order.AppUserId = userId;
               await CreateAsync(order);
                return new Response<Order>(Common.Enums.ResponseType.Success,order);
            }
            else
            {
                return new Response<Order>(order, result.ConvertToCustomValidationError());

            }
        }

        public async Task<IResponse<Order>> UpdateOrder(Order order)
        {
            var result=await _validator.ValidateAsync(order);
            if (!result.IsValid)
                return new Response<Order>(order, result.ConvertToCustomValidationError());

            var unchanged =await _uow.GetRepository<Order>().FindAsync(order.Id);
            var sum = order.OrderItems.Sum(i => i.ProductPrice * i.Quantity);
            order.TotalPrice = sum + order.ShippingPrice;
            _uow.GetRepository<Order>().Update(order,unchanged);
            await _uow.SaveChangesAsync();
            return new Response<Order>(ResponseType.Success, order);

        }

        public IResponse<int> GetCurrentMountSellerOrderQuantity(Seller seller)
        {
            var CurrentMount = DateTime.Now.Month;
            var ordersCount = seller.Orders.Where(i => i.CreatedDate.Month == CurrentMount).Count();
            return new Response<int>(ResponseType.Success, ordersCount);

        }
        public IResponse<double> GetCompereMountOrderRate(Seller seller)
        {
            var LastMount = DateTime.Now.Month-1;
            var CurrentMount = DateTime.Now.Month;
            var ordersCount = seller.Orders.Where(i => i.CreatedDate.Month == CurrentMount).Count();
            var lastOrdersCount = seller.Orders.Where(i => i.CreatedDate.Month == LastMount).Count();
            double rate = ((CurrentMount - LastMount) * 100)/LastMount;
            return new Response<double>(ResponseType.Success, rate);
        }

        public async Task<IResponse<Order>> GetByIdAsyncR(int id)
        {
            var data = await _context.Orders.Where(i => i.Id == id)
                .Include(i => i.OrderItems).ThenInclude(i => i.Product)
                .Include(i => i.AppUser)
                .Include(i => i.Seller)
                .FirstOrDefaultAsync();
            if (data != null)
                return new Response<Order>(ResponseType.Success, data);
            return new Response<Order>(ResponseType.NotFound, "Data bulunamadı");
        }

        public async Task<IResponse<List<Order>>> GetAllAsyncR()
        {
            var data = await _context.Orders
                .Include(i => i.OrderItems).ThenInclude(i => i.Product)
                .Include(i => i.AppUser)
                .Include(i => i.Seller)
                .ToListAsync();
            return new Response<List<Order>>(ResponseType.Success, data);

        }
    }
}
