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
using ECommerce.Common;
using ECommerce.Common.Enums;
using ECommerce.DAL.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.BLL.Services
{
    public class CardItemService : Service<CardItem>, ICardItemService
    {
        public readonly ECommerceContext _context;
        public CardItemService(IValidator<CardItem> validator, IUOW uow, ECommerceContext context) : base(validator, uow)
        {
            _context = context;
        }

        public async Task<IResponse<CardItem>> GetByIdAsyncR(int id)
        {
         var data=  await _context.CardItems.Where(i => i.Id == id)
                .Include(i => i.Card)
                .Include(i => i.Product)
                .FirstOrDefaultAsync();
         if (data != null)
         {
             return new Response<CardItem>(ResponseType.Success, data);
         }
         else
         {
             return new Response<CardItem>(ResponseType.NotFound, "Data bulunamadı");

         }
        }

        public async Task<IResponse<List<CardItem>>> GetAllAsyncR()
        {
            var data = await _context.CardItems
                .Include(i => i.Card)
                .Include(i => i.Product)
                .ToListAsync();
            return new Response<List<CardItem>>(ResponseType.Success, data);

        }
    }
}
