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
        Repository<User> userRepository;
        int DocId;
        public OfficerForm(Repository<User> userRepository, int docId)
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
            // need to add inf to textfields
        }

        private void change_inf_btn_Click(object sender, EventArgs e)
        {
            this.Inf_panel_change.Visible = true;
            this.Change_btn.Visible = true;
        }

        private void Change_btn_Click(object sender, EventArgs e)
        {
            // need to save somewhere changed inf
            this.Inf_panel_change.Visible = false;
            this.Change_btn.Visible = false;
        }

        private void gotit_btn_Click(object sender, EventArgs e)
        {
            this.Inf_panel.Visible = false;
            this.gotit_btn.Visible = false;
        }
    }
}
