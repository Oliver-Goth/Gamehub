using GameHub.Models;
using GameHub.Service.Interfaces;

namespace GameHub.Service.Model
{
    // Implemented by Niklas
    public interface IGameRepository : IRepository<Game>
    {
        List<Game> GetGamesByUserId(int userId);
    }
}
