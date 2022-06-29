using System;

namespace ConsoleApp15
{
    class Program
    {
        enum Days { Sun, Mon, Tue, Wed, Thu, Fri, Sat };
        enum Month { jan=10, feb, mar, apr, may=20, jun, jul, aug, sept, oct, nov, dec }
        static void Main(string[] args)
        {
            //string manipulation
            string fname, lname;
            fname = "Kunal";
            lname = "Dekate";

            string fullname = fname + lname;
            Console.WriteLine("Full name {0}", fullname);

            char[] letters = { 'W', 'o', 'r', 'l', 'd' };
            string[] sarray = { "Hello", "from", "Mark", "John" };

            string welcome = new string(letters);
            Console.WriteLine("Message: {0} {1}", welcome, "Hello");

            string message = String.Join(" ", sarray);
            Console.WriteLine("Message: {0}", message);

            //formatting method to convert a value
            DateTime dt = new DateTime(2020, 10, 10, 17, 23, 35);
            string chat = String.Format("Message sent at {0:t} on {0:D}", dt);
            Console.WriteLine("Message: {0}", chat);

            //enum
            int Monday = (int)Days.Mon;
            int Friday = (int)Days.Fri;
    
            Console.WriteLine("Monday {0}",Monday);
            Console.WriteLine("Friday {0}",Friday);
              

            int apr = (int)Month.apr;
            int jul = (int)Month.jul;

            Console.WriteLine("April {0}", apr);
            Console.WriteLine("July {0}", jul);





        }
    }
}
