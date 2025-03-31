using System.Collections.Generic;
namespace reservepp
{
    public class Officer : User, IOfficer
    {
        public Officer(string firstName, string lastName, int age, int docID, string medicalExaminationResult,
                bool HasDeferment, string city, string password)
            : base(firstName, lastName, age, docID, medicalExaminationResult, HasDeferment, city, password) { }

        public void makeOffer(int amount)
        {

        }
        public void returnSoldier(int docID)
        {

        }
        public void returnSoldiers(List<int> docsID)
        {

        }

        public override void displayInfo()
        {
            
        }
    }
}
