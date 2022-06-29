using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication9.Models
{
    public class ProductClass
    {
        public string ProdId { get; set; }
        public string ProdName { get; set; }
        public string ProdCategory { get; set; }

        public DateTime ProdMfd { get; set; }
        public DateTime ProdExpd { get; set; }
    }
}