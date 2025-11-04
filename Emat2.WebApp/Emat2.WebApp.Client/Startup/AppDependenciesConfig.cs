using Emat2.WebApp.Client.Services;

namespace Emat2.WebApp.Client.Startup;

public static class AppDependenciesConfig
{
    public static void ConfigureCommonServices(IServiceCollection services)
    {
        // Register application services
        services.AddScoped<IUsuarioService, ClientUsuarioService>();

        services.AddScoped(x => new HttpClient { BaseAddress = new Uri("https://localhost:7244") });
    }
}
