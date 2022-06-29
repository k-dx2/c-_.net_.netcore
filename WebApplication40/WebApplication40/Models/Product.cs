using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication40.Models
{
    public class Product
    {   [Key]
        public int ProdID {get; set; }
        public string ProdName { get; set; }
        public string ProdCat { get; set; }
        public double ProdPrice { get; set; }

        public Order Order;

    }
}
