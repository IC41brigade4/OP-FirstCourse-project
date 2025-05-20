using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace reservepp
{
    public class OrderRepository
    {
        private readonly AppDbContext _context;
        private readonly DbSet<Order> _dbSet;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<Order>();
        }

        public Order GetById(int orderId)
        {
            return _dbSet.Find(orderId);
        }

        public List<Order> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Add(Order order)
        {
            _dbSet.Add(order);
            _context.SaveChanges();
        }

        public void Update(Order order)
        {
            _dbSet.Update(order);
            _context.SaveChanges();
        }

        public void Delete(int orderId)
        {
            var order = _dbSet.Find(orderId);
            if (order != null)
            {
                _dbSet.Remove(order);
                _context.SaveChanges();
            }
        }
    }
}
