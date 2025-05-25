using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reservepp
{
    public class OrderDto
    {
        public int Id { get; set; } // Auto-increment primary key
        public int DocID { get; set; }
        public int OrderNum { get; set; }
        public string OrderText { get; set; }
        public string Status { get; set; }
    }
}
