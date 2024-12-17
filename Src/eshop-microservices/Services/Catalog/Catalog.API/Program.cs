var builder = WebApplication.CreateBuilder(args);

// Add services to container
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});
builder.Services.AddCarter(new DependencyContextAssemblyCatalogCustom());

var app = builder.Build();

// Configure the HTTP request pipeline
app.MapCarter();

app.Run();