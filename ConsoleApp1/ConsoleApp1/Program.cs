using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

             //Hello world
             Console.WriteLine("Hello World!");

            //Arrays
             int[] evenNums = new int[5] { 2,4, 6, 8,10 };
             string[] cities = new string[3] { "Mumbai", "London", "Delhi" };

             int[] oddNums = { 1, 3, 5, 7, 9 };
             string[] name = { "hi", "bye" };

             for (int i = 0; i < oddNums.Length; i++)
                 Console.Write(oddNums[i]+" ");

             for (int i = 0; i < evenNums.Length; i++)
                 Console.WriteLine(evenNums[i]);

             foreach (var item in evenNums)
                 Console.WriteLine(item);

             foreach (var item in cities)
                 Console.WriteLine(item);

             int[] ar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

             for(int i=0;i<ar.Length;i++)
             {
                 if (ar[i] % 2 == 0)
                     Console.WriteLine(ar[i] + " is even");
                 else
                     Console.WriteLine(ar[i] + " is odd");


             }

             Console.WriteLine(string.Format("{0} got its independence in {1}", "India", "1947"));


            //ArrayList
             var arrlist1 = new ArrayList();
             arrlist1.Add(1);
             arrlist1.Add("Delhi");
             arrlist1.Add(" ");
             arrlist1.Add(true);
             arrlist1.Add(6.4);
             arrlist1.Add(null);

             foreach(var item in arrlist1)
             {
                 Console.WriteLine(item);
             }
             for (int i = 0; i < arrlist1.Count; i++)
                 Console.Write(arrlist1[i] + ", ");

             ArrayList arrlist2 = new ArrayList()
             {
                 1,
                 "Bill",
                 300,
                 4.5f
             };
             foreach (var item in arrlist2)
             {
                 Console.WriteLine(item);
             }

             arrlist2.Insert(1, "Second item");
             foreach (var item in arrlist2)
             {
                 Console.WriteLine(item);
             }

             ArrayList arrlist3 = new ArrayList()
             {
                 100,200,600
             };
             ArrayList arrlist4 = new ArrayList()
             {
                 300,400,500
             };

             arrlist3.InsertRange(2, arrlist4);
             foreach (var item in arrlist3)
             {
                 Console.WriteLine(item);
             }
             Console.WriteLine("");
             ArrayList arrlist5 = new ArrayList()
             {
                 1,
                 null,
                 "bill",
                 300,
                 " ",
                 4.5f,
                 300,
              };
             arrlist5.Remove(300);
             arrlist5.RemoveAt(4);
             arrlist5.RemoveRange(0, 2);

             foreach (var item in arrlist5)
             {
                 Console.WriteLine(item);
             }
            

            //List
            List<int> pn = new List<int>();
            pn.Add(2);
            pn.Add(3);
            pn.Add(5);
            pn.Add(7);

            foreach (var item in pn)
                Console.WriteLine(item);

            var city = new List<string>();
            city.Add("Mumbai");
            city.Add("Delhi");
            city.Add("London");
            city.Add("Chennai");

            foreach (var item in city)
                Console.WriteLine(item);

            var bigcity = new List<string>()
            {
                "Mumbai",
                "Delhi",
                "London",
                "Chicago"
            };

            foreach (var item in bigcity)
                Console.WriteLine(item);

            Console.WriteLine(" ");

            string[] c = new string[3] { "mumbai", "Chennai", "Kolkata" };

            var popcity = new List<String>() { "Kwala lampur" };
            popcity.AddRange(c);

            foreach (var item in popcity)
                Console.WriteLine(item);


            Console.WriteLine("");

            var num = new List<int>() { 10, 20, 30, 40 };
            num.Insert(1, 11);

            foreach (var item in num)
                Console.Write(item + " ");

            Console.WriteLine("");
           
            num.Remove(10);
            num.RemoveAt(2);

            foreach (var item in num)
                Console.Write(item + " ");

            

            
            int a;
            a = Convert.ToInt32(Console.ReadLine());
            int f = -1;

            List<int> numarr = new List<int>(){ 11, 22, 33, 44, 55, 66,22};
            
            for(int i=0;i<numarr.Count;i++)
            {
                if (a==numarr[i])
                {
                    f = i;
                   break;
                }
               
                   
            }
            if (f>=0)
                Console.Write("Found at " + (f+1));
           
           else
                Console.Write("Not Found");
            

            //Stack
            Stack<int> s = new Stack<int>();
            s.Push(1);
            s.Push(2);
            s.Push(3);
            s.Push(4);

            foreach (var item in s)
                Console.WriteLine(item + ", ");

            Console.WriteLine(s.Peek());
            while (s.Count > 0)
                Console.Write(s.Pop() + ", ");
            Console.Write("Number of elements in Stack: {0}", s.Count);

           
            //Queue
            Queue<int> callerid = new Queue<int>();
            callerid.Enqueue(1);
            callerid.Enqueue(2);
            callerid.Enqueue(3);
            callerid.Enqueue(4);

            Console.WriteLine("Displaying queue");
            foreach (var id in callerid)
                Console.WriteLine(id+" ");


            Console.WriteLine("Peeking");
            Console.WriteLine(callerid.Peek());
            Console.WriteLine("Dequeuing");


            while (callerid.Count > 0)
                Console.WriteLine(callerid.Dequeue());

            Console.WriteLine("Total elements after dequeue: {0}", callerid.Count);



        }


    }
}
