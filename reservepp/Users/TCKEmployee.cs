namespace reservepp
{
    class TCKEmployee : User, ITCKEmployee
    {
        public TCKEmployee(string firstName, string lastName, int age, int docID, string medicalExaminationResult,
                bool HasDeferment, string city)
            : base(firstName, lastName, age, docID, medicalExaminationResult,
                HasDeferment, city)
        { }

        public void CheckSoldier(int docID)
        {

        }

        public override void displayInfo()
        {

        }

        public void issue_permits(int docID)
        {

        }

        public void provide_information(string firstName, string lastName, int age, int docID, string medicalExaminationResult, bool hasDeferment, string city)
        {

        }
    }
}