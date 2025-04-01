using Org.BouncyCastle.Crypto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reservepp
{
    public partial class TCKForm: Form
    {
        Repository<User> userRepository;
        int DocId;
        public TCKForm(Repository<User> userRepository, int docId)
        {
            InitializeComponent();
            this.userRepository = userRepository;
            DocId = docId;
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

        private void get_inf_btn_Click(object sender, EventArgs e)
        {
            this.Inf_panel.Visible = true;
            this.gotit_btn.Visible = true;

            User user = userRepository.GetById(DocId);

            if (user == null)
            {
                MessageBox.Show("Користувач не знайдений!");
                return;
            }

            // Оновлення тексту
            firstname_text.Text = $"First name: {user.FirstName}";
            lastname_text.Text = $"Last name: {user.LastName}";
            age_text.Text = $"Age: {user.Age}";
            docid_text.Text = $"DocID: {user.DocID}";
            city_text.Text = $"City: {user.City}";

            // Переконайся, що елементи відображаються
            firstname_text.Show();
            lastname_text.Show();
            age_text.Show();
            docid_text.Show();
            city_text.Show();
        }

        private void change_inf_btn_Click(object sender, EventArgs e)
        {
            this.Inf_panel_change.Visible = true;
            this.Change_btn.Visible = true;
        }

        private void Change_btn_Click(object sender, EventArgs e)
        {
            this.Inf_panel_change.Visible = true;
            this.Change_btn.Visible = true;

            User user = userRepository.GetById(DocId);

            if (user == null)
            {
                MessageBox.Show("Користувач не знайдений!");
                return;
            }

            user.FirstName = firstname_textbox.Text;
            user.LastName = lastname_textbox.Text;

            if (!int.TryParse(age_textbox.Text, out int age_int))
            {
                MessageBox.Show("Де ти бачив букви заміст віку або мінусовий вік!!");
                return;
            }
            user.Age = age_int;
            user.City = city_textbox.Text;

            userRepository.Update(user);
        }

        private void gotit_btn_Click(object sender, EventArgs e)
        {
            this.Inf_panel.Visible = false;
            this.gotit_btn.Visible = false;
        }
    }
}
