using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfinityDotCom.Models.Models
{
    public class PurchaseProduct
    {
        public int ID { get; set; }
        public string InvoiceNo { get; set; }
        public string ProductCode { get; set; }
        public string ManufacturedDate { get; set; }
        public string ExpireDate { get; set; }
        public string Quantity { get; set; }
        public string UnitPrice { get; set; }
        public string TotalPrice { get; set; }
        public string NewMRP { get; set; }
        public string Remarks { get; set; }
        public int ProductID { get; set; }
        public Product Product { get; set; }
    }
}
