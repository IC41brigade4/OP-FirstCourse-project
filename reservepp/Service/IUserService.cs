

namespace reservepp
{
    public interface IUserService
    {
        IEnumerable<UserDto> GetAllUsers();
        UserDto GetById(int id);
        void AddUser(UserDto user);
        void UpdateUser(UserDto user);
        void DeleteUser(int id);
        List<UserDto> GetUsersByRole(string role);
        bool AuthenticateUser(int docId, string password);
    }
}