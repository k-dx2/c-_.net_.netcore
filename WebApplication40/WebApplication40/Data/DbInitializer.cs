using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication40.Models;
namespace WebApplication40.Data
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
            new Order{OrderAddress="Delhi",OrderDate=DateTime.Parse("05-02-2021"),OrderDelDate=DateTime.Parse("15-01-2021"),OrderPay="Debit Card"},
            new Order{OrderAddress="Mumbai",OrderDate=DateTime.Parse("10-02-2021"),OrderDelDate=DateTime.Parse("20-01-2021"),OrderPay="Pay on Delivery" },
            new Order{OrderAddress="Pune",OrderDate=DateTime.Parse("15-02-2021"),OrderDelDate=DateTime.Parse("25-01-2021"),OrderPay="Credit Card"},
            new Order{OrderAddress="Kolkata",OrderDate=DateTime.Parse("20-02-2021"),OrderDelDate=DateTime.Parse("01-03-2021"),OrderPay="UPI"}

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
                new Product{ProdName="Iphone 12",ProdCat="SmartPhone",ProdPrice=399.99 },
                new Product{ProdName="Iphone 12 Charging Adapter",ProdCat="SmartPhone Accessories",ProdPrice=39.99 },
                new Product{ProdName="HP Omen",ProdCat="Laptop",ProdPrice=499.99 },
                new Product{ProdName="Boat Rockerz",ProdCat="Earphones",ProdPrice=49.99 },
                new Product{ProdName="Zebronics KeyBoard",ProdCat="Computer Accessories",ProdPrice=29.99 },
                new Product{ProdName="Zebronics Mouse",ProdCat="Computer Accessories",ProdPrice=29.99 }


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
