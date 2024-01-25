using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sanita.Application.Common.Interfaces;
using System.Runtime.CompilerServices;

namespace Sanita.Persistance
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SanitaDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("SanitaDb")));
            services.AddScoped<ISanitaDbContext, SanitaDbContext>();

            return services;
        }
    }
}
