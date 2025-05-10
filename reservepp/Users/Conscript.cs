using System.Collections.Generic;

namespace reservepp
{
    class Conscript : User, ConscriptInterface
    {
        
        public Conscript(string firstName, string lastName, int age, int docID, string medicalExaminationResult,
                bool HasDeferment, string city, string password, string armyUnit, UserService userService, List<Order> orders, OrderService orderService)
            : base(firstName, lastName, age, docID, medicalExaminationResult,
                HasDeferment, city, password, armyUnit, userService, orderService, orders) 
        { 
        }

        public void getMobilizated(bool mobilizated, int OfficerDocID)
        {
            if (!mobilizated)
            {
                ArmyUnit = UserService.GetById(OfficerDocID).ArmyUnit;
                mobilizated = true;
            }
        }

        public void leaveArmy(bool mobilizated)
        {
            if (mobilizated)
            {
                ArmyUnit = "None";
                mobilizated = true;
            }
        }
    }
}