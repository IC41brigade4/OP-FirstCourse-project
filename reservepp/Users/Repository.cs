using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

public class Repository<T> : IRepository<T> where T : class
{
    private readonly AppDbContext _context;
    private readonly DbSet<T> _dbSet;

    public Repository(AppDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public T GetById(int id)
    {
        var entity = _dbSet.Find(id);
        if (entity == null)
        {
            throw new KeyNotFoundException($"Entity with ID {id} not found.");
        }
        return entity;
    }

    public IEnumerable<T> GetAll()
    {
        return _dbSet.ToList();
    }

    public void Add(T entity)
    {
        try
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            // Логирование ошибки
            throw new ApplicationException("An error occurred while adding the entity.", ex);
        }
    }

    public void Update(T entity)
    {
        try
        {
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
        }
        catch (Exception ex)
        {
            // Логирование ошибки
            throw new ApplicationException("An error occurred while updating the entity.", ex);
        }
    }

    public void Delete(int id)
    {
        var entity = GetById(id);
        if (entity == null)
        {
            throw new KeyNotFoundException($"Entity with ID {id} not found.");
        }

        _dbSet.Remove(entity);
        _context.SaveChanges();
    }

    public IEnumerable<T> GetSortedByField<TKey>(Expression<Func<T, TKey>> keySelector)
    {
        return _dbSet.OrderBy(keySelector).ToList();
    }

    public IEnumerable<T> GetFiltered(Expression<Func<T, bool>> filter)
    {
        return _dbSet.Where(filter).ToList();
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}
