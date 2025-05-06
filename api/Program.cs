// Creates a builder object to configure the application services and settings
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
// Adds services required for API endpoint exploration, which is needed for Swagger to discover your API endpoints
builder.Services.AddEndpointsApiExplorer();
// Adds Swagger generator services to the application, enabling API documentation and testing
builder.Services.AddSwaggerGen();

// Builds the WebApplication instance with all configured services and settings
var app = builder.Build();

// Configure the HTTP request pipeline.
// Checks if the application is running in development environment
if (app.Environment.IsDevelopment())
{
    // Enables Swagger middleware to generate JSON document describing your API
    app.UseSwagger();
    // Enables Swagger UI middleware to provide web interface for exploring your API
    app.UseSwaggerUI();
}

// Adds middleware that redirects HTTP requests to HTTPS for improved security
app.UseHttpsRedirection();

// Starts the web application and begins listening for HTTP requests
app.Run();