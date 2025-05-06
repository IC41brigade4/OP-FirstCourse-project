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
    public partial class MainForm : Form
    {
        Repository<User> userRepository;
        Repository<Order> orderRepository;
        public MainForm(Repository<User> userRepository, Repository<Order> orderRepository)
        {
            this.userRepository = userRepository;
            this.orderRepository = orderRepository;
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

        private void register_button_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm(userRepository, orderRepository);
            registerForm.Show();
            this.Hide();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm(userRepository, orderRepository);
            loginForm.Show();
            this.Hide();
        }
    }
}
