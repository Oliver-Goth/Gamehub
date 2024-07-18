using GameHub.Service.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameHub.Pages
{
    public class GameInfoModel1 : PageModel
    {
        private IGameRepository _repo;
        private IComparisonRepository _comparisonRepository;
        public Models.Game Game { get; set; }
        public Models.Comparison Comparison { get; set; } = null;
        public GameInfoModel1(IGameRepository repo, IComparisonRepository comparisonRepository)
        {
            _repo = repo;
            _comparisonRepository = comparisonRepository;
        }
        public void OnGet(int id)
        {
            Game = _repo.Read(id);
            try
            {
                Comparison = _comparisonRepository.CompareTimeplayed(Game.Timeplayed);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
