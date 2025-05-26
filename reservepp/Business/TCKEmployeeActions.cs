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
            var orders = _orderService.GetAllOrders().ToList();

            if (orders.Count == 0)
            {
                return "Список запитів порожній.";
            }

            if (_counter >= orders.Count)
            {
                return "Більше запитів немає.";
            }

            var order = orders[_counter];

            if (isPermissionGranted == null)
            {
                return "Тобі потрібно обрати надавати дозвіл чи ні!";
            }

            if (isPermissionGranted == true)
            {
                //var allConscripts = _userService.GetUsersByRole("Conscript").ToList();
                //foreach (var u in allConscripts)
                //{
                //    MessageBox.Show($"User: {u.FirstName}, ArmyUnit: '{u.ArmyUnit}'");
                //}

                var conscripts = _userService.GetUsersByRole("Conscript")
                                             .Where(u => u.ArmyUnit == "None")
                                             .Take(order.OrderNum) // тільки вказана кількість
                                             .ToList();

                if (conscripts.Count == 0)
                {
                    MessageBox.Show("Прийнято, але призовників немає.");
                    _orderService.UpdateOrder(order);
                    _counter++;
                    return "Призовники відсутні.";
                }

                var rnd = new Random();
                foreach (var user in conscripts)
                {
                    string unit = rnd.Next(1, 4).ToString(); // "1", "2", "3"
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
            _counter++;

            return $"OrderID: {order.OrderID}, DocID: {order.DocID}, Статус: {order.Status}";
        }
        public Order? GetCurrentOrder()
        {
            var orders = _orderService.GetAllOrders().ToList();
            if (_counter < orders.Count)
            {
                return orders[_counter];
            }
            return null;
        }


        public void ResetCounter()
        {
            _counter = 0;
        }
    }
}
