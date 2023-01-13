using ECommerce.BLL.Interfaces;
using ECommerce.BLL.Serives;
using ECommerce.DAL.UnitOfWork;
using ECommerce.Entity;
using FluentValidation;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.BLL.Services
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IValidator<Product> _validator;
        private readonly IUOW _uow;
 

        public ProductService(IValidator<Product> validator, IUOW uow):base(validator, uow)
        {
            _validator = validator;
            _uow = uow;
        }
    }
}
