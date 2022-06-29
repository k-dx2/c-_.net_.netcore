using System;

namespace ConsoleApp9
{   
    public class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal Constructor ");
        }
        public void greet()
        {
            Console.WriteLine("Animal says Hello ");
        }
         public void talk()
        {
            Console.WriteLine("Animal talks ");
        }
        public virtual void sing()
        {
            Console.WriteLine("Animal sings ");
        }

    }
    public class Dog:Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog Constructor ");
        }
        public new void  talk()
        {
            Console.WriteLine("Dog talks ");

        }
        public override void sing()
        {
            Console.WriteLine("Dog sings ");
        }
    }


    //Polymorphism
    public class Account
    {
        private static double balance;
        public static double GetBalance()
        {
            return balance;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            
            Animal a1 = new Animal();
            a1.greet();
            a1.talk();
            a1.sing();

            Console.WriteLine();
            Dog d1 = new Dog();
            d1.greet();
            d1.talk();
            d1.sing();


            Console.WriteLine();
            Animal a2 = new Dog();
            a2.greet();
            a2.talk();
            a2.sing();

            Account a = new Account();
            double balance =Account.GetBalance();


            //Account.balance = 233422343242;  //error
           // a.balance = 2323232323;     //error
           
            


        }


    }
}
