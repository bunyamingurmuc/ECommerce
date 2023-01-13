using ECommerce.BLL.Interfaces;
using ECommerce.DAL.UnitOfWork;
using ECommerce.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Serives;

public class AppUserService : Service<AppUser>, IAppUserService
{
    public readonly IValidator<AppUser> _validator;
    public readonly IUOW _uow;
   

    public AppUserService(IValidator<AppUser> validator, IUOW uow):base(validator,uow)
    {
        _validator = validator;
        _uow = uow;
    }
}
