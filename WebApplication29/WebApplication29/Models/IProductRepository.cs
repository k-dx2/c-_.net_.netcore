using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication29.Models
{
    interface IProductRepository
    {
        IEnumerable<Product> GetAllProduct();
        Product GetProduct(int id);
        Product AddProduct(Product item);
        void RemoveProduct(int id);
        bool UpdateProduct(Product item);

    }
}
