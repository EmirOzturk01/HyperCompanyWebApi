using Hyper.Entities.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyper.Entities.Models.Concrete
{
    public class Car : Vehicle
    {
        public bool HeadlightsOn { get; set; }
        public int Wheels { get; set; }
    }
}
