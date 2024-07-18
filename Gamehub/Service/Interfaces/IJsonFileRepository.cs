namespace GameHub.Service.Interfaces
{
    // Implemented by Niklas
    public interface IJsonFileRepository<T> where T : class
    {
        string JsonFileRelative { get; set; }
        string DataRoot { get; set; }
        void SaveToJsonFile(IEnumerable<T> list);
        IEnumerable<T> GetFromJsonFile();
    }
}
