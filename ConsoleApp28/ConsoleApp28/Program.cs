using System;
using System.Collections;

namespace ConsoleApp28
{
    class Program
    {
       
        static void Main(string[] args)
        {
            //Hastable --- not sorted
            Hashtable ht = new Hashtable();
         

            ht.Add("001","Mark");
            ht.Add("002", "Luke");
            ht.Add("003", "John");
            ht.Add("004", "Peter");
            ht.Add("005", "Kunal");
            ht.Add("006", "Luis");
            ht.Add("007", "Imran");

            if(ht.ContainsValue("Max"))
            {
                Console.WriteLine("This Employeee exists in List");

            }
            else
            {
                ht.Add("008", "dfsf");
            }

            ICollection key = ht.Keys;
            foreach (string k in key)
                Console.WriteLine(k + " : " + ht[k]);

            Console.WriteLine();

            // Sorted List to get the key values in sorted order
            SortedList sl = new SortedList();

            sl.Add(1, "a");
            sl.Add(2, "b");
            sl.Add(3, "c");
            sl.Add(4, "d");
            sl.Add(6, "f");

            if (sl.ContainsValue("e"))
            {
                Console.WriteLine("This Employeee exists in List");

            }
            else
            {
                sl.Add(5, "e");
            }

            ICollection key2 = sl.Keys;
            foreach( int k in key2)
                Console.WriteLine(k + " : " + sl[k]);







        }
    }
}
