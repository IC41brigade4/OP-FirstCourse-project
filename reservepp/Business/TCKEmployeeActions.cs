using System;
using System.Collections.Generic;
using System.Linq;

namespace reservepp
{
    public class TCKEmployeeActions
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;
        private int _counter = 0;

        public TCKEmployeeActions(IOrderService orderService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
        }

        public string AgreeOffer(bool? isPermissionGranted)
        {
            var pendingOrders = _orderService.GetAllOrders()
                                             .Where(o => o.Status == "Не переглянуто")
                                             .ToList();

            if (pendingOrders.Count == 0)
                return "Немає запитів зі статусом 'Не переглянуто'.";

            var order = pendingOrders.First(); // завжди беремо перший з черги

            if (isPermissionGranted == null)
                return "Тобі потрібно обрати надавати дозвіл чи ні!";

            if (isPermissionGranted == true)
            {
                var conscripts = _userService.GetUsersByRole("Conscript")
                                             .Where(u => u.ArmyUnit == "None")
                                             .Take(order.OrderNum)
                                             .ToList();

                if (conscripts.Count == 0)
                {
                    order.Status = "Прийнято, але призовників немає.";
                    _orderService.UpdateOrder(order);
                    return $"⚠️ OrderID {order.OrderID} → Прийнято, але призовників немає.";
                }

                var rnd = new Random();
                foreach (var user in conscripts)
                {
                    string unit = rnd.Next(1, 4).ToString();
                    user.ArmyUnit = unit;
                    _userService.UpdateUser(user);
                }

                order.Status = $"Прийнято ({conscripts.Count}/{order.OrderNum})";
            }
            else
            {
                order.Status = "Відхилено";
            }

            _orderService.UpdateOrder(order);
            return $"OrderID {order.OrderID} — Officer {order.DocID} → {order.Status}";
        }

        public Order? GetCurrentOrder()
        {
            return _orderService.GetAllOrders()
                                .FirstOrDefault(o => o.Status == "Не переглянуто");
        }

        public void ResetCounter()
        {
            _counter = 0;
        }
    }
}
