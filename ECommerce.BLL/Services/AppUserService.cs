using ECommerce.BLL.Interfaces;
using ECommerce.DAL.UnitOfWork;
using ECommerce.Entity;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Common;
using ECommerce.Common.Enums;
using ECommerce.DAL.Context;
using Microsoft.EntityFrameworkCore;
using ECommerce.DTO;
using ECommerce.BLL.Extension.Token;

namespace ECommerce.BLL.Serives;

public class AppUserService : Service<AppUser>, IAppUserService
{
    public readonly IValidator<AppUser> _validator;
    public readonly IUOW _uow;
    public readonly ECommerceContext _context;

    public AppUserService(IValidator<AppUser> validator, IUOW uow, ECommerceContext context) : base(validator, uow)
    {
        _validator = validator;
        _uow = uow;
        _context = context;
    }

    public async Task<IResponse<AppUser>> GetByIdAsyncR(int id)
    {
        var data = await _context.AppUsers.Where(i => i.Id == id)
              .Include(i => i.Reviews)
              .Include(i => i.Card).ThenInclude(i => i.CardItems).ThenInclude(i => i.Product)
              .Include(i => i.Seller)
              .Include(i => i.Orders).ThenInclude(i => i.OrderItems).ThenInclude(i => i.Product)
              .FirstOrDefaultAsync();
        if (data != null)
            return new Response<AppUser>(ResponseType.Success, data);
        return new Response<AppUser>(ResponseType.NotFound, "Data bulunamadı");
    }

    public async Task<IResponse<List<AppUser>>> GetAllAsyncR()
    {
        var data = await _context.AppUsers
            .Include(i => i.Reviews)
            .Include(i => i.Card).ThenInclude(i => i.CardItems).ThenInclude(i => i.Product)
            .Include(i => i.Seller)
            .Include(i => i.Orders).ThenInclude(i => i.OrderItems).ThenInclude(i => i.Product)
            .ToListAsync();

        return new Response<List<AppUser>>(ResponseType.Success,data);
    }

    public async Task<IResponse<AppUser>> CreateUser(CCreateAccountDto dto)
    {
        var appusers = GetAllAsync();
        var appusersmail = appusers.Result.Data.Select(i => i.Email);
        if (appusersmail.Contains(dto.Email))
        {
            return new Response<AppUser>(ResponseType.ValidationError, "Bu mail daha önce alındı");
        }
        if (dto.ConfirmPassword != dto.Password)
        {
            return new Response<AppUser>(ResponseType.ValidationError, "Şifre ve Parola eşleşmiyor");
        }
        AppUser createDto = new()
        {
            Email = dto.Email,
            Name = dto.Name,
            SurName = dto.Surname,
            Password = dto.Password
        };
        var created = await _uow.GetRepository<AppUser>().CreateAsync(createDto);
        return new Response<AppUser>(ResponseType.Success, created);
    }


}
