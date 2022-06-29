using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication53.Models
{
    public class Product
    {
        public string ProdId { get; set; }
        public string  ProdName { get; set; }
        public string ProdCategory { get; set; }
        public DateTime ProdMfDate { get; set; }
        public DateTime ProdExpDate { get; set; }
    }
}
