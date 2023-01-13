using ECommerce.DAL.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.DAL.UnitOfWork
{

    public interface IUOW
    {
        IRepository<T> GetRepository<T>() where T : class;
        Task SaveChangesAsync();
        void SaveChanges();
    }
}
