

namespace reservepp
{
    public class UserActionFactory
    {
        private readonly IOrderService _orderService;
        private readonly IUserService _userService;

        public UserActionFactory(IOrderService orderService, IUserService userService)
        {
            _orderService = orderService;
            _userService = userService;
        }

        public object GetActionsForRole(string role)
        {
            return role switch
            {
                "Officer" => new OfficerActions(_orderService),
                "Conscript" => new ConscriptActions(_userService),
                "TCKEmployee" => new TCKEmployeeActions(_orderService, _userService),
                _ => null
            };
        }
    }
}