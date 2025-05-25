

namespace reservepp
{
    public class OrderService : IOrderService
    {
        private readonly OrderRepository _orderRepository;

        public OrderService(OrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _orderRepository.GetAll();
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public void AddOrder(Order order)
        {
            _orderRepository.Add(order);
        }

        public void UpdateOrder(Order order)
        {
            _orderRepository.Update(order);
        }

        public void DeleteOrder(int id)
        {
            _orderRepository.Delete(id);
        }

        public List<Order> GetOrdersByDocId(int docId)
        {
            return _orderRepository.GetOrdersByDocId(docId);
        }

        public List<Order> GetOrdersByStatus(string status)
        {
            return _orderRepository.GetOrdersByStatus(status);
        }
    }
}