using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ShopManagement_Application;
using ShopManagement_Application_Contracts.ProductCategoryApplication;
using ShopManagement_Domain.ProductCategoryAgg;
using ShopManagement_Infrastructure_ef;
using ShopManagement_Infrastructure_ef.Repository;

namespace ShopManagement_Infrastructure_Configuration
{
    public static class ShopManagementBootstraper
    {
        public static IServiceCollection ShopManagementConfigure(this IServiceCollection services
            , string connectionString)
        {
            services.AddTransient<IProductCategoryApplication, ProductCategoryApplication>();
            services.AddTransient<IProductCategoryRepository, ProductCategoryRepository>();
            
            services.AddDbContext<ShopManagementDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });
            return services;
        }
    }
}
