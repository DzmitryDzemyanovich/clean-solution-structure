using Core.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Core.Services
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> GetMultipleAsync(int requestNumberOfRecords, CancellationToken cancellationToken);
    }
}
