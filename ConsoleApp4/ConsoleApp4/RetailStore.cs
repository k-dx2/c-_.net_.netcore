using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class RetailStore
    {
        List<Product> ListProd;

        public RetailStore()
        {
            ListProd= new List<Product>();
        }

        public string AddProd(Product p)
        {
            ListProd.Add(p);

            return "Added Succesfully";

        }

        public List<Product> ShowProd()
        {
            return ListProd;
        }
    }
}
