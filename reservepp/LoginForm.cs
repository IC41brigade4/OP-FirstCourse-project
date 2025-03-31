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


            //ConscriptForm conscriptForm = new ConscriptForm();
            //conscriptForm.Show(); // Відкриваємо нову форму
            //this.Hide();

            if (Program.letMeIn(password, int.Parse(login), userRepository))
            {
                ConscriptForm conscriptForm = new ConscriptForm();
                conscriptForm.Show(); // Відкриваємо нову форму
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Невірний пароль або логін, спробуйте ще");
            }
        }
    }
}
