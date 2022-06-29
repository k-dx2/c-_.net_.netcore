using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication33.Models
{
    interface ICustRepo
    {
        IEnumerable<Customer> ShowAllCust();
        Customer ShowCust(int id);
        Customer AddCust(Customer c);
        bool UpdateCust(int id, Customer c);
        bool DelCust(int id);



    }
}
