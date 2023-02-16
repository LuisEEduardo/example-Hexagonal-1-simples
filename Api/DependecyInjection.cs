using Application;
using Infra.Database.InMemory;

namespace Api;

public static class DependecyInjection
{
    public static IServiceCollection ResolveAllServices(this IServiceCollection services)
    {
        services.AddApplicationModule();
        services.AddDataBaseModule();

        return services;
    }
}
