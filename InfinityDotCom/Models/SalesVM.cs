using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InfinityDotCom.Models.Models;

namespace InfinityDotCom.Models
{
    public class SalesVM
    {
        public List<Customer> Customers { get; set; }
        public List<Product> Products { get; set; }
        public List<SalesProduct> SalesProducts { get; set; }
    }
}