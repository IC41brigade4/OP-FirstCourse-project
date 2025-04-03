﻿using System.Collections.Generic;
namespace reservepp
{
    public interface IDataStorage<T> where T : class
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(int id);
        T GetById(int id);
        List<T> GetAll();
        void Save();
    }
}
