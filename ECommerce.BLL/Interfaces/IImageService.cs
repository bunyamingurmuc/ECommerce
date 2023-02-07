using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECommerce.Common;
using ECommerce.Entity;

namespace ECommerce.BLL.Interfaces
{
    public interface IImageService:IService<Image>
    {
        Task<IResponse<Image>> GetByIdAsyncR(int id);
        Task<IResponse<List<Image>>> GetAllAsyncR();
    }
}
