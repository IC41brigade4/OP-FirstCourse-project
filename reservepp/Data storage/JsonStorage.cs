using reservepp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

public class JsonStorage<T> : IDataStorage<T> where T : User
{
    private readonly string _filePath;
    private List<T> _items;
    public JsonStorage(string filePath)
    {
        _filePath = filePath;
        _items = LoadFromFile();
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
        _items.Add(entity);
        Save();
    }
    public void Update(T entity)
    {
        var index = _items.FindIndex(e => e.DocID == entity.DocID);
        if (index != -1)
        {
            _items[index] = entity;
        }
        Save();
    }
    public void Delete(int id)
    {
        _items.RemoveAll(e => e.DocID == id);
        Save();
    }
    public T GetById(int id)
    {
        return _items.FirstOrDefault(e => e.DocID == id);
    }
    public List<T> GetAll()
    {
        return _items;
    }
    public void Save()
    {
        var settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.Auto,
            Formatting = Formatting.Indented
        };

        var json = JsonConvert.SerializeObject(_items, settings);
        File.WriteAllText(_filePath, json);
    }
}
