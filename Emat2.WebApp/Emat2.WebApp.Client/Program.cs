using Emat2.WebApp.Client.Startup;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

AppDependenciesConfig.ConfigureCommonServices(builder.Services);

await builder.Build().RunAsync();
