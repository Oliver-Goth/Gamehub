using GameHub.Models;
using GameHub.Service.Interfaces;

namespace GameHub.Service.Model
{
    // Implemented by Niklas
    public interface IUserRepository : IRepository<User>
    {
        User Login(string email, string password);
    }
}
