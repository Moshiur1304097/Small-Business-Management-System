﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfinityDotCom.Models.Models
{
    public class Category
    {
        public int ID { get; set; }

        public string CategoryCode { get; set; }

        public string CategoryName { get; set; }
    }
}
