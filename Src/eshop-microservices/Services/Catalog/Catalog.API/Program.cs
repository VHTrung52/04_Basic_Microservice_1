using BuildingBlocks.Behaviors;
using BuildingBlocks.Exceptions.Handler;
using Catalog.API;
using Catalog.API.Data;
using HealthChecks.UI.Client;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

// Add services to container
var assembly = typeof(Program).Assembly;
var dbConnectionString = builder.Configuration.GetConnectionString("Database") ?? throw new NullReferenceException("Database connection string not found");
// Add Carter to container
builder.Services.AddCarter(new DependencyContextAssemblyCatalogCustom());
// Add MediatR to container
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(assembly);
    config.AddOpenBehavior(typeof(ValidationBehavior<,>));
    config.AddOpenBehavior(typeof(LoggingBehavior<,>));
});
// Add Fluent Validation to container
builder.Services.AddValidatorsFromAssembly(assembly);
// Add Marten to container
builder.Services.AddMarten(opts =>
{
    opts.Connection(dbConnectionString);
}).UseLightweightSessions();
// Add Seeding data to container if in development Env 
if (builder.Environment.IsDevelopment()) 
    builder.Services.InitializeMartenWith<CatalogInitialData>();
// Add custom exception handler to container
builder.Services.AddExceptionHandler<CustomExceptionHandler>();
// Add health check to container
builder.Services.AddHealthChecks()
    .AddNpgSql(dbConnectionString);


var app = builder.Build();

// Configure the HTTP request pipeline
app.MapCarter();

app.UseExceptionHandler(options => {});

app.UseHealthChecks("/health",
    new HealthCheckOptions()
    {
        ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
    });

app.Run();


