

namespace reservepp
{
    public partial class ConscriptForm : Form
    {
        private readonly IUserService _userService;
        private int _docId;
        private int _counter = 0;

        public ConscriptForm(IUserService userService)
        {
            _userService = userService;
            InitializeComponent();
        }

        public void SetDocId(int docId)
        {
            _docId = docId;
            LoadUserInfo();
        }

        private void LoadUserInfo()
        {
            var user = _userService.GetById(_docId);
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

            var user = _userService.GetById(_docId);
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

            _userService.UpdateUser(user);
        }

        private void run_btn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int number = random.Next(1, 21);
            int escape_num = 6;

            if (_counter >= 1)
            {
                this.run_text.Text = "You couldn't escape\n You don't have any chances";
            }
            else
            {
                if (number == escape_num)
                {
                    this.run_text.Text = "You escape, so lucky";
                    _userService.DeleteUser(_docId);
                }
                else
                {
                    this.run_text.Text = "You couldn't escape";
                }
            }
            _counter++;
        }

        private void get_inf_btn_Click(object sender, EventArgs e) { }
    }
}
