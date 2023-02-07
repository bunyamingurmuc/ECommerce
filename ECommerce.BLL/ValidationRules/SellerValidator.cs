using ECommerce.Entity;
using FluentValidation;

namespace ECommerce.BLL.ValidationRules
{
    public class SellerValidator: AbstractValidator<Seller>
    {
        public SellerValidator()
        {
            RuleFor(i => i.Name).NotNull().WithMessage("İsim alanı boş geçilemez");
            RuleFor(i => i.SurName).NotNull().WithMessage("Soy Ad alanı boş geçilemez");
        }
    }
}
