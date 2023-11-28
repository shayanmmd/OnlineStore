using _0_FrameWork.Domain;
using _0_FrameWork.Infrastructure;
using Microsoft.Extensions.DependencyInjection;

namespace _0_FrameWork;

public static class ServiceConfiguration
{
    public static IServiceCollection ConfigureFrameWork(this IServiceCollection services)
    {
        services.AddTransient(typeof(IRepository<,>), typeof(RepositoryBase<,>));
        return services;
    }
}
