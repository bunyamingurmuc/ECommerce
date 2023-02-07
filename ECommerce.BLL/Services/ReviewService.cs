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
    public class ReviewService : Service<Review>, IReviewService
    {
        private readonly IValidator<Review> _validator;
        private readonly IUOW _uow;
        private readonly ECommerceContext _context;

        public ReviewService(IValidator<Review> validator, IUOW uow, ECommerceContext context):base(validator, uow)
        {
            _validator = validator;
            _uow = uow;
            _context = context;
        }

        public async Task<IResponse<Review>> GetByIdAsyncR(int id)
        {
            var data = await _context.Reviews.Where(i => i.Id == id)
                .Include(i => i.AppUser)
                .Include(i => i.Product)
                .FirstOrDefaultAsync();
            if (data != null)
                return new Response<Review>(ResponseType.Success, data);
            return new Response<Review>(ResponseType.NotFound, "Data bulunamadı");
        }

        public async Task<IResponse<List<Review>>> GetAllAsyncR()
        {
            var data = await _context.Reviews
                .Include(i => i.AppUser)
                .Include(i => i.Product)
                .ToListAsync();
            return new Response<List<Review>>(ResponseType.Success, data);

        }
    }
}
