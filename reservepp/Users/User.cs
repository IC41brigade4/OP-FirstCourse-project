abstract class User
{
	int age, docID;
    string firstName, lastName, medicalExaminationResult, city;
    bool hasDeferment;
   
	User(std::string firstName, std::string lastName, int age, int docID, std::string medicalExaminationResult, bool HasDeferment, std::string city) { };

    // SETTERS
    void setAge(int age)
    {
        this->age = age;
    }
    void setFirstName(string firstName)
    {
        this->firstName = firstName;
    }
    void setLastName(string lastName)
    {
        this->lastName = lastName;
    }
    void setDocID(int age)
    {
        this->age = age;
    }
    void setMedicalExaminationResult(string medicalExaminationResult)
    {
        this->medicalExaminationResult = medicalExaminationResult;
    }
    void setHasDeferment(bool HasDeferment)
    {
        this->hasDeferment = hasDeferment;
    }
    void setCity(string city)
    {
        this->city = city;
    }
    void setData(string firstName, string lastName, int age, int docID, string medicalExaminationResult, bool hasDeferment, string city)
    {
        this->firstName = firstName;
        this->lastName = lastName;
        this->age = age;
        this->docID = docID;
        this->medicalExaminationResult = medicalExaminationResult;
        this->hasDeferment = hasDeferment;
        this->city = city;
    }
    // GETTERS
    int getAge()
    {
        return age;
    }
    string firstName()
    {
        return firstName;
    }
    string lastName()
    {
        return lastName;
    }
    string getName()
    {
        return firstName + " " + lastName;
    }
    int getDocID()
    {
        return docID;
    }
    string getMedicalExaminationResult()
    {
        return medicalExaminationResult;
    }
    bool getHasDeferment()
    {
        return hasDeferment;
    }
    string getCity()
    {
        return city;
    }
    void getData()
    {

    }
}