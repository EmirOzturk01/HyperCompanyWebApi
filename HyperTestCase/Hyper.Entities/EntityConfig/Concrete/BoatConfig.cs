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
    public class BoatConfig : VehicleConfig<Boat>
    {
        public override void Configure(EntityTypeBuilder<Boat> builder)
        {

            base.Configure(builder);
            //
            builder.HasData(
                new Boat { Id = 1, Color = "red" },
                new Boat { Id = 2, Color = "blue" },
                new Boat { Id = 3, Color = "white" },
                new Boat { Id = 4, Color = "red" },
                new Boat { Id = 5, Color = "black" },
                new Boat { Id = 6, Color = "white" },
                new Boat { Id = 7, Color = "blue" },
                new Boat { Id = 8, Color = "black" },
                new Boat { Id = 9, Color = "cyan" },
                new Boat { Id = 10, Color = "white" },
                new Boat { Id = 11, Color = "cyan" },
                new Boat { Id = 12, Color = "blue" },
                new Boat { Id = 13, Color = "black" },
                new Boat { Id = 14, Color = "red" },
                new Boat { Id = 15, Color = "white" },
                new Boat { Id = 16, Color = "red" }
                );
        }
    }
}
