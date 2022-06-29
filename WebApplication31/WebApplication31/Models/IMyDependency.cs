using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication31.Models
{
    public interface IMyDependency
    {
        void WriteMessage(string message);
    }
}
