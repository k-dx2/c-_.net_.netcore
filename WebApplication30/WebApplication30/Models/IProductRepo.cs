using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication30.Models
{
    interface IProductRepo
    {
        IEnumerable<Product> ShowAllProd();
        Product ShowProd(int PId);
        Product AddProd(Product item);
        void DelProd(int PId);
        void UpdateProd(int i,Product item);

    }
}
