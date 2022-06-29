using System;

namespace ConsoleApp42
{
    public class Calculator
    {
        public int n1, n2;
        public int m1, m2, m3;
        public int k1, k2, k3,k4;
        public int Add(int a ,int b)
        {
            return a + b;
        }
        public int Add(int a,int b,int c)
        {
            return a + b + c;
        }

        public int Add(int a, int b, int c,int d)
        {
            return a + b + c + d;
        }

        public int Mul(int a, int b)
        {
            return a * b;
        }
        public int Mul(int a, int b, int c)
        {
            return a*b * c;
        }

        public int Mul(int a, int b, int c, int d)
        {
            return a *b *c * d;
        }
        public int Div(int a, int b)
        {
            return a/b;
        }
        public int Div(int a, int b, int c)
        {
            return (a/b ) /c;
        }

        public int Div(int a, int b, int c, int d)
        {
            return ((a /b )/ c )/ d;
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Calculator c = new Calculator();

            
            Console.WriteLine("Entre two Numbers");
            c.n1 = Convert.ToInt32(Console.ReadLine());
            c.n2= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition Result " + c.Add(c.n1, c.n2));
            Console.WriteLine("Multiplication Result " + c.Mul(c.n1, c.n2));
            Console.WriteLine("Divison Result " + c.Div(c.n1, c.n2));
            
            Console.WriteLine("Entre three Numbers");
            c.m1 = Convert.ToInt32(Console.ReadLine());
            c.m2 = Convert.ToInt32(Console.ReadLine());
            c.m3 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition Result " + c.Add(c.m1, c.m2,c.m3));
            Console.WriteLine("Multiplication Result " + c.Mul(c.m1, c.m2, c.m3));
            Console.WriteLine("Divison Result " + c.Div(c.m1, c.m2, c.m3));
            
            Console.WriteLine("Entre four Numbers");
            c.k1 = Convert.ToInt32(Console.ReadLine());
            c.k2 = Convert.ToInt32(Console.ReadLine());
            c.k3 = Convert.ToInt32(Console.ReadLine());
            c.k4 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Addition Result " + c.Add(c.k1, c.k2, c.k3,c.k4));
            Console.WriteLine("Multiplication Result " + c.Mul(c.k1, c.k2, c.k3, c.k4));
            Console.WriteLine("Divison Result " + c.Div(c.k1, c.k2, c.k3, c.k4));






        }
    }
}
