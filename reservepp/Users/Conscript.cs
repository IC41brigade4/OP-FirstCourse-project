namespace reservepp
{
    class Conscript : User, ConscriptInterface
    {
        public Conscript(string firstName, string lastName, int age, int docID, string medicalExaminationResult,
                bool HasDeferment, string city, string password)
            : base(firstName,
                   lastName,
                   age,
                   docID,
                   medicalExaminationResult,
                   HasDeferment,
                   city,
                   password)
        { }

        public void getMobilizated(bool mobilizated)
        {
            
        }

        public void leaveArmy(bool mobilizated)
        {
            
        }

        public override void displayInfo()
        {
            
        }
    }
}