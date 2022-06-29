using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication30.Models
{
    public class ProductRepo : IProductRepo
    {
        public static List<Product> ProdList;
        public int prodid;
       
        public ProductRepo()
        {
            prodid = 1;
            ProdList = new List<Product>();
            AddProd(new Product() { ProdName = "Iphone 12", ProdCategory = "Smartphone", ProdPrice = 499.99 });
            AddProd(new Product() { ProdName = "Samsung S21", ProdCategory = "Smartphone", ProdPrice = 599.99 });
            AddProd(new Product() { ProdName = "Iphone 12 Pro Max", ProdCategory = "Smartphone", ProdPrice = 699.99 });
        }
        public Product AddProd(Product item)
        {
            if(item==null)
            {
                
            }
            item.ProdId = prodid;
            ProdList.Add(item);
            prodid++;

            return item;

        }

        public void DelProd(int PId)
        {
            int index = ProdList.FindIndex(p => p.ProdId == PId);
            if(index==-1)
            {
               // throw System.Web.Http.H
            }
            ProdList.RemoveAt(index);

            
        }

        public IEnumerable<Product> ShowAllProd()
        {
            return ProdList;
            
        }

        public Product ShowProd(int PId)
        {
            int index = ProdList.FindIndex(p => p.ProdId == PId);

                return ProdList[index];
        }

        public void UpdateProd(int i,Product item)
        {
            int index = ProdList.FindIndex(p => p.ProdId == i);
            ProdList.RemoveAt(index);
            ProdList.Add(item);
           
        }
    }
}
