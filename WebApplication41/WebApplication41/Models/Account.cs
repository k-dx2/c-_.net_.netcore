using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication41.Models
{
    public class Account : IAccountTransient, IAccountScoped, IAccountSingleton
    {
        public string AccNo { get; set; }
        public Account()
        {
            AccNo = Guid.NewGuid().ToString();
        }

   
        public string GetAccountDetails()
        {
            return AccNo;
        }
    }
}
