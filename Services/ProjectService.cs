using Portfolio.Api.Models;

namespace Portfolio.Api.Services
{
    public class ProjectService : IProjectService
    {
        public List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project
                {
                    Title = "Portfolio Website",
                    Description = "A full-stack portfolio built with React and ASP.NET Core.",
                    Url = "https://joshuagoad.com",
                    Technologies = new[] { "React", "C#", ".NET", "Azure" }
                },
                new Project
                {
                    Title = "API Backend",
                    Description = "A cloud-hosted API powering the portfolio site.",
                    Url = "https://portfolio-api-production-bc5d.up.railway.app/swagger/index.html",
                    Technologies = new[] { "C#", ".NET", "Swagger", "Railway App Service" }
                },
                new Project
                {
                    Title = "Task Tracker App",
                    Description = "A responsive React application for managing daily tasks with features including adding, editing, completing, and deleting tasks.",
                    Url = "/tasktracker",
                    Technologies = new[] { "React", "JavaScript", "CSS" }
                }
            };
        }
    }
}
