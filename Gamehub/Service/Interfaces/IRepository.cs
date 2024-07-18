namespace GameHub.Service.Interfaces
{
    // Implemented by Niklas
    public interface IRepository<T> where T : class, IHasId
    {
        int Count { get; }
        void Create(T t);
        T? Read(int id);
        void Update(T t);
        void Delete(int id);
        IEnumerable<T> GetAll();
    }
}
