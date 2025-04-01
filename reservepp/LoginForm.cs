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
    public partial class LoginForm: Form
    {
        Repository<User> userRepository;
        public LoginForm(Repository<User> userRepository)
        {
            this.userRepository = userRepository;
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

            User user = userRepository.GetById(docID);

            if (user == null)
            {
                MessageBox.Show("Користувач не знайдений!");
                return;
            }

            if (Program.letMeIn(password, docID, userRepository))
            {
                if (user is Conscript)
                {
                    ConscriptForm conscriptForm = new ConscriptForm(userRepository, docID);
                    conscriptForm.Show(); // Відкриваємо нову форму
                    this.Close();
                }
                else if (user is Officer)
                {
                    OfficerForm officerForm = new OfficerForm(userRepository, docID);
                    officerForm.Show(); // Відкриваємо нову форму
                    this.Close();
                }
                else if(user is TCKEmployee)
                {
                    TCKForm tckForm = new TCKForm(userRepository, docID);
                    tckForm.Show(); // Відкриваємо нову форму
                    this.Close();
                }
                
            }
            else
            {
                MessageBox.Show(" Невірний пароль або логін, спробуйте ще");
            }
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(userRepository);
            registerForm.Show();
            this.Close();
        }
    }
}
