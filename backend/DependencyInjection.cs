using backend.Interfaces.Repositories;
using backend.Repositories;

namespace backend;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection services)
    {
        // Repositories
        services.AddScoped<IPlayerRepository, PlayerRepository>();

        // Services
        return services;
    }
}