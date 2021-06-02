using Core.Models;
using MediatR;
using System.Collections.Generic;

namespace Core.Queries
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
