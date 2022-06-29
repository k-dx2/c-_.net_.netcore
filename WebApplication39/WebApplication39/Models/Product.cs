using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication39.Models
{
    public class Product
    {
        [Key]
        public int ProdId { get; set; }
        public string ProdName { get; set; }
        public string ProdCat { get; set; }
        public double ProdPrice { get; set; }
        public Order Order { get; set; }

    }
}
