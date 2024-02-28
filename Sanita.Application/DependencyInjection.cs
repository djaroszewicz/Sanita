using FluentValidation;
using MediatR;
using MediatR.Pipeline;
using MediatR.Registration;
using Microsoft.Extensions.DependencyInjection;
using Sanita.Application.Common.Behaviours;
using Sanita.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sanita.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());

            services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>));
            services.AddTransient(typeof(IRequestPreProcessor<>), typeof(LoggingBehaviour<>));
            return services;
        }
    }
}
