using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication34.Models
{
    public class Employee : IEmployee
    {
        public string EmpName { get; }
         
        public Employee()
        {
            EmpName = Guid.NewGuid().ToString();

        }
        public string GetName()
        {
            return EmpName;
            
        }
    }
}
