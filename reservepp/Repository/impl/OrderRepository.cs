


namespace reservepp
{
    public class OrderRepository : IRepository<Order>
    {
        private readonly AppDbContext _context;

        public OrderRepository(AppDbContext context)
        {
            _context = context;
        }

        public Order GetById(int orderId)
        {
            return _context.Orders.Find(orderId);
        }

        public List<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public void Add(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void Update(Order order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void Delete(int orderId)
        {
            var order = _context.Orders.Find(orderId);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }

        public List<Order> GetOrdersByDocId(int docId)
        {
            return _context.Orders.Where(o => o.DocID == docId).ToList();
        }

        public List<Order> GetOrdersByStatus(string status)
        {
            return _context.Orders.Where(o => o.Status == status).ToList();
        }
    }
}
