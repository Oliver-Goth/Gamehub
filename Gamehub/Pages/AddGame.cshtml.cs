using GameHub.Service.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameHub.Pages
{
    public class AddGameModel : PageModel
    {
        private IGameRepository _repo;
            
        public AddGameModel(IGameRepository repo)
        {
            _repo = repo;
        }

        [BindProperty]
        public Models.Game Game { get; set; }



        public IActionResult OnGet()
        {
            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            Game.UserId = 1;

            _repo.Create(Game);
            return RedirectToPage("Gamecards");
        }
    }
}
