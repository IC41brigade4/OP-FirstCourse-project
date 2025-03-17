using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reservepp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
            // Настройка контекста базы данных (используем InMemoryDatabase для примера)
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseInMemoryDatabase("TestDb")
                .Options;

            var context = new AppDbContext(options);

            // Создание экземпляра репозитория для работы с сущностями User
            var userRepository = new Repository<User>(context);

            // 1. Добавление нового пользователя
            var newUser = new User { Name = "Alice", Email = "alice@example.com" };
            userRepository.Add(newUser);
            Console.WriteLine("User added");

            // 2. Получение всех пользователей
            var users = userRepository.GetAll();
            Console.WriteLine("All users:");
            foreach (var user in users)
            {
                Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Email: {user.Email}");
            }

            // 3. Обновление пользователя
            var userToUpdate = users.First();
            userToUpdate.Name = "Alice Updated";
            userRepository.Update(userToUpdate);
            Console.WriteLine("User updated");

            // 4. Удаление пользователя
            var userToDelete = users.Last();
            userRepository.Delete(userToDelete.Id);
            Console.WriteLine("User deleted");

            // 5. Проверка, что пользователь удален
            var remainingUsers = userRepository.GetAll();
            Console.WriteLine("Remaining users:");
            foreach (var user in remainingUsers)
            {
                Console.WriteLine($"Id: {user.Id}, Name: {user.Name}, Email: {user.Email}");
            }

        }
    }
}
