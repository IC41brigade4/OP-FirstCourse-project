using System;
using System.Windows.Forms;
namespace reservepp
{
    internal static class Program
    {

        [STAThread]
        static bool letMeIn(string enteredPassword, int docID, Repository<User> repository) {
            string hashedPassword = repository.GetById(docID).HashedPassword;
            bool isCorrect = BCrypt.Net.BCrypt.Verify(enteredPassword, hashedPassword);
            if (isCorrect) return true;
            else return false;
        }
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            IRepository<User> userRepository = new Repository<User>();
            var userService = new UserService(userRepository);
            Application.Run(new LoginForm());

            //// Додавання продукту
            //User officer1 = new Officer("Иван", "Иванов", 20, 12345, "Годен", false, "Кривий Ріг");
            //User conscript1 = new Conscript("Иван1", "Иванов1", 20, 122345, "не годен", false, "Рівний Ріг");
            //User officer3 = new Officer("Иван2", "Иванов2", 20, 3345, "Годен", false, "Прямий Ріг");
            //userService.AddUser(officer1);
            //userService.AddUser(conscript1);
            //userService.AddUser(officer3);

            //// Виводимо всі продукти
            //MessageBox.Show("Products after adding:", "Сообщение");
            //foreach (var user in userService.GetAllUsers())
            //{
            //    MessageBox.Show(user.GetData(), "Сообщение");
            //}

            //// Видаляємо перший продукт 
            //userService.DeleteUser(officer1.DocID);
            //userService.DeleteUser(conscript1.DocID);

            //// Виводимо продукти після видалення

            //MessageBox.Show("After deletion:", "Сообщение");
            //foreach (var user in userService.GetAllUsers())
            //{
            //    MessageBox.Show(user.GetData(), "Сообщение");
            //}

        }
    }
}
