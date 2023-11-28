using Microsoft.EntityFrameworkCore;
using ShopManagement_Domain.ProductCategoryAgg;
using ShopManagement_Infrastructure_ef.Mapping;

namespace ShopManagement_Infrastructure_ef;

public class ShopManagementDbContext : DbContext
{
    public DbSet<ProductCategory> ProductCategories { get; set; }

    public ShopManagementDbContext(DbContextOptions<ShopManagementDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var assembly = typeof(ProductCategoryMapping).Assembly;
        modelBuilder.ApplyConfigurationsFromAssembly(assembly);
        base.OnModelCreating(modelBuilder);
    }
    
}
