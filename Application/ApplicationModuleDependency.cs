using Application.Services;
using Domain.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Application
{
    public static class ApplicationModuleDependency
    {
        public static IServiceCollection AddApplicationModule(this IServiceCollection services)
        {
            services.AddScoped<IClubService, ClubServiceManager>();

            return services;
        }
    }
}
