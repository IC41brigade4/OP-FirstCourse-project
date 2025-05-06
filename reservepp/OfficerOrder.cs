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
    public partial class OfficerOrder: Form
    {
        Repository<Order> orderRepository;
        int DocId;
        public OfficerOrder(Repository<Order> orderRepository, int DocId)
        {
            this.orderRepository = orderRepository;
            this.DocId = DocId;
            InitializeComponent();
        }
        private void OfficerOrderForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        Point lastpoint;

        private void OfficerOrderForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void permission_btn_Click(object sender, EventArgs e)
        {
            string orderText = details_textbox.Text;
            string peoplenum_text = peoplenum_textbox.Text;
            if (!int.TryParse(peoplenum_text, out int orderNum))
            {
                MessageBox.Show("Кількість людей має бути числом!");
                return;
            }

            Order order = new Order(DocId, orderNum, orderText, "Не переглянуто");
            orderRepository.Add(order);

            MessageBox.Show("Ваша заявка надіслана! \nОчікуйте її розгляду найближчим часом", "Заявка на поповнення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
