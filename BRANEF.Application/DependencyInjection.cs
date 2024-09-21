﻿using BRANEF.Domain.Interfaces.IRepository;
using BRANEF.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace BRANEF.Application.DependencyInjection
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddMediatR(config => config.RegisterServicesFromAssembly(typeof(DependencyInjection).Assembly));

            return services;
        }
    }
}
