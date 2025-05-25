
using System.Collections.Generic;
using System.Linq;


namespace reservepp
{
    public class UserService : IUserService
    {
        private readonly UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public IEnumerable<UserDto> GetAllUsers()
        {
            return _userRepository.GetAll();
        }

        public UserDto GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public void AddUser(UserDto user)
        {
            // Хешування пароля перед збереженням
            if (!string.IsNullOrEmpty(user.HashedPassword))
            {
                user.HashedPassword = BCrypt.Net.BCrypt.HashPassword(user.HashedPassword);
            }
            _userRepository.Add(user);
        }

        public void UpdateUser(UserDto user)
        {
            _userRepository.Update(user);
        }

        public void DeleteUser(int id)
        {
            _userRepository.Delete(id);
        }

        public List<UserDto> GetUsersByRole(string role)
        {
            return _userRepository.GetUsersByRole(role);
        }

        public bool AuthenticateUser(int docId, string password)
        {
            var user = _userRepository.GetById(docId);
            if (user == null) return false;

            return BCrypt.Net.BCrypt.Verify(password, user.HashedPassword);
        }
    }
}