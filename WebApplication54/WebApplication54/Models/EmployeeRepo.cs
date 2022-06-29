using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication54.Models
{
    public class EmployeeRepo : IEmployee
    {
        List<Employee> EmpList;
        public List<Employee> AddEmp()
        {
            EmpList = new List<Employee>()
            { new Employee(){EmpName="Iron Man",EmpDept="Avengers",EmpAddress="Ney York",EmpPhNo=11323},
              new Employee(){EmpName="Captain America",EmpDept="Avengers",EmpAddress="Ney York",EmpPhNo=11323},
              new Employee(){EmpName="Thor",EmpDept="Avengers",EmpAddress="Asguarg",EmpPhNo=11323}
           


            };
            return EmpList;
        }
    }
}
