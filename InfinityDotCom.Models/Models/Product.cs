using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace InfinityDotCom.Models.Models
{
    public class Product
    {
        public int ID { get; set; }
        [Required]
        public string ProductCode { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int ProductROL { get; set; }
        public string ProductDescription { get; set; }
        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }

    }
}
