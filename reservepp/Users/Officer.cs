using System.Collections.Generic;
using System.Windows.Forms;
namespace reservepp
{
    public class Officer : User, IOfficer
    {
        
        public Officer(string firstName, string lastName, int age, int docID, string medicalExaminationResult,
                bool HasDeferment, string city, string password, string armyUnit, UserService userService, List<Order> orders, OrderService orderService)
            : base(firstName, lastName, age, docID, medicalExaminationResult,
                HasDeferment, city, password, armyUnit, userService, orderService, orders)
        {
            
        }

        public void makeOffer(string orderText, string peoplenum_text, int DocId)
        {
            if (!int.TryParse(peoplenum_text, out int orderNum))
            {
                MessageBox.Show("Кількість людей має бути числом!");
                return;
            }

            Order order = new Order(DocId, orderNum, orderText, "Не переглянуто");
            OrderService.AddOrder(order);
        }
        
    }
}
