using ECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Common;
using ECommerce.DTO;

namespace ECommerce.BLL.Interfaces
{
    public interface IAppUserService : IService<AppUser>
    {
        Task<IResponse<AppUser>> GetByIdAsyncR(int id);
        Task<IResponse<List<AppUser>>> GetAllAsyncR();
        Task<IResponse<AppUser>> CreateUser(CCreateAccountDto dto);
    }
}
