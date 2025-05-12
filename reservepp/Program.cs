using System;
using System.Security.Cryptography;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
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

            //Officer officer1 = new Officer("Андрій", "Покришка", 42, 1, "Не риба не м'ясо",
            //    false, "Жидомир", "of", "None", userService, orderService);
            //userService.AddUser(officer1);
            Application.Run(new MainForm(userRepository, orderRepository, userService, orderService));
            Application.Exit();
        }
    }
}
