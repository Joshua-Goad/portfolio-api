# portfolio-api
This is the backend API for my personal portfolio website. It provides structured project data and supports integration with my React frontend. The API is built with ASP.NET Core and deployed on Railway.

Features
- RESTful endpoints for portfolio project data
- CORS configured for frontend integration
- XML and JSON response support
- Lightweight, fast, and easy to extend
- Designed for deployment on Railway or Azure App Service

Tech Stack
- C# / ASP.NET Core
- .NET 8 (or your version)
- Railway for hosting
- Swagger for API documentation

Endpoints
GET /projects
Returns a list of portfolio projects including title, description, technologies, and URLs.

Local Development
Requirements
- .NET SDK installed
- Visual Studio or VS Code
Run locally
dotnet run


The API will start on:
http://localhost:5000



Deployment
This API is deployed using Railway.
Railway requires the app to bind to the assigned port:
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
app.Urls.Add($"http://0.0.0.0:{port}");



Future Enhancements
- Add authentication for admin-only endpoints
- Add database support for dynamic project management
- Add additional endpoints for skills, contact, and resume data

License
This project is open-source and available under the MIT License.
