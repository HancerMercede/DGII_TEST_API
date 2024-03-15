using Microsoft.AspNetCore.Mvc;

namespace DGII_TEST_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
        public string? Message;
        private readonly ILogger<HealthCheckController> _logger;

        public HealthCheckController(ILogger<HealthCheckController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "HealthCheck")]

        public ActionResult<string> Check()
        {
            Message = "Ok";
            return Ok(Message);
        }
    }
}