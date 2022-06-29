using System;

namespace ConsoleApp33
{
    
    class Program
    {
        static void Show<T>(ref T A)
        {
            Console.WriteLine("The value : "+A);
        }
        static void Main(string[] args)
        {
            dynamic t;
            Console.WriteLine("Enter a Value");
            t = Console.ReadLine();
            Show<dynamic>(ref t);



            
        }
    }
}
