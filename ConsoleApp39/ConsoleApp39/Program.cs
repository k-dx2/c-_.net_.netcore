using System;

namespace ConsoleApp39
{
    public class Department
    {
        public Department()
        {
            Console.WriteLine("This is Deparment class");
        }
        public void Func1()
        {
            Console.WriteLine("this is Func1 of Department");
        }

        public virtual void Func2()
        {
            Console.WriteLine("this is Func2 of Department");
        }
    }

    public class Employee:Department
    {
        public Employee()
        {
            Console.WriteLine("This is Employee Class");
        }
        public new void Func1()
        {
            Console.WriteLine("this is Func1 of Employee");
        }

        public override void Func2()
        {
            Console.WriteLine("this is Func2 of Employee");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Department d1=new Department();
            d1.Func1();
            d1.Func2();
            Console.WriteLine();

            Employee e1 = new Employee();
            e1.Func1();
            e1.Func2();
            Console.WriteLine();

            Department d2 = new Employee();
            d2.Func1();
            d2.Func2();


        }
    }
}
