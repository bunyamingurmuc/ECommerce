using ECommerce.BLL.Extension;
using ECommerce.BLL.Interfaces;
using ECommerce.BLL.Serives;
using ECommerce.Common;
using ECommerce.Common.Enums;
using ECommerce.DAL.Context;
using ECommerce.DAL.UnitOfWork;
using ECommerce.Entity;
using FluentValidation;
using Microsoft.AspNetCore.Mvc.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.BLL.Services
{
    public class CardService : Service<Card>, ICardService
    {
        public readonly IUOW _uow;
        public readonly IValidator<Card> _validator;
        public readonly ICardItemService _cardItemService;
        private readonly ECommerceContext _context;


        public CardService(IValidator<Card> validator, IUOW uow, ICardItemService cardItemService, ECommerceContext context) : base(validator, uow)
        {
            _validator = validator;
            _uow = uow;
            _cardItemService = cardItemService;
            _context = context;
        }
        public async Task<IResponse<Card>> CreateCard(Card card,int userId)
        {
            var productPrice = card.CardItems.Sum(i => i.Product.Price * i.Quantity);
            card.TotalPrice = productPrice;
            card.AppUserId= userId;
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

        public async Task<IResponse<Card>> GetByIdAsyncR(int id)
        {
            var data = await _context.Cards.Where(i => i.Id == id)
                .Include(i => i.CardItems).ThenInclude(i => i.Product).ThenInclude(i=>i.Images)
                .Include(i => i.AppUser)
                .FirstOrDefaultAsync();
            if (data != null)
                return new Response<Card>(ResponseType.Success, data);
            return new Response<Card>(ResponseType.NotFound, "Data bulunamadı");
        }

        public async Task<IResponse<List<Card>>> GetAllAsyncR()
        {
            var data = await _context.Cards
                .Include(i => i.CardItems).ThenInclude(i => i.Product).ThenInclude(i => i.Images)
                .Include(i => i.AppUser)
                .ToListAsync();
            return new Response<List<Card>>(ResponseType.Success, data);
        }

        public async Task<IResponse<Card>> UpdateCard(Card card)
        {
            var result = await _validator.ValidateAsync(card);
            var unchanged = await _uow.GetRepository<Card>().FindAsync(card.Id);
            var productPrice = card.CardItems.Sum(i => i.Product.Price * i.Quantity);
            card.TotalPrice = productPrice;
            if (result.IsValid)
            {
               _uow.GetRepository<Card>().Update(card, unchanged);
               await _uow.SaveChangesAsync();
               return new Response<Card>(ResponseType.Success, card);
            }
            return new Response<Card>(card, result.ConvertToCustomValidationError());


        }
    }
}
