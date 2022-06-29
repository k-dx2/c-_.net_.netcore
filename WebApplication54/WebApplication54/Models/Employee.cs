using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication54.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }
        public string EmpName { get; set; }
        public string EmpDept { get; set; }
        public string EmpAddress { get; set; }
        public int  EmpPhNo { get; set; }

    }
}
