using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.RollNo = 12;
            s1.FirstName="Kunal";
            s1.LastName = "Dekate";
            s1.Subject = "Science";

            Student s2 = new Student() {RollNo=13, FirstName="Iron",LastName="Man",Subject="Science" };
            College c1 = new College();
            c1.AddStud(s1);
            c1.AddStud(s2);
            c1.AddStud(new Student() { RollNo = 14, FirstName = "Black", LastName = "Widow", Subject = "commerce" });

            List<Student> list1 = c1.getstud();

            foreach(var s in list1)
            {
                Console.WriteLine(s.RollNo);
                Console.WriteLine(s.FirstName);
                Console.WriteLine(s.LastName);
                Console.WriteLine(s.Subject);

            }

        }

    }
}
