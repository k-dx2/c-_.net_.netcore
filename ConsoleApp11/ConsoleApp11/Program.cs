using System;

namespace ConsoleApp11
{

    class Department
    {
        public Department()
        {
            Console.WriteLine("Department Constructor called");
        }
        public string GetDeptName()
        {
            return "This is CSE Deartment";
        }

        public int GetDeptStaff()
        {
            return 25;
        }
        public virtual int GetNumofCoures()
        {
            return 5;
        }


    }

    class Employee:Department
    {
        public Employee()
        {
            Console.WriteLine("Employee constructor");
        }

        public int NumofEmployee()
        {
            return 25;
        }

        public new int GetDeptStaff()
        {
            return 50;
        }
        public override int GetNumofCoures()
        {
            return 10;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Department D1 = new Department();
            Console.WriteLine(D1.GetDeptName());
            Console.WriteLine(D1.GetDeptStaff());
            Console.WriteLine(D1.GetNumofCoures());

            Console.WriteLine();
            Employee E1 = new Employee();
            Console.WriteLine(E1.NumofEmployee());
            Console.WriteLine(E1.GetDeptStaff());
            Console.WriteLine(E1.GetNumofCoures());

            Console.WriteLine();
            Department D2 = new Employee();
            // Console.WriteLine(D2.NumofEmployee);  //error
            Console.WriteLine(D2.GetDeptName());
            Console.WriteLine(D2.GetDeptStaff());
            Console.WriteLine(D2.GetNumofCoures());

            Console.WriteLine();

            //Employee E2 = new Department();    //error




        }
    }
}
