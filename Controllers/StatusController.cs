using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StatusController : ControllerBase
    {
        private readonly ILogger<StatusController> _logger;

        public StatusController(ILogger<StatusController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Health check endpoint for uptime monitoring.
        /// </summary>
        [HttpGet]
        public IActionResult GetStatus()
        {
            _logger.LogInformation("Status check requested");

            return Ok(new
            {
                status = "ok",
                timestamp = DateTime.UtcNow,
                environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") ?? "Unknown"
            });
        }
    }
}