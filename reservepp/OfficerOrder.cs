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
        public OfficerOrder()
        {
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
            MessageBox.Show("Ваша заявка надіслана! \nОчікуйте її розгляду найближчим часом", "Заявка на поповнення", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }
    }
}
