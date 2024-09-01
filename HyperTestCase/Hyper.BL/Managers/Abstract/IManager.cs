using Hyper.DAL.Repository.Abstract;
using Hyper.Entities.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyper.BL.Managers.Abstract
{
    public interface IManager<T>:IRepository<T> where T : Vehicle
    {
    }
}
