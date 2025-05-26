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
    public partial class LoginForm : Form
    {
        private readonly IUserService _userService;
        private readonly IServiceProvider _serviceProvider;

        public LoginForm(IUserService userService, IServiceProvider serviceProvider)
        {
            _userService = userService;
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        Point lastpoint;

        private void LoginForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            string login = login_textbox.Text;
            string password = password_textbox.Text;

            if (!int.TryParse(login, out int docID))
            {
                MessageBox.Show("Логін має бути числом!");
                return;
            }

            var user = _userService.GetById(docID);
            if (user == null)
            {
                MessageBox.Show("Користувач не знайдений!");
                return;
            }

            if (Program.LetMeIn(password, docID, _userService))
            {
                var scope = _serviceProvider.CreateScope(); // НЕ using
                Form nextForm = null;

                switch (user.Role)
                {
                    case "Conscript":
                        nextForm = scope.ServiceProvider.GetRequiredService<ConscriptForm>();
                        ((ConscriptForm)nextForm).SetDocId(docID);
                        break;
                    case "Officer":
                        nextForm = scope.ServiceProvider.GetRequiredService<OfficerForm>();
                        ((OfficerForm)nextForm).SetDocId(docID);
                        break;
                    case "TCKEmployee":
                        nextForm = scope.ServiceProvider.GetRequiredService<TCKForm>();
                        ((TCKForm)nextForm).SetDocId(docID);
                        break;
                }

                if (nextForm != null)
                {
                    // Після закриття нової форми — звільняємо scope і виходимо
                    nextForm.FormClosed += (s, args) =>
                    {
                        scope.Dispose();
                        Application.Exit(); // повністю завершує додаток
                    };

                    nextForm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Невірний пароль або логін, спробуйте ще");
            }
        }


        private void register_button_Click(object sender, EventArgs e)
        {
            var scope = _serviceProvider.CreateScope(); // НЕ using
            var registerForm = scope.ServiceProvider.GetRequiredService<RegisterForm>();

            registerForm.FormClosed += (s, args) =>
            {
                scope.Dispose(); // звільняємо ресурси тільки після закриття форми
                Application.Exit(); // або this.Show() — залежно від логіки
            };

            registerForm.Show();
            this.Hide();
        }

        private void password_text_Click(object sender, EventArgs e) { }
        private void password_textbox_TextChanged(object sender, EventArgs e) { }
    }
}

