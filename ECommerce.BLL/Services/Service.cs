using ECommerce.BLL.Extension;
using ECommerce.BLL.Interfaces;
using ECommerce.Common;
using ECommerce.Common.Enums;
using ECommerce.DAL.UnitOfWork;
using ECommerce.Entity.Interface;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Serives;

public class Service<Entity> : IService<Entity>
 where Entity : BaseEntity, new()

{
    private readonly IValidator<Entity> _validator;
    private readonly IUOW _uow;
    public Service( IValidator<Entity> validator, IUOW uow)
    {
        _uow = uow;
        _validator = validator;
    }

    public  IResponse<Entity> Create(Entity entity)
    {
       var result= _validator.Validate(entity);
        if (result.IsValid)
        {
            var created= _uow.GetRepository<Entity>().Create(entity);
            _uow.SaveChanges();
            return new Response<Entity>(ResponseType.Success,created);
        }
        return new Response<Entity>(entity, result.ConvertToCustomValidationError());

    }

    public async Task<IResponse<Entity>> CreateAsync(Entity entity)
    {
        var result = await _validator.ValidateAsync(entity);
        if (result.IsValid)
        {
            var created = await _uow.GetRepository<Entity>().CreateAsync(entity);
            await _uow.SaveChangesAsync();

            return new Response<Entity>(ResponseType.Success, created);
        }
        return new Response<Entity>(entity, result.ConvertToCustomValidationError());

    }

    public IResponse<List<Entity>> GetAll()
    {
        var entities= _uow.GetRepository<Entity>().GetAll();
        return new Response<List<Entity>>(ResponseType.Success,entities);
    }

    public async Task<IResponse<List<Entity>>> GetAllAsync()
    {
        var entities = await _uow.GetRepository<Entity>().GetAllAsync();
        return new Response<List<Entity>>(ResponseType.Success, entities);
    }

    public IResponse<Entity?> GetById(int id)
    {
        var entity = _uow.GetRepository<Entity>().Find(id);
        if (entity==null)
        {
            return new Response<Entity>(ResponseType.NotFound, "Data bulunamadı");
        }
        return new Response<Entity>(ResponseType.Success,entity);
    }

    public async Task<IResponse<Entity>>? GetByIdAsync(int id)
    {
        var entity =await _uow.GetRepository<Entity>().FindAsync(id);
        if (entity == null)
        {
            return new Response<Entity>(ResponseType.NotFound, "Data bulunamadı");
        }
        return new Response<Entity>(ResponseType.Success, entity);
    }

    public IResponse Remove(int id)
    {
        var entity= _uow.GetRepository<Entity>().Find(id);
        if (entity==null)
        {
            return new Response<Entity>(ResponseType.NotFound, "Data bulunamadı");
        }
        _uow.GetRepository<Entity>().Remove(entity);
        _uow.SaveChanges();
        return new Response(ResponseType.Success);
    }

    public async Task<IResponse> RemoveAsync(int id)
    {
        var entity =await _uow.GetRepository<Entity>().FindAsync(id);
        if (entity == null)
        {
            return new Response<Entity>(ResponseType.NotFound, "Data bulunamadı");
        }
        _uow.GetRepository<Entity>().Remove(entity);
       await _uow.SaveChangesAsync();
        return new Response(ResponseType.Success);
    }

    public IResponse<Entity> Update(Entity changed)
    {
       var result=_validator.Validate(changed);
        if (result.IsValid)
        {
           var unchanged= _uow.GetRepository<Entity>().Find(changed.Id);
            if (unchanged==null)
            {
                new Response<Entity>(ResponseType.NotFound, "Data bulunamadı");
            }
            _uow.GetRepository<Entity>().Update(changed,unchanged);
            _uow.SaveChanges();
            return new Response<Entity>(ResponseType.Success, changed);
        }
        return new Response<Entity>(changed, result.ConvertToCustomValidationError());
    }

    public async Task<IResponse<Entity>> UpdateAsync(Entity changed)
    {
        var result =await _validator.ValidateAsync(changed);
        if (result.IsValid)
        {
            var unchanged =await _uow.GetRepository<Entity>().FindAsync(changed.Id);
            if (unchanged == null)
            {
                new Response<Entity>(ResponseType.NotFound, "Data bulunamadı");
            }
            _uow.GetRepository<Entity>().Update(changed, unchanged);
          await  _uow.SaveChangesAsync();
            return new Response<Entity>(ResponseType.Success, changed);
        }
        return new Response<Entity>(changed, result.ConvertToCustomValidationError());
    }
}
