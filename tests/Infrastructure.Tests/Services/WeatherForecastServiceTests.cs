using FluentAssertions;
using Core.Services;
using Core.Values;
using Infrastructure.Services;
using NSubstitute;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Infrastructure.Tests.Services
{
    public class WeatherForecastServiceTests
    {
        private readonly ISummariesService _summariesService;

        public WeatherForecastServiceTests()
        {
            _summariesService = Substitute.For<ISummariesService>();

            _summariesService
                .GetCount()
                .Returns(5);

            _summariesService
                .GetSummary(Arg.Any<int>())
                .Returns(SummaryText.From("Fake Summary"));
        }

        [Fact]
        public async Task WeatherForecastService_ReturnsCollectionOfItems_WhenAmountOfItemsWasRequested()
        {
            //Arrange
            var numberOfRecords = 5;

            var sut = new WeatherForecastService(_summariesService);

            //Act
            var result = await sut.GetMultipleAsync(numberOfRecords, CancellationToken.None);

            //Assert
            result.Should().HaveCount(numberOfRecords);
        }
    }
}
