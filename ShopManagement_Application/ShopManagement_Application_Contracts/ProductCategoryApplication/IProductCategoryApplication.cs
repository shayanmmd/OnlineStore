using _0_FrameWork.Application;

namespace ShopManagement_Application_Contracts.ProductCategoryApplication;

public interface IProductCategoryApplication
{
    OperationResult Edit(EditProductCategory item);
    OperationResult Create(CreateProductCategory item);
    List<ProductCategoryViewModel> Search(ProductCategorySearchModel item);
    EditProductCategory GetDetails(long id);
    List<ProductCategoryViewModel> GetProductCategories();
}
