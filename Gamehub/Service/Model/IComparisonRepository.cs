using GameHub.Models;
using GameHub.Service.Interfaces;

namespace GameHub.Service.Model
{
    // Implemented by Niklas
    public interface IComparisonRepository : IRepository<Comparison>
    {
        Comparison CompareTimeplayed(int? timeplayed);
    }
}
