using GameHub.Models;
using GameHub.Service.Base;

namespace GameHub.Service.Model
{
    // Implemented by Niklas
    public class GameRepository : RepositoryBase<Game>, IGameRepository
    {
        public GameRepository(IWebHostEnvironment WebHostEnvironment)
            :base(new JsonFileRepositoryBase<Game>(WebHostEnvironment,"Games.json"))
        {
        }

        public List<Game> GetGamesByUserId(int userId)
        {
            return GetAll().Where(g => g.UserId == userId).ToList();
        }
    }
}
