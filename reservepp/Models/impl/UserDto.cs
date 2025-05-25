using System.ComponentModel.DataAnnotations;

namespace reservepp
{
    public class UserDto
    {
        [Key]
        public int DocID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string MedicalExaminationResult { get; set; }
        public bool HasDeferment { get; set; }
        public string City { get; set; }
        public string HashedPassword { get; set; }
        public string ArmyUnit { get; set; }
        public string Role { get; set; } // "Officer", "Conscript", "TCKEmployee"
    }
}