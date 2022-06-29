using System;

namespace ConsoleApp24
{
    public class LoanCannotBeApproed:Exception
    {
        public LoanCannotBeApproed(string s):base(s)
        {

        }
    }

    public class Loan
    {
        public int amount;
        public Loan()
        {
            amount = 0;
        }

        public void LoanApprove()
        {
            if (amount > 100000)
            {
                throw (new LoanCannotBeApproed("Amount above Limit"));
            }
            else
            {
                Console.WriteLine("Loan Approved");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Loan l1 = new Loan();
            Console.WriteLine("Entre the amount to be taken as loan");
            l1.amount = Convert.ToInt32(Console.ReadLine());

            try
            {
                l1.LoanApprove();
              
            }
            catch(LoanCannotBeApproed e)
            {
                Console.WriteLine("Sorry : {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Thank you ");
            }

        }
    }
}
