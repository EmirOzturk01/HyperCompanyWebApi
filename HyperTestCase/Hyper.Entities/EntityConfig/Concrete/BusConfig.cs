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
    public class BusConfig : VehicleConfig<Bus>
    {
        public override void Configure(EntityTypeBuilder<Bus> builder)
        {

            base.Configure(builder);
            //
            builder.HasData(
                new Bus { Id = 1, Color = "red" },
                new Bus { Id = 2, Color = "yellow" },
                new Bus { Id = 3, Color = "white" },
                new Bus { Id = 4, Color = "red" },
                new Bus { Id = 5, Color = "black" },
                new Bus { Id = 6, Color = "white" },
                new Bus { Id = 7, Color = "blue" },
                new Bus { Id = 8, Color = "yellow" },
                new Bus { Id = 9, Color = "cyan" },
                new Bus { Id = 10, Color = "white" },
                new Bus { Id = 11, Color = "cyan" },
                new Bus { Id = 12, Color = "blue" },
                new Bus { Id = 13, Color = "black" },
                new Bus { Id = 14, Color = "red" },
                new Bus { Id = 15, Color = "white" },
                new Bus { Id = 16, Color = "yellow" }
                );
        }
    }
}
