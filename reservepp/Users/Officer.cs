class Officer : User, OfficerInterface
{
    Officer(std::string firstName, std::string lastName, int age, int docID, std::string medicalExaminationResult, 
            bool HasDeferment, std::string city)
        : base(firstName, lastName, age, docID, medicalExaminationResult, HasDeferment, city)

    void makeOffer(int amount)
    {

    }
    void returnSoldier(int docID)
    {

    }
    void returnSoldiers(List<int> docsID)
    {

    }
    void override displayInfo()
    {
        
    }
}