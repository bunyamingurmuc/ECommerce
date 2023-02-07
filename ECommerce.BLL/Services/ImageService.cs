using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ECommerce.BLL.Interfaces;
using ECommerce.BLL.Serives;
using ECommerce.Common;
using ECommerce.Common.Enums;
using ECommerce.DAL.Context;
using ECommerce.DAL.UnitOfWork;
using ECommerce.Entity;
using FluentValidation;
using Microsoft.EntityFrameworkCore;

namespace ECommerce.BLL.Services
{
    public class ImageService : Service<Image>, IImageService
    {
        public readonly ECommerceContext _context;
        public ImageService(IValidator<Image> validator, IUOW uow, ECommerceContext context) : base(validator, uow)
        {
            _context = context;
        }

        public async Task<IResponse<Image>> GetByIdAsyncR(int id)
        {
            var data = await _context.Images.Where(i => i.Id == id)
                .Include(i => i.Product)
                .FirstOrDefaultAsync();
            if (data != null)
                return new Response<Image>(ResponseType.Success, data);
            return new Response<Image>(ResponseType.NotFound, "Data bulunamadı");
        }

        public async Task<IResponse<List<Image>>> GetAllAsyncR()
        {
            var data = await _context.Images
                .Include(i => i.Product)
                .ToListAsync();
            return new Response<List<Image>>(ResponseType.Success, data);

        }
    }
}
