using System;
using System.Collections;

namespace ConsoleApp30
{
    class Program
    {
        public static A Add<A>(ref A num1, ref A num2)
            {
           
            dynamic a = num1;
            dynamic b = num2;

            return a + b;

            }
        static void Main(string[] args)
        {
            int i1, i2,res1;
            float f1, f2,res2;
            double d1, d2,res3;

            Console.WriteLine("Entre 2 Integers");
            i1 = Convert.ToInt32(Console.ReadLine());
            i2 = Convert.ToInt32(Console.ReadLine());

            res1 = Add<int>(ref i1, ref i2);
            Console.WriteLine("Result is : " + res1);


           
            Console.WriteLine("Entre 2 Floats");
            f1 = Convert.ToSingle(Console.ReadLine());
            f2 = Convert.ToSingle(Console.ReadLine());

            res2 = Add<float>(ref f1, ref f2);
            Console.WriteLine("Result is : " + res2);


            Console.WriteLine("Entre 2 Doubles");
            d1 = Convert.ToDouble(Console.ReadLine());
            d2 = Convert.ToDouble(Console.ReadLine());

            res3= Add<double>(ref d1, ref d2);
            Console.WriteLine("Result is : " + res3);



        }
    }
}
