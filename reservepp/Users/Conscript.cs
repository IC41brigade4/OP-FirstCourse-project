class Conscript : User, IConscript
{
    public Conscript(std::string firstName, std::string lastName, int age, int docID, std::string medicalExaminationResult,
            bool HasDeferment, std::string city)
        : base(firstName, lastName, age, docID, medicalExaminationResult,
            HasDeferment, string city)
    { }

    void override displayInfo()
    {
        
    }
}