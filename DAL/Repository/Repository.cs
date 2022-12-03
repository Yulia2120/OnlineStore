﻿using Logic.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repository
{
    public class Repository<T> : IRepository<T> where T : IIdentity
    {
        public Context _context;
        public IUnitOfWork _ofWork;

        public Repository(Context context)
        {
            _context = context;
        }

        public Repository(IUnitOfWork ofWork)
        {
            _ofWork = ofWork;
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
        public async Task<T> EditAsync(T item)
        {
            _context.Attach(item).State = EntityState.Modified;
                await _context.SaveChangesAsync();
            return item;
        }
        public async Task<T> DeleteAsync(T item)
        {
            
                _context.Set<T>().Remove(item);
                await _context.SaveChangesAsync();
            
            return item;
        }

        public async Task<T> Find(int? id)
        {
            return await _context.Set<T>().FindAsync(id);

        }
    }
}
