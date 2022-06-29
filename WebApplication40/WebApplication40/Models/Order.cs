using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication40.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public string OrderAddress { get; set; }
        public string OrderPay { get; set; }
        public DateTime OrderDelDate { get; set; }
        ICollection<Product> product;
    }
}
