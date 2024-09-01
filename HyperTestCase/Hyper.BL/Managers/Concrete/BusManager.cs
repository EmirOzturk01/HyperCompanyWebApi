using Hyper.BL.Managers.Abstract;
using Hyper.Entities.DbContexts;
using Hyper.Entities.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyper.BL.Managers.Concrete
{
    public class BusManager : ManagerBase<Bus>,IBusManager
    {
        private readonly AppDbContext _context;
        public BusManager(AppDbContext context) : base(context)
        {
            _context = context;
        }
    }
}
