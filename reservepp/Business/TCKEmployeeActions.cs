

namespace reservepp
{
    public class TCKEmployeeActions
    {
        private readonly IOrderService _orderService;
        private int _counter = 0;

        public TCKEmployeeActions(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public string AgreeOffer(bool? isPermissionGranted)
        {
            var orders = _orderService.GetAllOrders().ToList();

            if (orders.Count == 0)
            {
                return "Список запитів порожній.";
            }

            if (_counter >= orders.Count)
            {
                return "Більше запитів немає";
            }

            var order = orders[_counter];

            if (isPermissionGranted == true)
            {
                order.Status = "Permission granted";
            }
            else if (isPermissionGranted == false)
            {
                order.Status = "Permission denied";
            }
            else
            {
                return "Тобі потрібно обрати надавати дозвіл чи ні!";
            }

            _orderService.UpdateOrder(order);
            _counter++;

            return $"Officer({order.DocID}) mess:{order.OrderText}, number:{order.OrderNum}";
        }

        public void ResetCounter()
        {
            _counter = 0;
        }
    }
}