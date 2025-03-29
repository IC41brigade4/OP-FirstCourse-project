using System.Collections.Generic;
namespace reservepp
{
	public class UserService
	{
		private readonly IRepository<User> _repository;

        public UserService(IRepository<User> repository)
		{
			_repository = repository;
		}

        public IEnumerable<User> GetAllUsers()
		{
			return _repository.GetAll();
		}

		public void AddUser(User user)
		{
			_repository.Add(user);
		}

		public void UpdateUser(User user)
		{
			_repository.Update(user);
		}

		public void DeleteUser(int id)
		{
			
			_repository.Delete(id);
		}
	}
}