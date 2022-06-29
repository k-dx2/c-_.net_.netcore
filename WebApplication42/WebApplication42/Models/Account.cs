using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication42.Models
{
    public class Account
    {
        public int AccNo { get; set; }
        public string AccHoldersName { get; set; }
        public string AccBranch { get; set; }
        public string AccHoldersAddr { get; set; }
        public int AccHolderPhone { get; set; }
    }
}
