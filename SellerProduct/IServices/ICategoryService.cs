using SellerProduct.Models;

namespace SellerProduct.IServices;

public interface ICategoryService
{
    public bool CreateCategory(Category b);
    public bool UpdateCategory(Category b);
    public bool DeleteCategory(Guid id);
    public List<Category> GetAllCategories();
    public Category GetCategoryById(Guid id);
    public List<Category> GetCategoryByName(string name);
}
