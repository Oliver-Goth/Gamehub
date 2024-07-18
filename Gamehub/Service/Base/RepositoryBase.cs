using GameHub.Service.Interfaces;

namespace GameHub.Service.Base
{
    // Implemented by Niklas
    public class RepositoryBase<T> : IRepository<T> where T : class, IHasId
    {
        protected Dictionary<int, T> _data;
        protected IJsonFileRepository<T> _jsonRepo;
        public int Count { get { return _data.Count; } }
        public RepositoryBase(IJsonFileRepository<T> jsonRepo) 
        {
            _jsonRepo = jsonRepo;
            _data = Load();
        }
        public IEnumerable<T> GetAll()
        {
            return _data.Values.OrderBy(t => t.Id);
        }
        private int NextId()
        {
            return Count > 0 ? GetAll().Select(t => t.Id).Max() + 1 : 1;
        }
        private Dictionary<int, T> Load()
        {
            return _jsonRepo.GetFromJsonFile().ToDictionary(t => t.Id, t => t);
        }
        private void Save() 
        {
            _jsonRepo.SaveToJsonFile(_data.Values);
        }
        public void Create(T t)
        {
            t.Id= NextId();
            _data[t.Id] = t;

            Save();
        }
        public T? Read(int id)
        {
            return _data.ContainsKey(id) ? _data[id] : null;
        }
        public void Update(T t) 
        {
            if(t != null && _data.ContainsKey(t.Id))
            {
                _data[t.Id] = t;
                Save();
            }

        }
        public void Delete(int id) 
        {
            _data.Remove(id);
        }
    }
}
