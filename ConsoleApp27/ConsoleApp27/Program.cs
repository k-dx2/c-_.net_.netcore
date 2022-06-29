using System;

namespace ConsoleApp27
{   
    public class Calci
    {
        public int number { get; set; } //or public int number=0;

        public Calci()
        {

        }
        public Calci(int n)
        {
            number = n;
        }

        public static Calci operator +(Calci c1,Calci c2)
        {
            Calci c3 = new Calci(0);
            c3.number = c1.number + c2.number;

            return c3;
        }

        public static Calci operator -(Calci c1, Calci c2)
        {
            Calci c3 = new Calci(0);
            c3.number = c1.number - c2.number;

            return c3;
        }

        public static Calci operator /(Calci c1, Calci c2)
        {
            Calci c3 = new Calci(0);
            try
            {
                c3.number = c1.number/c2.number;

            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine(e);
            }
          
            return c3;


        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Calci C1 = new Calci(100);
            Calci C2 = new Calci(20);
            Calci C3 = C1 + C2;
            Console.WriteLine("ADD : "+C3.number);
            Calci C4 = C1 - C2;
            Console.WriteLine("SUB :"+C4.number);
            Calci C5 = C1 / C2;
            Console.WriteLine("DIVIDE : "+C5.number);

        }
    }
}
