using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication41.Models
{
    public interface IAccount
    {
        string AccNo { get; set; }
        string GetAccountDetails();
    }
    public interface IAccountTransient : IAccount { }
    public interface IAccountScoped : IAccount { }
    public interface IAccountSingleton : IAccount { }


}
