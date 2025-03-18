using System.Collections.Generic;

namespace reservepp
{

	public class UserService
	{
		private readonly IRepository<Product> _repository;

		public UserService(IRepository<Product> repository)
		{
			_repository = repository;
		}

		public IEnumerable<Product> GetAllProducts()
		{
			return _repository.GetAll();
		}

		public void AddProduct(Product product)
		{
			_repository.Add(product);
		}

		public void UpdateProduct(Product product)
		{
			_repository.Update(product);
		}

		public void DeleteProduct(int id)
		{
			_repository.Delete(id);
		}
	}
}