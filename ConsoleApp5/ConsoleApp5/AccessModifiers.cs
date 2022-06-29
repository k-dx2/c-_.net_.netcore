using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class ProgramSample
    {
        public string namepublic = "Kunal Dekate";

        public void Msgpublic(string message)
        {
            Console.WriteLine("Hello " + message);
        }
    }

    class PrivateSample
    {
        private string nameprivate = "Kunal Dekate";

        private void Msgprivate(string message)
        {
            Console.WriteLine("Hello " + message);
        }
    }

    class ProtectedSample
    {
        protected string nameprotect = "Kunal Dekate";
        protected void Msgprotect(string s)
        {
            Console.WriteLine("Hello " + s);
        }
    }

    class InternalSample
    {
        internal string nameinternal = "Kunal Dekate";
        internal void Msginternal (string s)
        {
            Console.WriteLine("Hello " + s);
        }
    }
}
