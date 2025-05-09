namespace reservepp
{
    class TCKEmployee : User, ITCKEmployee
    {
        private readonly UserService userService;
        public TCKEmployee(string firstName, string lastName, int age, int docID, string medicalExaminationResult,
                bool HasDeferment, string city, string password, string armyUnit, UserService userService)
            : base(firstName, lastName, age, docID, medicalExaminationResult,
                HasDeferment, city, password, armyUnit, userService)
        {
           
        }

        public void agreeOffer(int docID)
        {
            // Сюди прописати той функціонал, що має виконуватись у формі тцк по кнопці
        }

        
    }
}