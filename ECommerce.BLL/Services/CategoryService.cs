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
    public class CategoryService : Service<Category>, ICategoryService
    {
        public readonly IValidator<Category> _validator;
        public readonly IUOW _uow;

        public CategoryService(IValidator<Category> validator, IUOW uow):base(validator,uow)
        {
            _validator = validator;
            _uow = uow;
        }
    }
}
