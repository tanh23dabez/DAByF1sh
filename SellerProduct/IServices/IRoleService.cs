using SellerProduct.Models;

namespace SellerProduct.IServices;

public interface IRoleService
{
    public bool CreateRole(Role b);
    public bool UpdateRole(Role b);
    public bool DeleteRole(Guid id);
    public List<Role> GetAllRoles();
    public Role GetRoleById(Guid id);
    public List<Role> GetRoleByName(string name);
}
