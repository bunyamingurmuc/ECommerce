using ECommerce.Common;
using ECommerce.Entity.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Interfaces
{
    public interface IService<Entity>
     where Entity : BaseEntity, new()
    {
       IResponse<List<Entity>> GetAll();
       IResponse<Entity?> GetById(int id);
       IResponse<Entity> Create(Entity entity);
       IResponse<Entity> Update(Entity changed);
       IResponse Remove(int id);




        Task<IResponse<List<Entity>>> GetAllAsync();
        Task<IResponse<Entity>>? GetByIdAsync(int id);
        Task<IResponse<Entity>> CreateAsync(Entity entity);
        Task<IResponse<Entity>> UpdateAsync(Entity changed);
        Task<IResponse> RemoveAsync(int id);
    }
}
