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
            User officer1 = new Officer("Михайло", "Драган", 24, 12345, "Придатний", false, "Кривий Ріг", "asd1");
            User conscript1 = new Conscript("Максим", "Пловоїдік", 19, 122345, "Частково придатний", false, "Рівний Ріг", "asd2");
            User tckEmployee1 = new TCKEmployee("Женя", "Чєрєпіца", 69, 3345, "Непридатний", false, "Прямий Ріг", "asd3");
            userService.AddUser(officer1);
            userService.AddUser(conscript1);
            userService.AddUser(tckEmployee1);


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
