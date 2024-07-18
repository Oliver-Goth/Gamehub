using GameHub.Models;
using GameHub.Service.Base;

namespace GameHub.Service.Model
{
    // Implemented by Niklas
    public class ComparisonRepository : RepositoryBase<Comparison>, IComparisonRepository
    {
        public ComparisonRepository(IWebHostEnvironment WebHostEnvironment)
            : base(new JsonFileRepositoryBase<Comparison>(WebHostEnvironment,"Comparisons.json")) { }

        public Comparison CompareTimeplayed(int? timeplayed)
        {
            return GetAll().Where(c => c.Timeplayed >= timeplayed).OrderBy(c => c.Timeplayed).FirstOrDefault();
        }
    }
}
