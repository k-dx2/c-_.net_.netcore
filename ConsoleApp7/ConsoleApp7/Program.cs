using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {   
            int a;

            int sum = 0;
            double avg = 0;
            Console.WriteLine("Entre 10 values");
            for (int i=0;i<10;i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                sum += a;
            }
            avg = sum / 10.0;
            Console.WriteLine("Sum is :" + sum);
            Console.WriteLine("Average is :" + avg);
            

            int b;
            Console.WriteLine("Entre a value");
            b = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= b; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write(j);
                Console.WriteLine();
            }

            
            int c;
            int f=0;
            int l;
            int rem=0;
            Console.WriteLine("Entre  a Value ");
            c = Convert.ToInt32(Console.ReadLine());
            f = c % 10;

            while(c!=0)
            {
                rem = c % 10;
                c = c / 10;
            }
            l = rem;

            Console.WriteLine("First digit " + l);
            Console.WriteLine("Last digit " + f);
         
            
        }
    }
}
