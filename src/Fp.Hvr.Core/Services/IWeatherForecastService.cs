using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Fp.Hvr.Contracts;

namespace Fp.Hvr.Core.Services
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecast>> GetMultipleAsync(int requestNumberOfRecords, CancellationToken cancellationToken);
    }
}
