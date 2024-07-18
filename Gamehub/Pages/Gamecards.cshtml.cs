using GameHub.Models;
using GameHub.Service.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameHub.Pages
{
    public class GameCardsModel : PageModel
    {
        private IGameRepository _repo;

        public List<Game> Games { get; set; }


        public GameCardsModel(IGameRepository repo)
        {
            _repo = repo;
        }
        public void OnGet()
        {
            Games = _repo.GetGamesByUserId(1);
        }
    }
}
