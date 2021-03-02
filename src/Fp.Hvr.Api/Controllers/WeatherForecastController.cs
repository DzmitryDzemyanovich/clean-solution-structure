using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Fp.Hvr.Api.ViewModels;
using Fp.Hvr.Core.Queries;
using MediatR;
using static Microsoft.AspNetCore.Http.StatusCodes;

namespace Fp.Hvr.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IMediator mediator, IMapper mapper)
        {
            _logger = logger;
            _mediator = mediator;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(Status200OK)]
        [ProducesResponseType(Status401Unauthorized)]
        [ProducesResponseType(Status404NotFound)]
        [ProducesResponseType(Status500InternalServerError)]
        public async Task<IActionResult> GetAsync(int recordsNumber, CancellationToken cancellationToken)
        {
            GetForecastsQuery query = new (recordsNumber);
            var forecasts = await _mediator.Send(query, cancellationToken);

            _logger.LogInformation($"{forecasts.Count()} forecasts returned.");

            var result = _mapper.Map<IEnumerable<WeatherForecastViewModel>>(forecasts);
            return Ok(result);
        }
    }
}
