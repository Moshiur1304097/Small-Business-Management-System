using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfinityDotCom.Models.Models
{
    public class SalesProduct
    {
        public int SalesProductID { get; set; }
        public string Date { get; set; }
        public string Quantity { get; set; }
        public string MRP { get; set; }
        public string Discount { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }

        public int CustomerID { get; set; }
        public Customer Customer { get; set; }
    }
}
