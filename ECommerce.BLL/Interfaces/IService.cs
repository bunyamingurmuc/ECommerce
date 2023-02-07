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
        Task<IResponse<List<Entity>>> GetAllAsync();
        Task<IResponse<Entity>>? GetByIdAsync(int id);
        Task<IResponse<Entity>> CreateAsync(Entity entity);
        Task<IResponse<Entity>> UpdateAsync(Entity changed);
        Task<IResponse> RemoveAsync(int id);
        Task<IResponse<List<Entity>>> CreateRangeAsync(List<Entity> entities);
    }
}
