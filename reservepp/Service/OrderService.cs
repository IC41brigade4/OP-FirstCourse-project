using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservepp
{
    public class OrderService
    {
        private readonly IUserRepository<Order> _repository;

        public OrderService(IUserRepository<Order> repository)
        {
            _repository = repository;
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _repository.GetAll();
        }

        public void AddOrder(Order order)
        {
            _repository.Add(order);

        }

        public void UpdateOrder(Order order)
        {
            _repository.Update(order);

        }

        public void DeleteOrder(int id)
        {

            _repository.Delete(id);

        }
    }
}
