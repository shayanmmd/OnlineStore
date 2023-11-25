using _0_FrameWork.Domain;
using Microsoft.Extensions.DependencyInjection;

namespace _0_FrameWork.Infrastructure;

public static class ServiceConfiguration
{
    public static IServiceCollection ConfigureFrameWork(this IServiceCollection services)
    {
        services.AddScoped(typeof(IRepository<,>),typeof(RepositoryBase<,>));
        return services;
    }
}
