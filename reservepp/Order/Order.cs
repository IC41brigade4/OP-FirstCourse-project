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
        private int docID, orderNum;
        private string orderText, status;

        public Order(int docID, int orderNum, string orderText, string status)
        {
            this.docID = docID;
            this.status = status;
            this.orderText = orderText;
            this.orderNum = orderNum;
        }

        public int DocID { get => docID; set => docID = value; }
        public int OrderNum { get => orderNum; set => orderNum = value; }
        public string OrderText { get => orderText; set => orderText = value; }
        public string Status { get => status; set => status = value; }

        public string GetData()
        {
            return $"DocID:{DocID}, orderNum{OrderNum}, OrderText{OrderText}, Status{Status}";
        }
    }
}
