using System.Collections.Generic;
using System.Linq;


namespace reservepp
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly List<T> _items = new List<T>();
        private int _nextId = 1;

        public IEnumerable<T> GetAll()
        {
            return _items;
        }

        public T GetById(int id)
        {
            return _items.FirstOrDefault(i => GetId(i) == id);
        }

        public void Add(T entity)
        {
            var property = entity.GetType().GetProperty("docID");
            if (property != null && property.PropertyType == typeof(int))
            {
                property.SetValue(entity, _nextId++);
            }

            _items.Add(entity);
        }

        public void Update(T entity)
        {
            int id = GetId(entity);
            var existingEntity = _items.FirstOrDefault(i => GetId(i) == id);
            if (existingEntity != null)
            {
                var index = _items.IndexOf(existingEntity);
                _items[index] = entity;
            }
        }

        public void Delete(int id)
        {
            var entity = _items.Find(i => GetId(i) == id);
            if (entity != null)
            {
                _items.Remove(entity);
            }
        }

        private int GetId(T entity)
        {
            var property = entity.GetType().GetProperty("DocID");
            return property != null ? (int)property.GetValue(entity) : -1;
        }


    }
}