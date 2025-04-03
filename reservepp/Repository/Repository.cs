﻿using System.Collections.Generic;
using System.Linq;


namespace reservepp
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly IDataStorage<T> _storage;
        public Repository(IDataStorage<T> storage)
        {
            _storage = storage;
        }
        public List<T> GetAll()
        {
            return _storage.GetAll();
        }
        public T GetById(int id)
        {
            return _storage.GetById(id);
        }
        public void Add(T entity)
        {
            _storage.Add(entity);
            _storage.Save();
        }
        public void Update(T entity)
        {
            _storage.Update(entity);
            _storage.Save();
        }
        public void Delete(int id)
        {
            
            _storage.Delete(id);
        }
    }
}