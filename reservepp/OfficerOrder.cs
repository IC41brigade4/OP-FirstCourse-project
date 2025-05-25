

namespace reservepp
{
    public partial class OfficerOrder : Form
    {
        private readonly IOrderService _orderService;
        private readonly OfficerActions _officerActions;
        private int _docId;

        public OfficerOrder(IOrderService orderService)
        {
            _orderService = orderService;
            _officerActions = new OfficerActions(_orderService);
            InitializeComponent();
        }

        public void SetDocId(int docId)
        {
            _docId = docId;
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
            bool success = _officerActions.MakeOffer(details_textbox.Text, peoplenum_textbox.Text, _docId);

            if (!success)
            {
                MessageBox.Show("Кількість людей має бути числом!");
                return;
            }

            MessageBox.Show("Запит створено успішно!");
            this.Hide();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
