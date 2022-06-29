using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            //While loop
            int i = 10;
            while(i<20)
            {
                Console.WriteLine("Value of i : {0}", i);
                i++;
            }

            //For loop
            Console.WriteLine("Value of j ");
            for(int j=0;j<10;j++)
                Console.Write(j+" ");

            
            //Do while loop
            int a = 10;
            do
            {
                Console.Write(a + " ");
                a++;


            } while (a < 20);

            Console.WriteLine();
            //Continue
            int b = 20;
            do
            {
                if(b==25)
                {
                    b = b + 1;
                    continue;
                }
                Console.Write(b + " ");
                b++;


            } while (b < 30);

            Console.WriteLine();

            //break
            int c = 10;
            while(c<20)
            {
                Console.WriteLine("value of c:{0}", c);
               
                if (c > 15)
                    break;

                c++;
            }
        }
    }
}
