using System.Collections.Generic;
using Fp.Hvr.Contracts;
using MediatR;

namespace Fp.Hvr.Core.Queries
{
    public class GetForecastsQuery : IRequest<IEnumerable<WeatherForecast>>
    {
        public GetForecastsQuery(int numberOfRecords)
        {
            NumberOfRecords = numberOfRecords;
        }

        public int NumberOfRecords { get; }
    }
}
