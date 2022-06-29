using System;

namespace ConsoleApp12
{   

    class Example
    {
        public int value { get; set; }

        public Example(int PassbyRef)
        {
            this.value = PassbyRef;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {   
            //Reference type
            Example E1 = new Example(12);
            Example E2 = new Example(22);

            Console.WriteLine(E1.value);
            Console.WriteLine(E2.value);

            Console.WriteLine();

            Example E3 = new Example(10);
            Example E4= new Example(20);

            E4 = E3;
            Console.WriteLine(E3.value);
            Console.WriteLine(E4.value);
            Console.WriteLine();

            E3.value = 100;
            Console.WriteLine(E3.value);
            Console.WriteLine(E4.value);
            Console.WriteLine();


            //Value Type
            int x1 = 4;
            int x2 = 10;

            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine();

            x2 = x1;
            Console.WriteLine(x1);
            Console.WriteLine(x2);
            Console.WriteLine();

            x1 = 23;
            Console.WriteLine(x1);
            Console.WriteLine(x2);






        }
    }
}
