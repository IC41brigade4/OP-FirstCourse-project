namespace reservepp {
    class Conscript : User, ConscriptInterface
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
}