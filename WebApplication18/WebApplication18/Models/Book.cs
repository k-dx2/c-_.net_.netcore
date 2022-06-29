using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication18.Models
{
    public class Book
    {   
        public string BookId { get; set; }
        public string BookName { get; set; }
        public string BookWriter { get; set; }
        public string BookPublisher { get; set; }
        public double BookPrice { get; set; }
    }
}