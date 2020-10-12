using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Catalog.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CatalogController : ControllerBase
    {

        private readonly ILogger<CatalogController> _logger;

        public CatalogController(ILogger<CatalogController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public string Get()
        {
            return "Api Catalog";
        }
    }
}
