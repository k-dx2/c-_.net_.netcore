using System;

namespace ConsoleApp10
{   
    class FuncOver
    {
        public int Add(int a,  int b)
        {
            return a + b;
        }
        public int Add(int a, int b,int c)
        {
            return a + b + c;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            int res1, res2;
            FuncOver f = new FuncOver();

            res1=f.Add(4, 5);
            res2 = f.Add(2, 3, 5);

            Console.WriteLine(res1);
            Console.WriteLine(res2);

        }
    }
}
