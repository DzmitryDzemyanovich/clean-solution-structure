using AutoMapper;
using Fp.Hvr.Core.Services;
using Fp.Hvr.Infrastructure.Services;
using MediatR;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Fp.Hvr.Infrastructure
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<IWeatherForecastService, WeatherForecastService>();
            services.AddSingleton<ISummariesService, SummariesService>();

            services.AddMediatR(typeof(Core.RootModule).GetTypeInfo().Assembly);
            services.AddAutoMapper(typeof(Mappings.MappingProfile));
            return services;
        }
    }
}
