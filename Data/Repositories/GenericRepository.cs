using Core.Abstracts.IRepositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected DbContext _context;
        protected DbSet<T> _set;

        public GenericRepository(DbContext context)
        {
            _context = context;
            _set = _context.Set<T>();
        }

        public async Task<int> CountAsync(Expression<Func<T, bool>>? predicate = null)
        {
            return predicate != null ? await _set.CountAsync(predicate) : await _set.CountAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            await Task.Run(() => _set.Remove(entity));
        }

        public async Task DeleteMany(IEnumerable<T> entities)
        {
            await Task.Run(() => _set.RemoveRange(entities));
        }

        public async Task DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<bool> ExistsAsync(Expression<Func<T, bool>> predicate)
        {
            return await _set.AnyAsync(predicate);
        }

        public async Task<IEnumerable<T>> FindManyAsync(Expression<Func<T, bool>>? predicate = null, Expression<Func<T, object>>[]? includes = null)
        {
            IQueryable<T> values = predicate != null ? _set.Where(predicate) : _set;
            if (includes != null)
            {
                foreach (var include in includes)
                {
                    values = values.Include(include);
                }
            }
            return await values.ToListAsync();
        }

        public async Task<T?> FindOneAsync(object entityKey)
        {
            return await _set.FindAsync(entityKey);
        }

        public async Task InsertManyAsync(IEnumerable<T> entities)
        {
            await _set.AddRangeAsync(entities);
        }

        public async Task InsertOneAsync(T entity)
        {
            await _set.AddAsync(entity);
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            await Task.Run(() => _set.Update(entity));
        }

        public async Task UpdateMany(IEnumerable<T> entities)
        {
            await Task.Run(() => _set.UpdateRange(entities));
        }
    }
}
