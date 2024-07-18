using GameHub.Service.Interfaces;

namespace GameHub.Models
{
    // Implemented by Niklas
    public class Comparison : IHasId
    {
        public int Id { get; set; }
        public int Timeplayed { get; set; }
        public string Description { get; set; }
        public string Punchline { get; set; }
        
        public Comparison() { }
    }
}
