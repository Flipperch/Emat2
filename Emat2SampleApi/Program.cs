using Emat2SampleApi.Endpoints;
using Emat2SampleApi.Startup;

var builder = WebApplication.CreateBuilder(args);

builder.AddDependencies();

var app = builder.Build();

app.UseOpenApi();

app.UseHttpsRedirection();

app.ApplyCorsConfig();

app.MapAllHealthChecks();

app.AddRootEndpoints();
app.AddErrorEndpoints();
app.AddCourseEndpoints();

app.Run();

