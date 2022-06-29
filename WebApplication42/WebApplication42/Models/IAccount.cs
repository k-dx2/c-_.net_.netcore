using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication42.Models
{
    interface IAccount
    {
        IEnumerable<Account> ShowAll();
        Account Show(int id);
        Account Add(Account a);
        bool Update(int id, Account a);
        bool Del(int id);
    }
}
