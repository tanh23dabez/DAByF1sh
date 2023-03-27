using SellerProduct.Models;

namespace SellerProduct.IServices;

public interface IMaterialService
{
    public bool CreateMaterial(Material b);
    public bool UpdateMaterial(Material b);
    public bool DeleteMaterial(Guid id);
    public List<Material> GetAllMaterials();
    public Material GetMaterialById(Guid id);
    public List<Material> GetMaterialByName(string name);
}
