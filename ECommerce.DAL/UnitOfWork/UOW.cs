using ECommerce.DAL.Abstract;
using ECommerce.DAL.Context;
using ECommerce.DAL.Interface;

namespace ECommerce.DAL.UnitOfWork
{
    public class UOW : IUOW
    {
        private readonly ECommerceContext _context;

        public UOW(ECommerceContext context)
        {
            _context = context;
        }

        public IRepository<T> GetRepository<T>() where T : class
        {
            return new Repository<T>(_context);
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
