using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication29.Models
{
    public class ProductRepository : IProductRepository
    {
        private List<Product> ProdList= new List<Product>();
        private int _nextId = 1;
       
        public ProductRepository()
        {
            AddProduct(new Product() { Name="Tomato Soup",Category="Groceries",Price=1.39M});
            AddProduct(new Product() { Name = "Yo-yo", Category = "Toys", Price = 3.75M });
            AddProduct(new Product() { Name = "Hammer", Category = "Hardwares", Price = 16.99M });


        }
        public IEnumerable<Product> GetAllProduct()
        {
            return ProdList;
        }
        public Product AddProduct(Product item)
        {
            if(item==null)
            {
                throw new ArgumentNullException("item");

            }
            item.Id = _nextId++;
            ProdList.Add(item);
            return item;

        }

        public Product GetProduct(int id)
        {
            return ProdList.Find(p => p.Id == id);
        }

        

        public void RemoveProduct(int id)
        {
            ProdList.RemoveAll(p => p.Id == id);
        }

        public bool UpdateProduct(Product item)
        {
            if(item ==null)
            {
                throw new ArgumentNullException("item");
            }
            int index = ProdList.FindIndex(p => p.Id == item.Id);
            if (index == -1)
                return false;
            ProdList.RemoveAt(index);
            ProdList.Add(item);
            return true;

        }
    }
}
