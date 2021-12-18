using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace AsanPardakht.BL.Service.Controllers
{
    [ApiController]
    [Route("api/v{version:apiVersion}/[controller]")]
    public abstract class BaseApiController : ControllerBase
    {
        protected static readonly string[] Summaries = new[]
         {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        protected readonly ILogger<BaseApiController> _logger;


        public BaseApiController(ILogger<BaseApiController> logger)
        {
            _logger = logger;
            
        }

    }
}