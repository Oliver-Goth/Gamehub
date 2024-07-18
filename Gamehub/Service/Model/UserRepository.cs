using GameHub.Models;
using GameHub.Service.Base;

namespace GameHub.Service.Model
{
    // Implemented by Niklas
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(IWebHostEnvironment WebHostEnvironment)
            : base(new JsonFileRepositoryBase<User>(WebHostEnvironment, "Users.json"))
        { 
        }

        public User? Login(string email, string password)
        {
            List<User> users = GetAll().ToList();
            User loginUser = users.Where(u => u.Email == email && u.Password == password).FirstOrDefault();
            if(loginUser != null) 
            {
                return loginUser;
            }
            else
            {
                return null;
            }
        }
    }
}
