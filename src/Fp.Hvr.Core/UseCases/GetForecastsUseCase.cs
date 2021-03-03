using Fp.Hvr.Core.Models;
using Fp.Hvr.Core.Queries;
using Fp.Hvr.Core.Services;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Fp.Hvr.Core.UseCases
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
