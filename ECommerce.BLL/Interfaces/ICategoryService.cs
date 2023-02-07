using ECommerce.Common;
using ECommerce.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.BLL.Interfaces
{
    public interface ICategoryService:IService<Category>
    {
        Task<IResponse<Category>> GetByIdAsyncR(int id);
        Task<IResponse<List<Category>>> GetAllAsyncR();
        Task<IResponse<Category>> CreateS(int categoryId, Category category);

    }
}
