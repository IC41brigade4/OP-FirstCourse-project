using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

public interface IRepository<T> where T: class
{
	Task<T> GetByIdAsync(int id);
	Task<IEnumerable<T>> GetAllAsync();
	Task AddAsync(T entity);
	Task UpdateAsync(T entity);
	Task DeleteAsync(int id);
	Task<IEnumerable<T>> GetSortedByName();
}