using GameHub.Service.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace GameHub.Models
{
    // Implemented by Niklas
    public class Game : IHasId
    {
        public int Id {  get; set; }
        public int UserId { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        [Range(1, int.MaxValue)]
        public int? Timeplayed { get; set; }
        
        public Game() 
        {
        
        }
    }
}
