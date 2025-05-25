
namespace reservepp
{
    public interface IOrderService
    {
        IEnumerable<Order> GetAllOrders();
        Order GetById(int id);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(int id);
        List<Order> GetOrdersByDocId(int docId);
        List<Order> GetOrdersByStatus(string status);
    }
}
