using _0_FrameWork.Domain;

namespace ShopManagement_Domain.ProductCategoryAgg;

public class ProductCategory : EntityBase
{
    public string Name { get; set; }
    public string Description { get; set; }
    public string Picture { get; set; }
    public string PictureAlt { get; set; }
    public string PictureTitle { get; set; }
    public string Slug { get; set; }
    public string Keywords { get; set; }
    public string MedaDescription { get; set; }

    public ProductCategory(string name, string description, string picture ,string pictureAlt
                           ,string pictureTitle,string slug,string keywords,string medaDescription)
    {
        Name = name;
        Description = description;
        Picture = picture;
        PictureAlt = pictureAlt;
        PictureTitle = pictureTitle;
        Slug = slug;
        Keywords = keywords;
        MedaDescription = medaDescription;
    }

    public void Edit(string name, string description, string picture, string pictureAlt
                           , string pictureTitle, string slug, string keywords, string medaDescription)
    {
        Name = name;
        Description = description;
        Picture = picture;
        PictureAlt = pictureAlt;
        PictureTitle = pictureTitle;
        Slug = slug;
        Keywords = keywords;
        MedaDescription = medaDescription;
    }
}
