using Core.Models;
using Core.Queries;
using Core.Services;
using Core.UseCases;
using Core.Values;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Core.Tests.UseCases
{
    public class GetAllForecastsUseCaseTests
    {
        private readonly IWeatherForecastService _weatherForecastService;
        private readonly ISummariesService _summariesService;

        public GetAllForecastsUseCaseTests()
        {
            _weatherForecastService = Substitute.For<IWeatherForecastService>();

            _summariesService = Substitute.For<ISummariesService>();
            _summariesService
                .GetCount()
                .Returns(5);

            _summariesService
                .GetSummary(Arg.Any<int>())
                .Returns(SummaryText.From("Fake Summary"));
        }

        [Fact]
        public async Task WeatherForecastService_ShouldBeCalled_WhenHandlingGetForecastsQuery()
        {
            //Arrange
            var summary = _summariesService.GetSummary(Arg.Any<int>());
            _weatherForecastService
                .GetMultipleAsync(Arg.Any<int>(), Arg.Any<CancellationToken>())
                .Returns(new List<WeatherForecast>
                {
                    new(DateTime.UtcNow, 23, summary)
                });

            var numberOfRecords = 5;
            var query = new GetForecastsQuery(numberOfRecords);

            var sut = new GetForecastsUseCase(_weatherForecastService);

            //Act
            await sut.Handle(query, CancellationToken.None);

            //Assert
            await _weatherForecastService.Received().GetMultipleAsync(query.NumberOfRecords, CancellationToken.None);
        }
    }
}
