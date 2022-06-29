using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication39.Models;

namespace WebApplication39.Data
{
    public class DbInitializer
    {
        public static void Initialize(OrderContext context)
        {
            context.Database.EnsureCreated();

            // Look for any orders.
            if (context.Orders.Any())
            {
                return;   // DB has been seeded
            }

            var orders = new Order[]
            {
            new Order(){OAddrDetails="Delhi",ODate=DateTime.Parse("05-02-2021"),ODelDate=DateTime.Parse("15-01-2021"),OPayStat="Debit Card"},
            new Order(){OAddrDetails="Mumbai",ODate=DateTime.Parse("10-02-2021"),ODelDate=DateTime.Parse("20-01-2021"),OPayStat="Pay on Delivery" },
            new Order(){OAddrDetails="Pune",ODate=DateTime.Parse("15-02-2021"),ODelDate=DateTime.Parse("25-01-2021"),OPayStat="Credit Card"},
            new Order(){OAddrDetails="Kolkata",ODate=DateTime.Parse("20-02-2021"),ODelDate=DateTime.Parse("01-03-2021"),OPayStat="UPI"}

            };

            foreach (Order s in orders)
            {
                Console.WriteLine("Order okay");
                context.Orders.Add(s);
            }
            Console.WriteLine("Saving order okay");

            context.SaveChanges();

            var products = new Product[]
            {
                new Product(){ProdName="Iphone 12",ProdCat="SmartPhone",ProdPrice=399.99 },
                new Product(){ProdName="Iphone 12 Charging Adapter",ProdCat="SmartPhone Accessories",ProdPrice=39.99 },
                new Product(){ProdName="HP Omen",ProdCat="Laptop",ProdPrice=499.99 },
                new Product(){ProdName="Boat Rockerz",ProdCat="Earphones",ProdPrice=49.99 },
                new Product(){ProdName="Zebronics KeyBoard",ProdCat="Computer Accessories",ProdPrice=29.99 },
                new Product(){ProdName="Zebronics Mouse",ProdCat="Computer Accessories",ProdPrice=29.99 }


            };

            foreach (Product c in products)
            {
                Console.WriteLine("Product okay");

                context.Products.Add(c);
            }
            Console.WriteLine("saving product okay");

            context.SaveChanges();


        }

    }
}
