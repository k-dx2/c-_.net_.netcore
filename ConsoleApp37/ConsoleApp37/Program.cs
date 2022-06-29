using System;
using System.Collections.Generic;

namespace ConsoleApp37
{
    class Program
    {   
        public static void Palindrome(string s)
        {
            int start = 0;
            bool flag = true;
            int end = s.Length - 1;
            while(start<=end)
            {
                if(s[start]!=s[end])
                {
                    flag = false;
                }
                start++;
                end--;
            }
            if (flag == true)
                Console.WriteLine("Palindrome");
            else
                Console.WriteLine("Not a Palindrome");
        }
        static void Main(string[] args)
        {
            string palin,low;
            Console.WriteLine("Entre a String");
            palin = Console.ReadLine();
            palin = palin.ToLower();
            Palindrome(palin);

            Console.WriteLine();

            int n;
            Console.WriteLine("Entre the number of elements");
            n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];
            for(int i=0;i<n;i++)
            {
                arr[i]= Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                arr[i] = arr[i]*arr[i];
            }
            Console.WriteLine("The new Array is");
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i]+" ");
            }

            Console.WriteLine();

            List < string > l= new List<string>();
            l.Add("John");
            l.Add("Mark");
            l.Add("King");
            l.Add("Enola");
            l.Add("joHn");
            l.Add("Tony");

            Console.WriteLine("Initial List");
            foreach (var i in l)
                Console.Write(i+" ");
            for (int i=0;i<l.Count;i++)
            {
                if(l[i].ToLower()=="john")
                {
                    l.RemoveAt(i);
                }
            }
            Console.WriteLine();
            Console.WriteLine("After Removing John");
            foreach (var i in l)
                Console.Write(i+" ");






        }
    }
}
