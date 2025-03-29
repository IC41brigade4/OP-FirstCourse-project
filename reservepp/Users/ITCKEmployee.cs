namespace reservepp
{
    public interface ITCKEmployee
    {
        void issue_permits(int docID);
        void provide_information(string firstName, string lastName, int age, int docID, string medicalExaminationResult, bool hasDeferment, string city);
        void CheckSoldier(int docID);
        void displayInfo();
    }
}    
