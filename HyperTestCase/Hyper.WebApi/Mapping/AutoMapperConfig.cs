using AutoMapper;
using Hyper.Entities.Models.Concrete;
using Hyper.WebApi.Models.Dtos.Boat;
using Hyper.WebApi.Models.Dtos.Bus;
using Hyper.WebApi.Models.Dtos.Car;

namespace Hyper.WebApi.Mapping
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<CarUpdateDTO,Car>().ReverseMap();
            CreateMap<CarCreateDTO,Car>().ReverseMap();

            CreateMap<BusUpdateDTO, Bus>().ReverseMap();
            CreateMap<BusCreateDTO, Bus>().ReverseMap();

            CreateMap<BoatUpdateDTO, Boat>().ReverseMap();
            CreateMap<BoatCreateDTO, Boat>().ReverseMap();
        }
    }
}
