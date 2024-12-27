using Basket.API;
using Basket.API.Data;
using Basket.API.Models;
using BuildingBlocks.Behaviors;
using BuildingBlocks.Exceptions.Handler;
using Marten;

var builder = WebApplication.CreateBuilder(args);

// Add services to container
var dbConnectionString = builder.Configuration.GetConnectionString("Database") ?? throw new NullReferenceException("Database connection string not found");
var assembly = typeof(Program).Assembly;
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
    opts.Schema.For<ShoppingCart>().Identity(x => x.UserName);
}).UseLightweightSessions();
// Add custom exception handler to container
builder.Services.AddExceptionHandler<CustomExceptionHandler>();

builder.Services.AddScoped<IBasketRepository, BasketRepository>();

var app = builder.Build();

app.MapCarter();

app.UseExceptionHandler(options => {});

app.Run();
