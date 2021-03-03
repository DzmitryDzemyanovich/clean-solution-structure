using Fp.Hvr.Core.Models;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Fp.Hvr.Core.Services
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> GetMultipleAsync(int requestNumberOfRecords, CancellationToken cancellationToken);
    }
}
