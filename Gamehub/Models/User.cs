using GameHub.Service.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace GameHub.Models
{
    // Implemented by Niklas
    public class User : IHasId
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }

        public User() { }
    }
}
