using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {   
            //1st
            string sentence = "She sells Sea Shells on the Sea shore";
            int n = sentence.Length;
            int countwords= 0,countletters=0;
            for (int i = 0; i < n; i++)
            {
                if (sentence[i] == ' ')
                {
                    countwords++;

                }
                countletters++;
            }
            Console.WriteLine("Number of Words {0}", countwords + 1);
            Console.WriteLine("Number of letters {0}", countletters-countwords);
            Console.WriteLine();

            //2nd
            string s1, s2;
            Console.WriteLine("Enter 1st string");
            s1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd string");
            s2 = Console.ReadLine();

            if (s1.ToUpper() == s2.ToUpper())
                Console.WriteLine("Strings are Same");
            else
                Console.WriteLine("Strings are Different");

            Console.WriteLine();

            //3rd
            Console.WriteLine("Enter a string");
            string name = Console.ReadLine();
            if(name[name.Length-1]=='a'||name[name.Length-1]=='A')
                Console.WriteLine("String ends with A");
            else
                Console.WriteLine("String doesn't ends with A");
            Console.WriteLine();


            //4th 
            string x1,x2,concat;
            Console.WriteLine("Enter 1st string");
            x1 = Console.ReadLine();
            Console.WriteLine("Enter 2nd string");
            x2 = Console.ReadLine();
            concat = x1 + x2;
            Console.WriteLine("Result of concatenation");
            Console.WriteLine(concat);
            Console.WriteLine();

            //5th
            string s;
            Console.WriteLine("Enter a string");
            s = Console.ReadLine();
            int count = 0;
            for( char i='a';i<='z';i++)
            {
                count = 0;
                for (int j = 0; j < s.Length;j++)
                {
                    if (Char.ToLower(s[j])== i)
                        count++;

                }
                if (count >= 2)
                    Console.WriteLine(i + " : " + count);
            }






        }
    }
}
