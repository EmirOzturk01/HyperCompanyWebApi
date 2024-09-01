using Hyper.BL.Managers.Abstract;
using Hyper.BL.Managers.Concrete;
using System.Runtime.CompilerServices;

namespace Hyper.WebApi.Extentions
{
    public static class AppExtensions
    {
       public static void AddScopes(this IServiceCollection services)
        {
            services.AddScoped<IBoatManager, BoatManager>();
            services.AddScoped<ICarManager, CarManager>();
            services.AddScoped<IBusManager, BusManager>();
        }
    }
}
