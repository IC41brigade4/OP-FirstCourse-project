using System.Collections.Generic;
namespace reservepp
{
    public interface IOfficer
    {
        void makeOffer(int amount);
        void returnSoldier(int docID);
        void returnSoldiers(List<int> docsID);
        void displayInfo();
    }
}