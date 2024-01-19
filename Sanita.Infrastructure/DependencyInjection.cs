using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Sanita.Application.Common.Exceptions;
using Sanita.Application.Common.Interfaces;
using Sanita.Infrastructure.FileStore;
using Sanita.Infrastructure.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistance(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddTransient<IDateTime, DateTimeService>();
            services.AddTransient<IFileStore, FileStore.FileStore>();
            services.AddTransient<IFileWrapper, IFileWrapper>();
            services.AddTransient<IDirectoryWrapper, DirectoryWrapper>();

            return services;
        }
    }
}
