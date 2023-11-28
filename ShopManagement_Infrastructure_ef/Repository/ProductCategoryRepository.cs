using _0_FrameWork.Infrastructure;
using Microsoft.EntityFrameworkCore;
using ShopManagement_Domain.ProductCategoryAgg;

namespace ShopManagement_Infrastructure_ef.Repository;

public class ProductCategoryRepository : RepositoryBase<long, ProductCategory>, IProductCategoryRepository
{
    public ProductCategoryRepository(DbContext context) : base(context)
    {
    }


}
