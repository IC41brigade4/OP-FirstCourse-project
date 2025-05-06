using reservepp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

namespace reservepp
{
    public class JsonOrderStorage<T> : IDataStorage<T> where T : Order
    {
        private readonly string _filePath;
        private List<T> _orders;
        public JsonOrderStorage(string filePath)
        {
            _filePath = filePath;
            _orders = LoadFromFile();
        }
        private List<T> LoadFromFile()
        {
            if (!File.Exists(_filePath))
                return new List<T>();

            var json = File.ReadAllText(_filePath);
            if (string.IsNullOrWhiteSpace(json))
                return new List<T>();

            try
            {
                var settings = new JsonSerializerSettings
                {
                    TypeNameHandling = TypeNameHandling.Auto
                };

                var list = JsonConvert.DeserializeObject<List<T>>(json, settings);
                return list ?? new List<T>();
            }
            catch (Newtonsoft.Json.JsonException)
            {
                return new List<T>();
            }
        }
        public void Add(T entity)
        {
            _orders.Add(entity);
            Save();
        }
        public void Update(T entity)
        {
            var index = _orders.FindIndex(e => e.DocID == entity.DocID);
            if (index != -1)
            {
                _orders[index] = entity;
            }
            Save();
        }
        public void Delete(int id)
        {
            _orders.RemoveAll(e => e.DocID == id);
            Save();
        }
        public T GetById(int id)
        {
            return _orders.FirstOrDefault(e => e.DocID == id);
        }
        public List<T> GetAll()
        {
            return _orders;
        }
        public void Save()
        {
            var settings = new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto,
                Formatting = Formatting.Indented
            };

            var json = JsonConvert.SerializeObject(_orders, settings);
            File.WriteAllText(_filePath, json);
        }
    }
}
