using Fp.Hvr.Core.Models;
using Fp.Hvr.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Fp.Hvr.Infrastructure.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly ISummariesService _summariesService;

        public WeatherForecastService(ISummariesService summariesService)
        {
            _summariesService = summariesService;
        }

        public async Task<IEnumerable<WeatherForecast>> GetMultipleAsync(int requestNumberOfRecords, CancellationToken cancellationToken)
        {
            var summariesCount = _summariesService.GetCount();

            var rng = new Random();
            var result = Enumerable.Range(1, requestNumberOfRecords).Select(index =>
                    new WeatherForecast(
                        DateTime.Now.AddDays(index),
                        rng.Next(-20, 55),
                        _summariesService.GetSummary(rng.Next(summariesCount)
                        )))
                .ToArray();

            return await Task.FromResult(result);
        }
    }
}
