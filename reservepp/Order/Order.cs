using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace reservepp
{
    public class Order
    {
        public int OrderID { get; set; } 

        private int docID;
        private int orderNum;
        private string orderText;
        private string status;

        public Order() { }  

        public Order(int docID, int orderNum, string orderText, string status)
        {
            this.docID = docID;
            this.orderNum = orderNum;
            this.orderText = orderText;
            this.status = status;
        }

        public int DocID { get => docID; set => docID = value; }
        public int OrderNum { get => orderNum; set => orderNum = value; }
        public string OrderText { get => orderText; set => orderText = value; }
        public string Status { get => status; set => status = value; }

        public string GetData()
        {
            return $"OrderID: {OrderID}, DocID: {DocID}, OrderNum: {OrderNum}, OrderText: {OrderText}, Status: {Status}";
        }
    }
}
