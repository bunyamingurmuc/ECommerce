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
using ECommerce.BLL.Extension;
using ECommerce.Common;
using ECommerce.DAL.Context;
using Microsoft.EntityFrameworkCore;
using ECommerce.Common.Enums;
using ECommerce.BLL.ValidationRules;

namespace ECommerce.BLL.Services
{
    public class CategoryService : Service<Category>, ICategoryService
    {
        public readonly IValidator<Category> _validator;
        public readonly IUOW _uow;
        public readonly ECommerceContext _context;

        public CategoryService(IValidator<Category> validator, IUOW uow, ECommerceContext context) : base(validator, uow)
        {
            _validator = validator;
            _uow = uow;
            _context = context;
        }

        public async Task<IResponse<Category>> GetByIdAsyncR(int id)
        {
            var asddsada = _context.Categories.AsQueryable();
            var data = await _context.Categories.Where(i => i.Id == id)
                .Include(i => i.Products)
                .Include(i => i.Image)
                .Include(i => i.Seller)
                //.ThenInclude(i => i.Products)
                .SingleOrDefaultAsync();
            if (data != null)
                return new Response<Category>(ResponseType.Success, data);
            return new Response<Category>(ResponseType.NotFound, "Data bulunamadı");
        }

        public async Task<IResponse<List<Category>>> GetAllAsyncR()
        {
            var data = await _context.Categories
                .Include(i => i.Products)
                .Include(i => i.Seller).ThenInclude(i => i.Products)
                .ToListAsync();
            return new Response<List<Category>>(ResponseType.Success, data);
        }
        public async Task<IResponse<Category>> CreateS(int sellerId, Category entity)
        {
            var result = await _validator.ValidateAsync(entity);
            if (result.IsValid)
            {
                entity.SellerId = sellerId;
                var created = await _uow.GetRepository<Category>().CreateAsync(entity);
                return new Response<Category>(ResponseType.Success, created);
            }
            return new Response<Category>(entity, result.ConvertToCustomValidationError());
        }

    }
}
