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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Repository<User> userRepository = new Repository<User>();
            var userService = new UserService(userRepository);

            // Додавання продукту
            User officer1 = new Officer("Иван", "Иванов", 20, 12345, "Годен", false, "Кривий Ріг", "asd1");
            User conscript1 = new Conscript("Иван1", "Иванов1", 20, 122345, "не годен", false, "Рівний Ріг", "asd2");
            User officer3 = new TCKEmployee("Иван2", "Иванов2", 20, 3345, "Годен", false, "Прямий Ріг", "asd3");
            userService.AddUser(officer1);
            userService.AddUser(conscript1);
            userService.AddUser(officer3);


            Application.Run(new MainForm(userRepository));

            //foreach (var user in userRepository.GetAll())
            //{
            //    MessageBox.Show($"ID: {user.DocID}, Password: {user.HashedPassword}");
            //}

            //// Виводимо всі продукти
            //MessageBox.Show("Products after adding:", "Сообщение");
            //foreach (var user in userService.GetAllUsers())
            //{
            //    MessageBox.Show(user.GetData(), "Сообщение");
            //}
            //
            //// Видаляємо перший продукт 
            //userService.DeleteUser(officer1.DocID);
            //userService.DeleteUser(conscript1.DocID);
            //
            //// Виводимо продукти після видалення
            //
            //MessageBox.Show("After deletion:", "Сообщение");
            //foreach (var user in userService.GetAllUsers())
            //{
            //    MessageBox.Show(user.GetData(), "Сообщение");
            //}

        }
    }
}
