using ECommerce.BLL.Extension;
using ECommerce.BLL.Interfaces;
using ECommerce.BLL.Serives;
using ECommerce.Common;
using ECommerce.DAL.UnitOfWork;
using ECommerce.Entity;
using FluentValidation;

namespace ECommerce.BLL.Services
{
    public class CardService : Service<Card>, ICardService
    {
        public readonly IUOW _uow;
        public readonly IValidator<Card> _validator;

        public CardService(IValidator<Card> validator, IUOW uow) : base(validator, uow)
        {
            _validator = validator;
            _uow = uow;
        }


        public async Task<IResponse<Card>> CalculateAndCreateAsync(Card card)
        {
            var productPrice = card.CardItems.Sum(i => i.Product.Price * i.Quantity);
            card.TotalPrice = productPrice;
            var result = await _validator.ValidateAsync(card);
            if (result.IsValid)
            {
                if (card.Discount != 0)
                {
                    card.TotalPrice = card.TotalPrice * ((100 - card.Discount) / 100);
                }
                await CreateAsync(card);
                return new Response<Card>(Common.Enums.ResponseType.Success, card);
            }
            else
            {
                return new Response<Card>(card, result.ConvertToCustomValidationError());
            }
        }

        public IResponse<Card> CalculateAndCreate(Card card)
        {
            var productPrice = card.CardItems.Sum(i => i.Product.Price * i.Quantity);
            card.TotalPrice = productPrice;
            var result = _validator.Validate(card);
            if (result.IsValid)
            {
                if (card.Discount != 0)
                {
                    card.TotalPrice = card.TotalPrice * ((100 - card.Discount) / 100);
                }
                Create(card);
                return new Response<Card>(Common.Enums.ResponseType.Success, card);
            }
            else
            {
                return new Response<Card>(card, result.ConvertToCustomValidationError());

            }
        }
    }
}
