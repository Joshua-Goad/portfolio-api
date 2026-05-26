using Portfolio.Api.Services;

var builder = WebApplication.CreateBuilder(args);

// Add Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
        policy.WithOrigins("https://joshuagoad.com")
              .AllowAnyHeader()
              .AllowAnyMethod());
});

// Add controllers + XML support
builder.Services.AddControllers()
    .AddXmlSerializerFormatters();

// Register services (Dependency Injection)
builder.Services.AddScoped<IProjectService, ProjectService>();

var app = builder.Build();

// Enable Swagger in Development
app.UseSwagger();
app.UseSwaggerUI();

// Enable CORS
app.UseCors("AllowFrontend");

app.MapControllers();

// REQUIRED FOR RAILWAY:
var port = Environment.GetEnvironmentVariable("PORT") ?? "8080";
app.Urls.Add($"http://0.0.0.0:{port}");

app.Run();