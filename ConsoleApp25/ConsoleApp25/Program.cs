using System;

namespace ConsoleApp25
{   
    abstract class AbsClass
    {
        //A Non abstract method
        public int AddTwoNumbers(int Num1,int Num2)
        {
            return Num1 + Num2;
        }

        //An abstract method, to be overriden in derived class
        public abstract int MultiplyTwoNumbers(int Num1, int Num2);
    }

    //A child class of AbsClass

    class AbsDerived :AbsClass
    {
        //using overrride keyword, implementing the abstract method- MultiplyTwoNumbers
        public override int MultiplyTwoNumbers(int Num1, int Num2)
        {
            return Num1 * Num2;

            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AbsDerived C1 = new AbsDerived();
            int res1 = C1.AddTwoNumbers(10, 20);
            int res2 = C1.MultiplyTwoNumbers(10, 20);
            Console.WriteLine("Add {0}, Multiply {1}", res1, res2); 
        }
    }
}
