using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication39.Models
{
    public class Order
    {   
        [Key]
        public int OId { get; set; }
        public string OAddrDetails  { get; set; }
        public string OPayStat { get; set; }
        public DateTime ODate { get; set; }
        public DateTime ODelDate  { get; set; }
      
        ICollection<Product> Products { get; set; }
        
       

    }
}
