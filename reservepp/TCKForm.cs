namespace reservepp
{
    public partial class TCKForm : Form
    {
        private readonly IUserService _userService;
        private readonly IOrderService _orderService;
        private readonly TCKEmployeeActions _tckActions;
        private int _docId;

        public TCKForm(IUserService userService, IOrderService orderService)
        {
            _userService = userService;
            _orderService = orderService;
            _tckActions = new TCKEmployeeActions(_orderService);
            InitializeComponent();
        }

        public void SetDocId(int docId)
        {
            _docId = docId;
            LoadUserInfo();
            LoadOrders();
        }

        private void LoadUserInfo()
        {
            var user = _userService.GetById(_docId);
            if (user == null)
            {
                MessageBox.Show("Користувач не знайдений!");
                return;
            }

            firstname_text.Text = $"Ім'я: {user.FirstName}";
            lastname_text.Text = $"Прізвище: {user.LastName}";
            age_text.Text = $"Вік: {user.Age}";
            docid_text.Text = $"Номер документа: {user.DocID}";
            city_text.Text = $"Місто прописки: {user.City}";
        }

        private void LoadOrders()
        {
            var orders = _orderService.GetAllOrders().ToList();
            if (orders.Count == 0)
            {
                Text_for_permision.Text = "Немає ніяких запитів";
            }
            else
            {
                var order = orders[0];
                Text_for_permision.Text = $"Officer({order.DocID}) mess:{order.OrderText}, number:{order.OrderNum}";
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

        private void permission_btn_Click(object sender, EventArgs e)
        {
            bool? isPermissionGranted = radioButton1.Checked ? true :
                                 radioButton2.Checked ? false : (bool?)null;

            string result = _tckActions.AgreeOffer(isPermissionGranted);
            Text_for_permision.Text = result;

            if (result == "Тобі потрібно обрати надавати дозвіл чи ні!")
            {
                MessageBox.Show(result);
            }
        }

        private void save_btn_Click(object sender, EventArgs e) { }
        private void change_inf_btn_Click(object sender, EventArgs e) { }
    }
}
