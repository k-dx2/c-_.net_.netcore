using System;

namespace ConsoleApp35
{
    public static class ExtensionMethod
     {
        public static int CountBs(this string s)
        {
            int count = 0;
            for(int i=0;i<s.Length;i++)
            {
                if (s[i] == 'b' || s[i] == 'B')
                    count++;
            }
            return count;
        }
     }

    class Program
    {
        static void Main(string[] args)
        {
            string s;
            int c = 0;
            Console.WriteLine("Entre a word");
            s = Console.ReadLine();
            c = s.CountBs();
            Console.WriteLine("Number of B's " + c);

        }
    }
}
