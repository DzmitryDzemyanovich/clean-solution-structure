using Core.Models;
using Core.Queries;
using Core.Services;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Core.UseCases
{
    public class GetForecastsUseCase : IRequestHandler<GetForecastsQuery, IEnumerable<WeatherForecast>>
    {
        private readonly IWeatherForecastService _weatherForecastService;

        public GetForecastsUseCase(IWeatherForecastService weatherForecastService)
        {
            _weatherForecastService = weatherForecastService;
        }

        public async Task<IEnumerable<WeatherForecast>> Handle(GetForecastsQuery query, CancellationToken cancellationToken)
        {
            return await _weatherForecastService.GetMultipleAsync(query.NumberOfRecords, cancellationToken);
        }
    }
}
