class TCKEmployee : User, TCKEmployeeInterface
{
    public TCKEmployee(std::string firstName, std::string lastName, int age, int docID, std::string medicalExaminationResult,
            bool HasDeferment, std::string city)
        : base(firstName, lastName, age, docID, medicalExaminationResult,
            HasDeferment, string city)
    { }

    public void CheckSoldier(int docID)
    {
        
    }

    void override displayInfo()
    {
        
    }

}