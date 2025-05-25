using System.ComponentModel.DataAnnotations;

namespace reservepp
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public int DocID { get; set; }
        public int OrderNum { get; set; }
        public string OrderText { get; set; }
        public string Status { get; set; }

        public string GetData()
        {
            return $"OrderID: {OrderID}, DocID: {DocID}, OrderNum: {OrderNum}, OrderText: {OrderText}, Status: {Status}";
        }
    }
}