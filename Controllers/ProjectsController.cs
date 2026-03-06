using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetProjects()
        {
            var projects = new[]
            {
                new {
                    Title = "Portfolio Website",
                    Description = "A full-stack portfolio built with React and ASP.NET Core.",
                    Url = "https://joshuagoad.com",
                    Technologies = new[] { "React", "C#", ".NET", "Azure" }
                },
                new {
                    Title = "API Backend",
                    Description = "A cloud-hosted API powering the portfolio site.",
                    Url = "https://joshuagoad-api.azurewebsites.net",
                    Technologies = new[] { "C#", ".NET", "Swagger", "Azure App Service" }
                },
                new {
                    Title = "Task Tracker App",
                    Description = "A responsive React application for managing daily tasks with features including adding, editing, completing, and deleting tasks. Built with a clean neon-accented UI and localStorage persistence to save tasks between sessions.",
                    Url = "/tasktracker",
                    Technologies = new[] { "React", "JavaScript", "CSS" }
                }
            };

            return Ok(projects);
        }
    }
}
