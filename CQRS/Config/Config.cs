using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CQRS.Config
{
    public static class ConfigureServiceCollectionExtensions
    { 
        public static IServiceCollection ConfigureLogic(this IServiceCollection container, IConfiguration config)
        {
            container
                .AddTransient<IMapper, Mapper>();
            return container;
        }
    }
}
