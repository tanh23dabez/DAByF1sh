using SellerProduct.Models;

namespace SellerProduct.IServices;

public interface IUserService
{
    public bool CreateUser(User b);
    public bool UpdateUser(User b);
    public bool DeleteUser(Guid id);
    public List<User> GetAllUsers();
    public User GetUserById(Guid id);
    public List<User> GetUserByName(string name);
}
