using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication32.Models
{
    public class Operation : IOperationScoped, IOperationSingleton, IOperationTransient
    {
        public string OperationID { get; }

        public Operation()
        {
            OperationID=Guid.NewGuid().ToString();
        }
        
        
    }
}
