using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication33.Models
{
    public class CustRepo : ICustRepo
    {   
        private readonly List<Customer> CustList;
        private int custid = 1;

        public CustRepo()
        {
            CustList = new List<Customer>();
            AddCust(new Customer { CustName="Iron Man",CustType="Premium",CustAddress="New York"});
            AddCust(new Customer { CustName = "Captain America", CustType = "Gold", CustAddress = "New York" });
            AddCust(new Customer { CustName = "Spider Man", CustType = "Silver", CustAddress = "England" });

        }
        public Customer AddCust(Customer c)
        {
            if (c == null)
            {
                throw new ArgumentNullException("c");
            }
              

            c.CustId = custid++;
            CustList.Add(c);

            return c;

         
        }

        public bool DelCust(int id)
        {
            /* int index = CustList.FindIndex(p => p.CustId == id);
             if(index==-1)
             {
                 return false;

             }
             CustList.RemoveAt(index);
             return true;
             */
            CustList.RemoveAll(p => p.CustId == id);
            return true;
        }

        public Customer ShowCust(int id)
        {
            /*int index = CustList.FindIndex(p => p.CustId == id);

             if (index == -1)
             {

             }

             return CustList[index];
            */
            return CustList.Find(p => p.CustId == id);

           
        }

        public IEnumerable<Customer> ShowAllCust()
        {
            return CustList;           
        }

        public bool UpdateCust(int id, Customer c)
        {   
            if(c== null)
            {
                throw new ArgumentNullException("c");
            }
            int index = CustList.FindIndex(p => p.CustId == id);

            if (index == -1)
            {
                return false;
            }
            CustList.RemoveAt(index);
            CustList.Add(c);
            return true;


        }
    }
}
