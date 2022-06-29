using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication17.Models
{
    public class Product
    {
        public string ProdId { get; set; }
        public string ProdName { get; set; }

        public string ProdCat { get; set; }
        public DateTime ProdMfd { get; set; }
    }
}