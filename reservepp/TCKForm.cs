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
        Repository<Order> orderRepository;
        UserService userService;
        OrderService orderService;
        int DocId;
        List<Order> orders;
        int counter = 0;
        public TCKForm(Repository<User> userRepository, int docId, Repository<Order> orderRepository, UserService userService, OrderService orderService)
        {
            InitializeComponent();
            this.userRepository = userRepository;
            this.orderRepository = orderRepository;
            this.userService = userService;
            this.orderService = orderService;
            this.
            DocId = docId;

            User user = userRepository.GetById(DocId);
            orders = orderRepository.GetAll();

            if (user == null)
            {
                MessageBox.Show("Користувач не знайдений!");
                return;
            }

            // Оновлення тексту
            firstname_text.Text = $"Ім'я: {user.FirstName}";
            lastname_text.Text = $"Прізвище: {user.LastName}";
            age_text.Text = $"Вік: {user.Age}";
            docid_text.Text = $"Номер документа: {user.DocID}";
            city_text.Text = $"Місто прописки: {user.City}";

            if (orders.Count == 0)
            {
                Text_for_permision.Text = "Немає ніяких запитів";
            }
            else
            {
                var order1 = orders[0];
                Text_for_permision.Text = $"Officer({order1.DocID}) mess:{order1.OrderText}, number:{order1.OrderNum}";
            }
            
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

            User user = userService.GetById(DocId);

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

            userService.UpdateUser(user);
        }

        private void permission_btn_Click(object sender, EventArgs e)
        {
            bool? isPermissionGranted = radioButton1.Checked ? true :
                                 radioButton2.Checked ? false : (bool?)null;
            var order = orders[0];
            User user = userService.GetById(DocId);
            string result = ((TCKEmployee)userService.GetById(user.DocID)).AgreeOffer(isPermissionGranted);
            Text_for_permision.Text = result;

            if (result == "Тобі потрібно обрати надавати дозвіл чи ні!")
            {
                MessageBox.Show(result);
            }
        }

        private void save_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
