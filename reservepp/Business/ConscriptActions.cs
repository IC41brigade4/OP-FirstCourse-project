

namespace reservepp
{
    public class ConscriptActions
    {
        private readonly IUserService _userService;

        public ConscriptActions(IUserService userService)
        {
            _userService = userService;
        }

        public bool GetMobilizated(UserDto conscript, int officerDocID)
        {
            var officer = _userService.GetById(officerDocID);
            if (officer != null && officer.Role == "Officer")
            {
                conscript.ArmyUnit = officer.ArmyUnit;
                _userService.UpdateUser(conscript);
                return true;
            }
            return false;
        }

        public bool LeaveArmy(UserDto conscript)
        {
            conscript.ArmyUnit = "None";
            _userService.UpdateUser(conscript);
            return true;
        }
    }
}