using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopManagement_Domain.ProductCategoryAgg;

namespace ShopManagement_Infrastructure_ef.Mapping;

public class ProductCategoryMapping : IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Name).IsRequired().HasMaxLength(20);
        builder.Property(x => x.Description).IsRequired().HasMaxLength(500);
        builder.Property(x => x.Keywords).IsRequired();
        builder.Property(x => x.PictureAlt).IsRequired().HasMaxLength(50);
    }
}
