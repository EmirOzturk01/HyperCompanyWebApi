using Hyper.BL.Managers.Abstract;
using Hyper.DAL.Repository.Concrete;
using Hyper.Entities.DbContexts;
using Hyper.Entities.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyper.BL.Managers.Concrete
{
    public class ManagerBase<T> : Repository<T>, IManager<T> where T : Vehicle
    {
        private readonly AppDbContext _context;
        public ManagerBase(AppDbContext context)
        {
            _context = context;
        }
    }
}
