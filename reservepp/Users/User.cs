namespace reservepp
{
    public abstract class User
    {
        private int age, docID;
        private string firstName, lastName, medicalExaminationResult, city;
        private bool hasDeferment;

        public User(string firstName, string lastName, int age, int docID, string medicalExaminationResult, bool hasDeferment, string city) {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.docID = docID;
            this.medicalExaminationResult = medicalExaminationResult;
            this.hasDeferment = hasDeferment;
            this.city = city;
        }

        public int Age { get => age; set => age = value; }
        public int DocID { get => docID; set => docID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string MedicalExaminationResult { get => medicalExaminationResult; set => medicalExaminationResult = value; }
        public bool HasDeferment { get => hasDeferment; set => hasDeferment = value; }
        public string City { get => city; set => city = value; }
        public string Name => $"{firstName} {lastName}";
        public abstract void displayInfo();
        public void SetData(string firstName, string lastName, int age, int docID, string medicalExaminationResult, bool hasDeferment, string city)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.docID = docID;
            this.medicalExaminationResult = medicalExaminationResult;
            this.hasDeferment = hasDeferment;
            this.city = city;
        }
        public string GetData()
        {
            return $"Имя: {FirstName} {LastName}, Возраст: {Age}, ID: {DocID}, Медосмотр: {MedicalExaminationResult}, Отсрочка: {HasDeferment}, Город: {City}";
        }

    }
}