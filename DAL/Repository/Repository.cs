using Logic.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : IIdentity
    {
        private Context _context;
        private readonly int id;

        public Repository(Context context)
        {
            _context = context;
        }
        public async Task<T> CreateAsync(T item)
        {
            await _context.Set<T>().AddAsync(item);
            await _context.SaveChangesAsync();
            return item;
        }


        public async Task<List<T>> GetAllAsync()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task<T> UpdateAsync(T item)
        {
            _context.Set<T>().Update(item);
            await _context.SaveChangesAsync();
            return item;
        }
        public async Task<bool> DeleteAsync(T item)
        {
            var result = await _context.Set<T>()
              .FirstOrDefaultAsync(e => e.Id == id);
            if (item != null)
            {
                _context.Set<T>().Remove(item);
                await _context.SaveChangesAsync();
            }
            return true;
        }

        public async Task<T> UpdateAsync(int? id)
        {
            return await _context.Set<T>().FindAsync(id);
            
        }
    }
}
