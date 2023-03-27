using SellerProduct.Models;

namespace SellerProduct.IServices;

public interface IColorService
{
    public bool CreateColor(Color b);
    public bool UpdateColor(Color b);
    public bool DeleteColor(Guid id);
    public List<Color> GetAllColors();
    public Color GetColorById(Guid id);
    public List<Color> GetColorByName(string name);
}
