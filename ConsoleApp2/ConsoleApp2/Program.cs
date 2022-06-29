using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Debugging
            // mark the red points on the gray panel on the left side
            // run the prog with f5
            // to execute a particular line press f10
            // to make an execution of a line again drag the arrow on left to that particular line
            /*
            int a;
            int b;

            a = 2;
            b = 3;

            int c = a + b;

            Console.WriteLine("Hello World!");


            Console.WriteLine("What's your name");
            string name = Console.ReadLine();

            Console.WriteLine("How much do you sleep last night?");
            int hour = Convert.ToInt32(Console.ReadLine());

            if (hour >= 8)
                Console.WriteLine("You must be energetic");
            else
                Console.WriteLine("You must be tierd");
            

            //if else

            int num = Convert.ToInt32(Console.ReadLine());

            if (num < 20)
                Console.WriteLine("{0} is less than 20", num);
            else
                Console.WriteLine("{0} is greater than 20", num);

            Console.WriteLine("{0} is your number", num);

            */

            /*
            // == operator
            Console.WriteLine("Please entre a Number");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number == 10)
                Console.WriteLine("it is equal to 10");
            else if(number==20)
                Console.WriteLine("it is equal to 20");

            else if(number==30)
                Console.WriteLine("it is equal to 30");

            else
                Console.WriteLine("it is different");


            */
            /*
            //Calculator
            Console.WriteLine("Entre 2 numbers");

            int num1= Convert.ToInt32(Console.ReadLine());
            int num2= Convert.ToInt32(Console.ReadLine());
            string operation;
            int res;

            Console.WriteLine("Entre the operation");
            operation = Console.ReadLine();

            Console.Write("The result of ");

            if (operation == "Add")
            {
                res = num1 + num2;
                Console.Write("Addition is \n"+res);
            }
            else if (operation == "Sub")
            {
                res = num1 - num2;
                Console.Write("Subtraction is \n"+res);
            }
            else if (operation == "Mul")
            {
                res = num1 * num2;
                Console.Write("Multiplication is \n"+res);
            }
            else if (operation == "Div")
            {
                res = num1 / num2;
                Console.Write("Division is \n"+res);
            }
            else
                Console.WriteLine("Wrong operation");

            */

            /*
            //logical operator
            int a = 1;
            int b = 3;

            if (!(a == 1 && b == 2))
                Console.WriteLine(true);
            if (a == 1||b==2)
                Console.WriteLine(true);

            */

            //Classes and methods
            Student s1 = new Student();
            s1.RollNo = 101;
            s1.FirstName = "Kunal";
            s1.LastName = "Dekate";
            s1.Location = "Nagpur";
            Student s2 = new Student();
            s2.RollNo = 102;
            s2.FirstName = "iron";
            s2.LastName = "man";
            s2.Location = "Ny";

            //Add the student in college
            College cllg = new College();
            cllg.AddStudent(s1);
            cllg.AddStudent(s2);

            //Verify whether added or not
            List<Student> list1 = cllg.GetStudents();

            foreach (var item in list1)
            {
                Console.WriteLine(item.RollNo);
                Console.WriteLine(item.FirstName);
                Console.WriteLine(item.LastName);
                Console.WriteLine(item.Location);
            }
        }
    }
}
