﻿using Engines.Application.Common.Interfaces.Repositories;
using Engines.Application.Common.Interfaces.Services;
using Engines.Infrastructure.Persistence.Repositories;
using Engines.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Engines.Infrastructure
{
    public static class DependencyInjection
    {
         public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IDiselRepository, DiselRepository>();
            services.AddScoped<IDiselService, DiselService>();
        
            return services;

        }

    }
}
