using System;

namespace ConsoleApp32
{
    public class Employee
    {
        public double EmpSal { get; set;}

        public static Employee operator > (Employee e1,Employee e2 )
        {
            if(e1.EmpSal>e2.EmpSal)
            {
                return e1;
            }
            return e2 ;
           
        }
        
        public static Employee operator < (Employee e1, Employee e2)
        {
            if (e1.EmpSal < e2.EmpSal)
            {
                return e2;
            }
            return e1;
        }
        
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee A = new Employee();
            Employee B= new Employee();
            Employee Res=new Employee();
         
            Console.WriteLine("Entre the Salary of 1st Employee");
            A.EmpSal = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Entre the Salary of 2nd Employee");
            B.EmpSal = Convert.ToDouble(Console.ReadLine());

            Res = A > B;
            Console.WriteLine("Higher Salary is {0} ",Res.EmpSal);


        }
    }
}
