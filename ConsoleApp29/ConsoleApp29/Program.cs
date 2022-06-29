using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Swap<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;


        }
        static void Main(string[] args)
        {
            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'I';
            d = 'K';
            Console.WriteLine("Values of Int before Swapping");
            Console.WriteLine("a: " + a + " b: " + b);
            Console.WriteLine("Values of Char before Swapping");
            Console.WriteLine("c: " + c + " d: " + d);

            Swap<int>(ref a, ref b);
            Swap<Char>(ref c, ref d);
            Console.WriteLine("Values of Int after Swapping");
            Console.WriteLine("a: " + a + " b: " + b);
            Console.WriteLine("Values of Char after Swapping");
            Console.WriteLine("c: " + c + " d: " + d);



        }
    }
}
