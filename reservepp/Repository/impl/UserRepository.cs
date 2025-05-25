using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using reservepp;


namespace reservepp
{
    public class UserRepository : IRepository<UserDto>
    {
        private readonly AppDbContext _context;

        public UserRepository(AppDbContext context)
        {
            _context = context;
        }

        public UserDto GetById(int docID)
        {
            return _context.Users.Find(docID);
        }

        public List<UserDto> GetAll()
        {
            return _context.Users.ToList();
        }

        public void Add(UserDto user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void Update(UserDto user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void Delete(int docID)
        {
            var user = _context.Users.Find(docID);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }

        public List<UserDto> GetUsersByRole(string role)
        {
            return _context.Users.Where(u => u.Role == role).ToList();
        }
    }
}