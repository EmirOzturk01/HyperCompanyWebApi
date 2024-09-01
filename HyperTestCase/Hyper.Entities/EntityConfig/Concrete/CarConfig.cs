using Hyper.Entities.EntityConfig.Abstract;
using Hyper.Entities.Models.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hyper.Entities.EntityConfig.Concrete
{
    public class CarConfig : VehicleConfig<Car>
    {
        public override void Configure(EntityTypeBuilder<Car> builder)
        {

            base.Configure(builder);
            //
            builder.HasData(
               new Car { Id = 1, Color = "red", HeadlightsOn = true, Wheels = 4 },
               new Car { Id = 2, Color = "black", HeadlightsOn = false, Wheels = 4 },
               new Car { Id = 3, Color = "white", HeadlightsOn = false, Wheels = 4 },
               new Car { Id = 4, Color = "blue", HeadlightsOn = true, Wheels = 4 },
               new Car { Id = 5, Color = "yellow", HeadlightsOn = true, Wheels = 4 },
               new Car { Id = 6, Color = "yellow", HeadlightsOn = false, Wheels = 4 },
               new Car { Id = 7, Color = "blue", HeadlightsOn = false, Wheels = 4 },
               new Car { Id = 8, Color = "white", HeadlightsOn = false, Wheels = 4 },
               new Car { Id = 9, Color = "black", HeadlightsOn = true, Wheels = 4 },
               new Car { Id = 10, Color = "red", HeadlightsOn = false, Wheels = 4 },
               new Car { Id = 11, Color = "black", HeadlightsOn = true, Wheels = 4 },
               new Car { Id = 12, Color = "white", HeadlightsOn = true, Wheels = 4 },
               new Car { Id = 13, Color = "blue", HeadlightsOn = false, Wheels = 4 },
               new Car { Id = 14, Color = "yellow", HeadlightsOn = true, Wheels = 4 }
               );
        }
    }
}
