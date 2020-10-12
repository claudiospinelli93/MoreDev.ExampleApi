using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Bakery.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BakeryController : ControllerBase
    {

        private readonly ILogger<BakeryController> _logger;

        public BakeryController(ILogger<BakeryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Api Bakery";
        }
    }
}