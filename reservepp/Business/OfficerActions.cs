


namespace reservepp
{
    public class OfficerActions
    {
        private readonly IOrderService _orderService;

        public OfficerActions(IOrderService orderService)
        {
            _orderService = orderService;
        }

        public bool MakeOffer(string orderText, string peopleNumText, int docId)
        {
            if (!int.TryParse(peopleNumText, out int orderNum))
            {
                return false; // Повертаємо false замість MessageBox
            }

            var order = new Order
            {
                DocID = docId,
                OrderNum = orderNum,
                OrderText = orderText,
                Status = "Не переглянуто"
            };

            _orderService.AddOrder(order);
            return true;
        }
    }
}