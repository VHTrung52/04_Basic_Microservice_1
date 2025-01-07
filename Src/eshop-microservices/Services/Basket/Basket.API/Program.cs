using Basket.API;
using Basket.API.Data;
using Basket.API.Models;
using BuildingBlocks.Behaviors;
using BuildingBlocks.Exceptions.Handler;
using Discount.Grpc;
using HealthChecks.UI.Client;
using Marten;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;

var builder = WebApplication.CreateBuilder(args);

// Add services to container
var dbConnectionString = builder.Configuration.GetConnectionString("Database") ??
                         throw new NullReferenceException("Database connection string not found");
var cacheConnectionString = builder.Configuration.GetConnectionString("Redis") ??
                            throw new NullReferenceException("Redis connection string not found");
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
// Add Redis cache service
builder.Services.AddStackExchangeRedisCache(options => { options.Configuration = cacheConnectionString; });
// Add custom exception handler to container
builder.Services.AddExceptionHandler<CustomExceptionHandler>();
// Register dependency injection
builder.Services.AddScoped<IBasketRepository, BasketRepository>();
// Using Scrutor library to register decorator
builder.Services.Decorate<IBasketRepository, CachedBasketRepository>();
// Add health check
builder.Services.AddHealthChecks()
    .AddNpgSql(dbConnectionString)
    .AddRedis(cacheConnectionString);
// Add gRPC service
builder.Services.AddGrpcClient<DiscountProtoService.DiscountProtoServiceClient>(options =>
    {
        options.Address = new Uri(builder.Configuration["GrpcSettings:DiscountUrl"]!);
    })
    .ConfigurePrimaryHttpMessageHandler(() =>
    {
        var handler = new HttpClientHandler
        {
            ServerCertificateCustomValidationCallback =
                HttpClientHandler.DangerousAcceptAnyServerCertificateValidator
        };

        return handler;
    });

var app = builder.Build();

app.MapCarter();

app.UseExceptionHandler(options => { });

app.UseHealthChecks("/health",
    new HealthCheckOptions()
    {
        ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
    });

app.Run();