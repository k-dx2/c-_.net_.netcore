using System;

namespace ConsoleApp21
{   
    public class AmountIsZeroEx : Exception
    {
        public AmountIsZeroEx(string message) : base(message) //explicitly calling base class constructor while calling constructor of child class,good practice, if not called base(message) not a problem automatically called
        {

        }
    }
    public class AmountValidator
    {
        int amount = 0;
        public void AmountCalc()
        {
            if(amount==0)
            {
                throw (new AmountIsZeroEx("Zero amount found"));
            } 
            else
            {
                Console.WriteLine("Amount : {0} ", amount);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            AmountValidator amtvalid = new AmountValidator();
            try
            {
                amtvalid.AmountCalc();
            }
            catch(AmountIsZeroEx e)
            {
                Console.WriteLine("Amount is Zero Exception :{0}", e.Message);
            }
        }
    }
}
