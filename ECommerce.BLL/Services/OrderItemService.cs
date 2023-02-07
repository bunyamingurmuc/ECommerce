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
using ECommerce.Common;
using ECommerce.BLL.Extension;
using ECommerce.Common.Enums;
using ECommerce.DAL.Context;
using ECommerce.Entity.Interface;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.BLL.Services
{
    public class OrderItemService : Service<OrderItem>, IOrderItemService
    {
        private readonly IValidator<OrderItem> _validator;
        private readonly IUOW _uow;
        public readonly ECommerceContext _context;
        public OrderItemService(IValidator<OrderItem> validator, IUOW uow, ECommerceContext context) : base(validator, uow)
        {
            _validator = validator;
            _uow = uow;
            _context = context;
        }

        public async Task<IResponse<OrderItem>> OrderItemCreate(OrderItem orderItem)
        {
            orderItem.ImageUrl = orderItem.Product.Images[0].Url;
            orderItem.ProductPrice=orderItem.Product.Price;
            orderItem.ProductName=orderItem.Product.Name;
            orderItem.ProductDiscount = orderItem.Product.Discount;
            var result=await _validator.ValidateAsync(orderItem);
            if (result.IsValid)
            {
                var created =await CreateAsync(orderItem);
                return new Response<OrderItem>(ResponseType.Success, created.Data);
            }
            else
            {
                return new Response<OrderItem>(orderItem, result.ConvertToCustomValidationError());

            }

        }

        public async Task<IResponse<List<OrderItem>>> GetRecentOrderItemsWithCategory(int categoryId)
        {
            var orderItem =await _uow.GetRepository<OrderItem>().GetAllAsync();
            var categoryOrders=orderItem.Where(i => i.Product.CategoryId == categoryId).ToList();
            return new Response<List<OrderItem>>(ResponseType.Success, categoryOrders);

        }

        public async Task<IResponse<OrderItem>> GetByIdAsyncR(int id)
        {
            var data = await _context.OrderItems.Where(i => i.Id == id)
                .Include(i=>i.Product)
                .Include(i => i.Order)
                .SingleOrDefaultAsync();
            if (data != null)
                return new Response<OrderItem>(ResponseType.Success, data);
            return new Response<OrderItem>(ResponseType.NotFound, "Data bulunamadı");
        }

        public async Task<IResponse<List<OrderItem>>> GetAllAsyncR()
        {
            var data = await _context.OrderItems
                .Include(i => i.Product)
                .Include(i => i.Order)
                .ToListAsync();
        return new Response<List<OrderItem>>(ResponseType.Success,data);

        }
    }
}
