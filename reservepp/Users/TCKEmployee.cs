using System.Collections.Generic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace reservepp
{
    class TCKEmployee : User, ITCKEmployee
    {
        private readonly UserService userService;
        private List<Order> orders;
        private OrderService orderService;
        private int counter;

        public TCKEmployee(string firstName, string lastName, int age, int docID, string medicalExaminationResult,
                bool HasDeferment, string city, string password, string armyUnit, UserService userService,
                List<Order> orders, OrderService orderService)
            : base(firstName, lastName, age, docID, medicalExaminationResult,
                HasDeferment, city, password, armyUnit, userService, orderService, orders)
        {
            this.userService = userService;
            this.orders = orders;
            this.orderService = orderService;
            this.counter = 0;
        }

        public string AgreeOffer(bool? isPermissionGranted)
        {
            if (orders.Count == 0)
            {
                return "Список запитів порожній.";
            }

            if (counter >= orders.Count)
            {
                return "Більше запитів немає";
            }

            var order = orders[counter];

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

            orderService.UpdateOrder(order);
            counter++;

            return $"Officer({order.DocID}) mess:{order.OrderText}, number:{order.OrderNum}";
        }
    }

        
    
}