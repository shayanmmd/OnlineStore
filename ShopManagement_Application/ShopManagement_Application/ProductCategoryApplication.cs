using _0_FrameWork.Application;
using ShopManagement_Application_Contracts.ProductCategoryApplication;
using ShopManagement_Domain.ProductCategoryAgg;

namespace ShopManagement_Application;

public class ProductCategoryApplication : IProductCategoryApplication
{
    private readonly IProductCategoryRepository _productCategoryRepository;

    public ProductCategoryApplication(IProductCategoryRepository productCategoryRepository)
    {
        _productCategoryRepository = productCategoryRepository;
    }

    public OperationResult Create(CreateProductCategory item)
    {
        OperationResult result = new();
        if (_productCategoryRepository.Exits(x => x.Name == item.Name))
            return result.Failed("در پایگاه داده رکوردی با این نام ثبت شده است");
        var productCategory = new ProductCategory(item.Name, item.Description, item.Picture
            , item.PictureAlt, item.PictureTitle, item.Slug, item.Keywords, item.MedaDescription);
        _productCategoryRepository.Create(productCategory);
        _productCategoryRepository.SaveChanges();
        return result;
    }
    public OperationResult Edit(EditProductCategory item)
    {
        throw new NotImplementedException();
    }
    public EditProductCategory GetDetails(long id)
    {
        throw new NotImplementedException();
    }
    public List<ProductCategoryViewModel> GetProductCategories()
    {
        throw new NotImplementedException();
    }
    public List<ProductCategoryViewModel> Search(ProductCategorySearchModel item)
    {
        throw new NotImplementedException();
    }
}
