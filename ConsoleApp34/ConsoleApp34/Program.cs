using System;

namespace ConsoleApp34
{   

    public static class ExtensionMethod
    {
        public static bool IsEqualTo(this int i,int value)
        {
            return i == value;
        }
        public static bool IsGreaterThan(this int i,int val)
        {
            return i > val;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int i = 20;
            bool result1;
            result1 = i.IsEqualTo(400);
            Console.WriteLine(result1);

            int j = 10;
            int k;
            bool result2;
            Console.WriteLine("Enter a value");
            k = Convert.ToInt32(Console.ReadLine());
            result2 = j.IsGreaterThan(k);
            Console.WriteLine(result2);

        }
    }
}
