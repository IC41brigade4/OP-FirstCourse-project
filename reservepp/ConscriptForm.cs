using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reservepp
{
    public partial class ConscriptForm : Form
    {
        UserRepository<UserEntity> userRepository;
        int DocId;
        int counter = 0;
        public ConscriptForm(UserRepository<UserEntity> userRepository, int docId)
        {
            InitializeComponent();
            this.userRepository = userRepository;
            DocId = docId;

            UserEntity user = userRepository.GetById(DocId);

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

        private void Change_btn_Click(object sender, EventArgs e)
        {
            this.Inf_panel_change.Visible = true;
            this.Change_btn.Visible = true;

            UserEntity user = userRepository.GetById(DocId);

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

            firstname_text.Text = $"First name: {user.FirstName}";
            lastname_text.Text = $"Last name: {user.LastName}";
            age_text.Text = $"Age: {user.Age}";
            docid_text.Text = $"DocID: {user.DocID}";
            city_text.Text = $"City: {user.City}";

            userRepository.Update(user);
        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int number = random.Next(1, 21);
            int escape_num = 6;
            if (counter >= 1)
            {
                this.run_text.Text = "You couldn't escape\n You don't have any chances";
            }
            else
            {
                if (number == escape_num)
                {
                    this.run_text.Text = "You escape, so lucky";
                    userRepository.Delete(DocId);
                }
                else
                {
                    this.run_text.Text = "You couldn't escape";
                }
            }
            counter++;

        }

        private void get_inf_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
