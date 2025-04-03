using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace reservepp
{
    class JsonStorage<T> : IDataStorage<T> where T : class
    {

        public void Add(T entity)
        {
            //var property = entity.GetType().GetProperty("docID");
            //if (property != null && property.PropertyType == typeof(int))
            //{
            //    property.SetValue(entity, _nextId++);
            //}
        }

        public void Delete(int id)
        {
            //var entity = _storage.Find(i => GetId(i) == id);
            //if (entity != null)
            //{
            //    _storage.Remove(entity);
            //    _storage.Save();
            //}
        }

        public List<T> GetAll()
        {
            
        }

        public T GetById(int id)
        {
            
        }

        public void Save()
        {
            
        }

        public void Update(T entity)
        {
            //int id = GetId(entity);
            //var existingEntity = _storage.FirstOrDefault(i => GetId(i) == id);
            //if (existingEntity != null)
            //{
            //    var index = _storage.IndexOf(existingEntity);
            //    _storage[index] = entity;
            //    _storage.Save();
            //}
        }
    }
}
