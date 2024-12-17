var builder = WebApplication.CreateBuilder(args);

// Add services to container
// var assembly = typeof(Program).Assembly;
//
// var catalog = new DependencyContextAssemblyCatalog();
// var types = catalog.GetAssemblies().SelectMany(x => x.GetTypes());
// var modules = types
//     .Where(t =>
//         !t.IsAbstract &&
//         typeof(ICarterModule).IsAssignableFrom(t)
//         && (t.IsPublic || t.IsNestedPublic)
//     ).ToList();
//
// builder.Services.AddCarter(configurator: c =>
// {
//     c.WithModules(modules.ToArray());
// });
builder.Services.AddMediatR(config =>
{
    config.RegisterServicesFromAssembly(typeof(Program).Assembly);
});
builder.Services.AddCarter(configurator: c => 
{
    c.OpenApi.TagSelector = (apiDesc) => apiDesc.ActionDescriptor.EndpointMetadata.OfType<TagsAttribute>().FirstOrDefault()?.Tags;
}, assemblies: new[] { typeof(Program).Assembly });



// var appPartsAssemblies = typeof(Program).Assembly;
// builder.Services.AddMediatR(configuration => configuration.RegisterServicesFromAssemblies(appPartsAssemblies));
// builder.Services.AddCarter(new DependencyContextAssemblyCatalog(appPartsAssemblies));


var app = builder.Build();

// Configure the HTTP request pipeline
app.MapCarter();

app.Run();
