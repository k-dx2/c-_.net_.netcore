using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication32.Models
{
    public interface IOperation
    {
        string OperationID { get; }
    }

    public interface IOperationTransient : IOperation { }

    public interface IOperationScoped : IOperation { }

    public interface IOperationSingleton : IOperation { }

}