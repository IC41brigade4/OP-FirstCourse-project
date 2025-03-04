class Conscript : User, ConscriptInterface
{
    public Conscript(std::string firstName, std::string lastName, int age, int docID, std::string medicalExaminationResult,
            bool HasDeferment, std::string city)
        : base(firstName, lastName, age, docID, medicalExaminationResult,
            HasDeferment, string city)
    { }

    //todo

    void override displayInfo()
    {
        base.getAge();
        base.getFirstName();
        base.getLastName();
        base.getName();
        base.getDocID();
        base.getMedicalExaminationResult();
        base.getHasDeferment();
        base.getCity();
        base.getData();
    }
}