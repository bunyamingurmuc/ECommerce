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
    public class SellerService : Service<Seller>, ISellerService
    {
        public SellerService(IValidator<Seller> validator, IUOW uow) : base(validator, uow)
        {
        }
    }
}
