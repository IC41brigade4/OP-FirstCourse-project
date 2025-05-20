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
    public partial class OfficerForm: Form
    {
        UserRepository<UserEntity> userRepository;
        OrderRepository orderRepository;
        UserService userService;
        int DocId;
        int person_id;
        public OfficerForm(UserRepository<UserEntity> userRepository, int docId, OrderRepository orderRepository, UserService userService)
        {
            InitializeComponent();
            this.userRepository = userRepository;
            DocId = docId;
            person_id = DocId;
            this.orderRepository = orderRepository;
            this.userService = userService;
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
            
            UserEntity user = userRepository.GetById(person_id);

            

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

        private void Change_btn_Click(object sender, EventArgs e)
        {
            this.Inf_panel_change.Visible = true;
            this.Change_btn.Visible = true;

            UserEntity user = userRepository.GetById(person_id);

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

        private void personal_inf_Click(object sender, EventArgs e)
        {
            person_id = DocId;
            this.enter_doc_textbox.Visible = false;
            this.enter_doc_text.Visible = false;
            this.save_doc_btn.Visible = false;

            UserEntity user = userRepository.GetById(person_id);

            if (user == null)
            {
                MessageBox.Show("Користувач не знайдений!");
                return;
            }

            firstname_text.Text = $"First name: {user.FirstName}";
            lastname_text.Text = $"Last name: {user.LastName}";
            age_text.Text = $"Age: {user.Age}";
            docid_text.Text = $"DocID: {user.DocID}";
            city_text.Text = $"City: {user.City}";

        }

        private void Conscript_inf_Click_1(object sender, EventArgs e)
        {
            this.enter_doc_textbox.Visible = true;
            this.enter_doc_text.Visible = true;
            this.save_doc_btn.Visible = true;
        }

        private void save_doc_btn_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(enter_doc_textbox.Text, out person_id))
            {
                MessageBox.Show("Документ має номер а не незрозумілі символи");
                return;
            }

            UserEntity user = userRepository.GetById(person_id);

            if (user == null)
            {
                MessageBox.Show("Користувач не знайдений!");
                return;
            }

            firstname_text.Text = $"First name: {user.FirstName}";
            lastname_text.Text = $"Last name: {user.LastName}";
            age_text.Text = $"Age: {user.Age}";
            docid_text.Text = $"DocID: {user.DocID}";
            city_text.Text = $"City: {user.City}";
        }

        private void permission_btn_Click(object sender, EventArgs e)
        {
            OfficerOrder officerOrder = new OfficerOrder(orderRepository, DocId, userService);
            officerOrder.Show(); // Відкриваємо нову форму
        }

    }
}
