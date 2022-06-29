using System;

namespace ConsoleApp13
{
    class Program
    {   
        static void Incrementval(int i)
        {
            i = i + 1;
            Console.WriteLine("value of i : " + i);

        }
        static void Incrementref(ref int j)
        {
            j= j + 1;
            Console.WriteLine("value of j : " + j);
        }
        static void Main(string[] args)
        {
            //Value type
            int x = 1;
            Incrementval(x);
            Console.WriteLine("value of x : "+x);

            //reference type or Converting value type eto reference type
            int y = 1;
            Incrementref(ref y);
            Console.WriteLine("value of y : " + y);

        }


    }
}
