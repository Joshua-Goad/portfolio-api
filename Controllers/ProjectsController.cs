using Microsoft.AspNetCore.Mvc;
using Portfolio.Api.Models;
using Portfolio.Api.Services;

namespace Portfolio.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectsController : ControllerBase
    {
        private readonly ILogger<ProjectsController> _logger;
        private readonly IProjectService _service;

        public ProjectsController(ILogger<ProjectsController> logger, IProjectService service)
        {
            _logger = logger;
            _service = service;
        }


        [HttpGet]
        public IActionResult GetProjects()
        {
            _logger.LogInformation("Fetching project list");

            try
            {
                var projects = _service.GetProjects();
                return Ok(projects);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching project list");
                return StatusCode(500, new { error = "An unexpected error occurred." });
            }
        }
    }
}
