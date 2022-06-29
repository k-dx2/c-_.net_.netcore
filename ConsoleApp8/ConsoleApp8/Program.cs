using System;

namespace ConsoleApp8
{
    public class Employee
    {
        public float salary = 50000;
    }
    public class Developer:Employee
    {
        public float bonus = 15000;
    }

    public class Animal
    {
        public void eat()
        {
            Console.WriteLine("Eating");
        }
    }

    public class Dog:Animal
    {
        public void bark()
        {
            Console.WriteLine("Barking");

        }
    }

    public class Pug : Dog
    {
        public void smile()
        {
            Console.WriteLine("smiling");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //inheritance of variables
            Developer d = new Developer();
            Console.WriteLine("Salary " + d.salary);
            Console.WriteLine("Bonus " + d.bonus);

            //inheritance of methods including multilevel inheritance
            Pug bruno = new Pug();
            bruno.eat();
            bruno.bark();
            bruno.smile();

        }
    }
}
