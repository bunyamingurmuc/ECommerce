using ECommerce.BLL.Interfaces;
using ECommerce.BLL.Serives;
using ECommerce.DAL.UnitOfWork;
using ECommerce.Entity;
using FluentValidation;

namespace ECommerce.BLL.Services
{
    public class ReviewService : Service<Review>, IReviewService
    {
        private readonly IValidator<Review> _validator;
        private readonly IUOW _uow;

        public ReviewService(IValidator<Review> validator, IUOW uow):base(validator, uow)
        {
            _validator = validator;
            _uow = uow;
        }
    }
}
