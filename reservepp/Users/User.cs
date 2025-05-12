using BCrypt.Net;
using System.Collections.Generic;
namespace reservepp
{
    public abstract class User
    {
        private int age, docID;
        private string firstName, lastName, medicalExaminationResult, city;
        private bool hasDeferment;
        private string hashedPassword = "";
        private string armyUnit;
        private UserService userService;
        private OrderService orderService;
        
        public User(string firstName, string lastName, int age, int docID, string medicalExaminationResult, 
            bool hasDeferment, string city, string password, string armyUnit, UserService userService, OrderService orderService )
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.docID = docID;
            this.medicalExaminationResult = medicalExaminationResult;
            this.hasDeferment = hasDeferment;
            this.city = city;
            this.armyUnit = armyUnit;
            this.userService = userService;
            if (password != null)
                this.hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);
            this.orderService = orderService;
           
        }

        public int Age { get => age; set => age = value; }
        public int DocID { get => docID; set => docID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string MedicalExaminationResult { get => medicalExaminationResult; set => medicalExaminationResult = value; }
        public bool HasDeferment { get => hasDeferment; set => hasDeferment = value; }
        public string City { get => city; set => city = value; }
        public string ArmyUnit { get => armyUnit; set => armyUnit = value; }
        public string HashedPassword { get => hashedPassword; set => hashedPassword = value; }
        public UserService UserService { get => userService; set => userService = value; }
        public OrderService OrderService { get => orderService; set => orderService = value; }
        public string Name => $"{firstName} {lastName}";
        public void SetData(string firstName, string lastName, int age, int docID, string medicalExaminationResult,
            bool hasDeferment, string city, string armyUnit)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.docID = docID;
            this.medicalExaminationResult = medicalExaminationResult;
            this.hasDeferment = hasDeferment;
            this.city = city;
            this.armyUnit = armyUnit;
                        
        }


        public string GetData()
        {
            return $"Ім'я: {FirstName} {LastName}, Вік: {Age}, ID: {DocID}, Медогляд: {MedicalExaminationResult}," +
                $" Відсрочка: {HasDeferment}, Місто: {City}, Cлужбова частина: {armyUnit}";
        }

    }
}