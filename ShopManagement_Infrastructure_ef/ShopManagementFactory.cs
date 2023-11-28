using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ShopManagement_Infrastructure_ef;

public class ShopManagementFactory : IDesignTimeDbContextFactory<ShopManagementDbContext>
{
    public ShopManagementDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<ShopManagementDbContext> options = new();
        options.UseSqlServer("Data Source=.;Initial Catalog = OnlineShop;Integrated Security = true; TrustServerCertificate=True");
        return new ShopManagementDbContext(options.Options);
    }
}
