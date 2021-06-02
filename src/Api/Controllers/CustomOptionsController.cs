using Api.Options;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomOptionsController : ControllerBase
    {
        private readonly CustomOptions _customOptions;
        public CustomOptionsController(CustomOptions customOptions)
        {
            _customOptions = customOptions;
        }
        
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_customOptions);
        }
    }
}