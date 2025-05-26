using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reservepp
{
    public partial class RegisterForm : Form
    {
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;

        public RegisterForm(IUserService userService, IServiceProvider serviceProvider)
        {
            _userService = userService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void RegisterForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        Point lastpoint;

        private void RegisterForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            var scope = _serviceProvider.CreateScope(); // НЕ using, щоб scope жив поки форма відкрита
            var loginForm = scope.ServiceProvider.GetRequiredService<LoginForm>();

            loginForm.FormClosed += (s, args) =>
            {
                scope.Dispose(); // Звільняємо ресурси, коли форма закриється
                this.Show();     // Показати цю форму, якщо треба повернутись
            };

            loginForm.Show();
            this.Hide();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            string login = login_textbox.Text;
            string password = password_textbox.Text;
            string employee_key = key_textbox.Text;
            string officer_key = "officer";
            string tck_key = "tck";

            if (!int.TryParse(login, out int docID))
            {
                MessageBox.Show("Логін має бути числом!");
                return;
            }

            var existingUser = _userService.GetById(docID);
            if (existingUser != null)
            {
                MessageBox.Show($"Користувач із docID = {docID} вже є оберіть інше.");
                return;
            }

            var user = new UserDto
            {
                DocID = docID,
                FirstName = "Name",
                LastName = "Secondname",
                Age = 20,
                MedicalExaminationResult = "Годен",
                HasDeferment = false,
                City = "City",
                HashedPassword = password, // Буде захешовано в сервісі
                ArmyUnit = "None",
                Role = "Conscript"
            };

            if (employee_key == officer_key)
            {
                user.Role = "Officer";
            }
            else if (employee_key == tck_key)
            {
                user.Role = "TCKEmployee";
            }
            else if (!string.IsNullOrEmpty(employee_key))
            {
                MessageBox.Show("Такого ключа не існує!");
                return;
            }

            _userService.AddUser(user);
            MessageBox.Show("Користувач створений. Можете перейти та змінити інформацію.");
        }
    }
}
