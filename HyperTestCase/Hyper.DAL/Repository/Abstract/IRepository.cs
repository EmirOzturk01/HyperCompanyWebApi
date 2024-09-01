using Hyper.Entities.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Hyper.DAL.Repository.Abstract
{
    public interface IRepository<T> where T : Vehicle
    {
        Task<int> InsertAsync(T input);
        Task<int> UpdateAsync(T input);
        Task<int> DeleteAsync(T input);
        Task<List<T>> GetAllAsync();
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetByColorAsync(string color);
    }
}
