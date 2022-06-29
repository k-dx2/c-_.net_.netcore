using System;

namespace ConsoleApp14
{
    class Program
    {
        public static void Swap(ref int a, ref int b )
        {
            int t = a;
            a = b;
            b = t;
        }
 
        static void Main(string[] args)
        {
            
            //1st
            // Reversing a string
            string s,revs="";
            

            Console.WriteLine("Entre a string");
            s = Console.ReadLine();
            char[] rev = new char[s.Length];


            for (int i = 0; i < s.Length; i++)
            {
                rev[i] = s[s.Length - 1 - i];
                revs = revs + s[s.Length - 1 - i];
            }

            Console.WriteLine("Reversed String : ");
            for (int i = 0; i < s.Length; i++)
                Console.Write(rev[i]);

            Console.WriteLine(revs);
            Console.WriteLine();
            
            //2nd and 5th
            // Reversing array and counting the numer of elements greater than 15
            int n, count = 0;
            Console.WriteLine("Entre the Size of array");
            n = Convert.ToInt32(Console.ReadLine());
            int[] Arr = new int[n];

            Console.WriteLine("Entre the of array");
            for (int i = 0; i < n; i++)
                Arr[i] = Convert.ToInt32(Console.ReadLine());

            for(int start=0,end=n-1; start<=end;start++,end--)
            {
                Swap(ref Arr[start], ref Arr[end]);
            }

            for (int i = 0; i < n; i++)
                if (Arr[i] > 15)
                    count++;
            Console.WriteLine("The Count is : " + count);

            Console.WriteLine("The Reversed Array is : " + count);
            for (int i = 0; i < n; i++)
                Console.WriteLine(Arr[i]);

            Console.WriteLine();

            //3rd
            //Spliting the name into first and last name
            string name,fn,ln;
            Console.WriteLine("Entre the name");
            name = Console.ReadLine();
            Console.WriteLine("The result is");

            string[] sub = name.Split(' ');
            fn = sub[0];
            ln = sub[1];
            Console.WriteLine(ln+" "+fn);

            
            //4th
            //converting the phoen number into code and number
            string phoneno,code,no;
            Console.WriteLine("Entre phone number ");
            phoneno = Console.ReadLine();
            code = phoneno.Substring(0,3);
            no= phoneno.Substring(3,10);
            Console.WriteLine("The result is");
            Console.WriteLine(code+" "+no);








        }
    }
}
