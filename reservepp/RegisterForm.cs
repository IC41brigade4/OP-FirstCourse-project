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

        Repository<User> userRepository;
        public RegisterForm(Repository<User> userRepository)
        {
            this.userRepository = userRepository;
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
            LoginForm loginForm = new LoginForm(userRepository);
            loginForm.Show();
            this.Close();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            string login = login_textbox.Text;
            string password = password_textbox.Text;
            string employee_key = key_textbox.Text;
            string real_key = "employee";

            if (!int.TryParse(login, out int docID))
            {
                MessageBox.Show("Логін має бути числом!");
                return;
            }
            User user = new Conscript("Name", "Secondname", 20, docID, "Годен", false, "City", password); ;

            if (employee_key == real_key)
            {
                if (radioOfficer.Checked)
                {
                    user = new Officer("Name", "Secondname", 20, docID, "Годен", false, "City", password);
                }
                else if (radiotck.Checked)
                {
                    user = new TCKEmployee("Name", "Secondname", 20, docID, "Годен", false, "City", password);
                }
            }
            
            userRepository.Add(user);
            MessageBox.Show("Користувач створений. Можете перейти та змінити інформацію.");
        }
    }
}
