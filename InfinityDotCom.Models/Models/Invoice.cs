using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfinityDotCom.Models.Models
{
    public class Invoice
    {
        public int InvoiceID { get; set; }
        public string InvoiceDate { get; set; }
        public string InvoiceNo { get; set; }
        public int SuppliedID { get; set; }
        public Supplier Supplier { get; set; }
    }
}
