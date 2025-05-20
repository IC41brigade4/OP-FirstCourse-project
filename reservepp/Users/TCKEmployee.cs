using System.Collections.Generic;
using System.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace reservepp
{
    class TCKEmployee : UserEntity, ITCKEmployee
    {
        private readonly UserService userService;
        private OrderService orderService;
        private int counter;

        public TCKEmployee(string firstName, string lastName, int age, int docID, string medicalExaminationResult,
                bool HasDeferment, string city, string password, string armyUnit, UserService userService,
                OrderService orderService)
            : base(firstName, lastName, age, docID, medicalExaminationResult,
                HasDeferment, city, password, armyUnit, userService, orderService)
        {
            this.userService = userService;
            this.orderService = orderService;
            this.counter = 0;
        }

        public string AgreeOffer(bool? isPermissionGranted)
        {
            if (OrderService == null)
            {
                return "Помилка: OrderService не ініціалізовано!";
            }
            if (orderService.GetAllOrders().Count() == 0)
            {
                return "Список запитів порожній.";
            }

            if (counter >= orderService.GetAllOrders().Count())
            {
                return "Більше запитів немає";
            }

            var order = orderService.GetAllOrders().ToList()[counter];

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