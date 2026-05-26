# 📘 Portfolio API

A lightweight, modular REST API powering my personal website (joshuagoad.com).Built with ASP.NET Core (.NET 8), this API serves project data, portfolio information, and backend logic for future expansions.Designed with clean architecture principles, environment‑based configuration, and forward‑compatible routing.

🚀 Features

RESTful JSON endpoints

Modular controller-based architecture

Environment-based configuration (appsettings.json)

Strongly-typed configuration + dependency injection

Scalable folder layout for future services

Ready for CI/CD integration (Jenkins, GitHub Actions, Azure DevOps)

Designed for forward-compatible expansion

🛠 Tech Stack

.NET 8 Web API

C#

ASP.NET Core

JSON Serialization

Dependency Injection

Environment Configuration

Azure/AWS Hosting (planned)

📡 API Endpoints

Endpoint

Method

Description

/projects

GET

Returns list of portfolio projects

/status

GET

Health check endpoint

/about

GET

Returns profile information


🧱 Project Structure

/Controllers
  ProjectsController.cs
  WeatherForecastController.cs
/Properties
appsettings.json
appsettings.Development.json
Program.cs
Portfolio.Api.csproj
Portfolio.Api.http

💡 Tech Highlights

Modern .NET 8 Web API

Clean, modular controller structure

JSON-based responses for all endpoints

Environment-based configuration for dev/prod

Dependency injection for scalable architecture

Ready for CI/CD pipeline integration

Forward-compatible design for additional services and endpoints

📦 Installation

git clone https://github.com/Joshua-Goad/portfolio-api
cd portfolio-api
dotnet restore

▶ Running the API

dotnet run

The API will start on the port defined in your .env or appsettings.json.

🔐 Environment Variables

Create a .env file (if using environment overrides):

PORT=5000
ASPNETCORE_ENVIRONMENT=Development

Or configure directly in appsettings.json.

🧪 Testing the API

You can test endpoints using:

Portfolio.Api.http (built-in HTTP file)

Postman

curl

Example:

curl https://localhost:5000/projects

📈 Future Enhancements

Add authentication (JWT or OAuth)

Add database integration (PostgreSQL or MongoDB)

Add logging and monitoring (Serilog, Seq, CloudWatch)

Add automated tests (xUnit, NUnit)

Add Jenkins CI/CD pipeline

Add caching layer for performance

📜 License

MIT License
