using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Fp.Hvr.Api.ViewModels;
using Fp.Hvr.Contracts;

namespace Fp.Hvr.Api.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<WeatherForecast, WeatherForecastViewModel>()
                .ForMember(dest => dest.Summary, opt => opt.MapFrom(src => src.Summary.Value))
                .ForMember(dest => dest.TemperatureC, opt => opt.MapFrom(src => src.TemperatureC.Value))
                .ForMember(dest => dest.TemperatureF, opt => opt.MapFrom(src => src.TemperatureF.Value))
                .ReverseMap();

            //CreateMap<WeatherForecastViewModel, WeatherForecast>();
        }
    }
}
