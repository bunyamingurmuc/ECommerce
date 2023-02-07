using ECommerce.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.ValidationRules
{
    public class CardValidator:AbstractValidator<Card>
    {
        public CardValidator()
        {
           
        }
    }
}
