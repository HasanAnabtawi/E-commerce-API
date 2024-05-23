using StoreAPI.Models;

namespace StoreAPI.Services

{
    public interface IUserService
    {

        string Login(UserModel user);
    }
}
