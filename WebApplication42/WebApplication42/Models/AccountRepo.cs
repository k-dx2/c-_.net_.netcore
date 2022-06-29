using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication42.Models
{
    public class AccountRepo:IAccount
    {
        public List<Account> AccList;
        private int  Accitr;
       
        public AccountRepo()
        {
            Accitr = 1;
            AccList = new List<Account>();
            Add(new Account {AccHoldersName= "Iron Man",AccHoldersAddr="New York",AccBranch="New York",AccHolderPhone=123456 } );
            Add(new Account { AccHoldersName = "Spider man", AccHoldersAddr = "New York", AccBranch = "New York", AccHolderPhone = 342466 });
            Add(new Account { AccHoldersName = "Captain America", AccHoldersAddr = "Los Angeles", AccBranch = "Los Angeles", AccHolderPhone = 357677 });
            Add(new Account { AccHoldersName = "Hulk", AccHoldersAddr = "Whales", AccBranch = "Whales", AccHolderPhone = 567455 });


        }

        public Account Add(Account a)
        {
            if(a==null)
            {
                throw new ArgumentNullException("a");
            }
            a.AccNo = Accitr++;
            AccList.Add(a);
            return a;

        }

        public bool Del(int id)
        {
            AccList.RemoveAll(p => p.AccNo == id);
            return true;
           
        }

        public Account Show(int id)
        {
            return AccList.Find(p => p.AccNo == id);
        }

        public IEnumerable<Account> ShowAll()
        {
            return AccList;
        }

        public bool Update(int id, Account a)
        {
            if(a==null)
            {
                throw new ArgumentNullException("a");
            }
            int index = AccList.FindIndex(p => p.AccNo == id);
            if (id == -1)
            { return false; }
            AccList.RemoveAt(index);
            Add(a);
            return true;
            
        }
    }
}
