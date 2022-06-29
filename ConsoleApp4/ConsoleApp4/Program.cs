using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Store");
            int choice;
            RetailStore r = new RetailStore();
            List<Product> list1 = new List<Product>();

            while (true)
            {
                Console.WriteLine("Menu");
                Console.WriteLine("1.Add Product");
                Console.WriteLine("2.Show Product");
                Console.WriteLine("3.Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                if(choice==1)
                {
                    Product p = new Product();
                    Console.WriteLine("Entre the Product ID");
                    p.Pid= Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Entre the Product Name");
                    p.Pname = Console.ReadLine();
                    Console.WriteLine("Entre the Product Type");
                    p.Type= Console.ReadLine();
                    Console.WriteLine("Entre the Product Expiry Date");
                    p.Expdate=Console.ReadLine();
                    Console.WriteLine("Entre the Product Price");
                    p.Pprice = Convert.ToInt32(Console.ReadLine());


                    r.AddProd(p);




                }
                else if(choice==2)
                {
                    list1=r.ShowProd();
                    foreach(var prod in list1)
                    {
                        Console.WriteLine(prod.Pid);
                        Console.WriteLine(prod.Pname);
                        Console.WriteLine(prod.Type);
                        Console.WriteLine(prod.Expdate);
                        Console.WriteLine(prod.Pprice);

                    }

                }
                else if(choice==3)
                {
                    break;
                }
                else
                    Console.WriteLine("Wrong choice");





            }

        }
    }
}
