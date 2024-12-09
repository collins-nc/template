namespace template.core;

using Entities;
using interfaces;
using Microsoft.Extensions.DependencyInjection;
using services;

public static class ServiceCollectionExtensions
{
    
    public static IServiceCollection AddCoreServices(this IServiceCollection services)
    {
        services.AddSingleton<IUserService, UserService>();

        return services;
    }
    
}
