using Domain.Adapters;
using Infra.Database.InMemory.Context;
using Infra.Database.InMemory.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Infra.Database.InMemory
{
    public static class DataBaseInMemoryModuleDependency
    {
        public static IServiceCollection AddDataBaseModule(this IServiceCollection services)
        {
            services.AddDbContext<InMemoryContext>(options => options.UseInMemoryDatabase("Database"));

            services.AddScoped<IClubRepository, ClubRepository>();

            return services;
        }
    }
}
