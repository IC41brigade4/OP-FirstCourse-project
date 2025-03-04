abstract class User
{
	private int age, docID;
    private string firstName, lastName, medicalExaminationResult, city;
    private bool hasDeferment;
    
	User(std::string firstName, std::string lastName, int age, int docID, std::string medicalExaminationResult, bool HasDeferment, std::string city) {
        this->firstName = firstName;
        this->lastName = lastName;
        this->age = age;
        this->docID = docID;
        this->medicalExaminationResult = medicalExaminationResult;
        this->hasDeferment = hasDeferment;
        this->city = city;
    };

    /*
    SETTERS
    */
    public void setAge(int age)
    {
        this->age = age;
    }
    public void setFirstName(string firstName)
    {
        this->firstName = firstName;
    }
    public void setLastName(string lastName)
    {
        this->lastName = lastName;
    }
    public void setDocID(int age)
    {
        this->age = age;
    }
    public void setMedicalExaminationResult(string medicalExaminationResult)
    {
        this->medicalExaminationResult = medicalExaminationResult;
    }
    public void setHasDeferment(bool HasDeferment)
    {
        this->hasDeferment = hasDeferment;
    }
    public void setCity(string city)
    {
        this->city = city;
    }
    public void setData(string firstName, string lastName, int age, int docID, string medicalExaminationResult, bool hasDeferment, string city)
    {
        this->firstName = firstName;
        this->lastName = lastName;
        this->age = age;
        this->docID = docID;
        this->medicalExaminationResult = medicalExaminationResult;
        this->hasDeferment = hasDeferment;
        this->city = city;
    }
    /*
    GETTERS
    */
    public int getAge()
    {
        return age;
    }
    public string firstName()
    {
        return firstName;
    }
    public string lastName()
    {
        return lastName;
    }
    public string getName()
    {
        return firstName + " " + lastName;
    }
    public int getDocID()
    {
        return docID;
    }
    public string getMedicalExaminationResult()
    {
        return medicalExaminationResult;
    }
    public bool getHasDeferment()
    {
        return hasDeferment;
    }
    public string getCity()
    {
        return city;
    }
    public void getData()
    {

    }

    public abstract void displayInfo();

}