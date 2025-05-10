using System;
using System.Windows.Forms;
namespace reservepp
{
    internal static class Program
    {

        [STAThread]
        public static bool letMeIn(string enteredPassword, int docID, Repository<User> repository)
        {
            User user = repository.GetById(docID);

            if (user == null)
            {
                MessageBox.Show($"Користувач із docID = {docID} не знайдений.");
                return false;
            }

            string hashedPassword = user.HashedPassword;
            bool isCorrect = BCrypt.Net.BCrypt.Verify(enteredPassword, hashedPassword);
            return isCorrect;
        }
        
        static void Main()                 
        {                                  
            string filePath = "users.json";
            string filePath_orders = "orders.json";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IDataStorage<User> dataStorage = new JsonStorage<User>(filePath);
            Repository<User> userRepository = new Repository<User>(dataStorage);
            var userService = new UserService(userRepository);
       
            IDataStorage<Order> orderStorage = new JsonOrderStorage<Order>(filePath_orders);
            Repository<Order> orderRepository = new Repository<Order>(orderStorage);
            var orderService = new OrderService(orderRepository);

            //User officer1 = new Officer("Михайло", "Драган", 24, 12345, "Придатний", false, "Кривий Ріг", "asd1");
            //User conscript1 = new Conscript("Максим", "Пловоїдік", 19, 122345, "Частково придатний", false, "Рівний Ріг", "asd2");
            //User tckEmployee1 = new TCKEmployee("Женя", "Чєрєпіца", 69, 3345, "Непридатний", false, "Прямий Ріг", "asd3");
            //userService.AddUser(officer1);
            //userService.AddUser(conscript1);
            //userService.AddUser(tckEmployee1);

            Application.Run(new MainForm(userRepository, orderRepository, userService, orderService));
            Application.Exit();
        }
    }
}
