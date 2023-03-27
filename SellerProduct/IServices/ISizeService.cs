using SellerProduct.Models;

namespace SellerProduct.IServices;

public interface ISizeService
{
    public bool CreateSize(Size b);
    public bool UpdateSize(Size b);
    public bool DeleteSize(Guid id);
    public List<Size> GetAllSizes();
    public Size GetSizeById(Guid id);
    public List<Size> GetSizeByName(string name);
}
