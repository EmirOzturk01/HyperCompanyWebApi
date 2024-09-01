using Hyper.DAL.Repository.Abstract;
using Hyper.Entities.DbContexts;
using Hyper.Entities.Models.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hyper.DAL.Repository.Concrete
{
    public class Repository<T> : IRepository<T> where T : Vehicle
    {

        readonly AppDbContext _dbContext;
        readonly DbSet<T> _dbSet;
        public Repository()
        {
            _dbContext = new AppDbContext();
            _dbSet = _dbContext.Set<T>();
        }

        public virtual async Task<int> DeleteAsync(T input)
        {
            _dbSet.Remove(input);
            return await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<int> InsertAsync(T input)
        {
            await _dbContext.Set<T>().AddAsync(input);
            return _dbContext.SaveChanges();
        }

        public virtual async Task<int> UpdateAsync(T input)
        {
            _dbSet.Update(input);
            return await _dbContext.SaveChangesAsync();
        }

        public virtual async Task<List<T>> GetAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public virtual async Task<T> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }
        public virtual async Task<IEnumerable<T>> GetByColorAsync(string color)
        {
            return await _dbSet.Where(c => c.Color.ToLower() == color.ToLower()).ToListAsync();
        }
    }
}
