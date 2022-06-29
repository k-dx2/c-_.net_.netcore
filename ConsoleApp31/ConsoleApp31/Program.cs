using System;

namespace ConsoleApp31
{
    public abstract class Banking
    {

        public void EligibleForLoan(double amt)
        {
            if (amt > 1000000)
            {
                Console.WriteLine("Eligible for Loan");
            }
            else
            {
                Console.WriteLine("uneligible for Loan");
            }



        }
        public double GetBalance(double Tot,double lamt)
        {
            return Tot - lamt;

        }
        public abstract void GetTaxReport();
       

    }

    public class CorporateBanking : Banking
    {
        public double CLoanAmt;
        public double CtotBal;

        public CorporateBanking()
        {
            CtotBal = 100000;
        }
       
        public override void GetTaxReport()
        {
            Console.WriteLine();
            Console.WriteLine("TAX Report for Corporate Banking");
        }

    }
    public class GeneralBanking : Banking
    {
        public double GLoanAmt;
        public double GtotBal;

        public GeneralBanking()
        {
            GtotBal = 200000;
        }

        public override void GetTaxReport()
        {
            Console.WriteLine();
            Console.WriteLine("TAX Report for General Banking");

        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            GeneralBanking g=new GeneralBanking();
            CorporateBanking c=new CorporateBanking();
            Console.WriteLine("Entre amount for general bank");
            g.GLoanAmt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre amount for corporate bank");
            c.CLoanAmt = Convert.ToDouble(Console.ReadLine());

            g.EligibleForLoan(g.GLoanAmt);
            c.EligibleForLoan(c.CLoanAmt);


            g.GtotBal = g.GetBalance(g.GtotBal, g.GLoanAmt);
            Console.WriteLine("The Balance for General Bank "+g.GtotBal);

            c.CtotBal = c.GetBalance(c.CtotBal, c.CLoanAmt);
            Console.WriteLine("The Balance for General Bank " + c.CtotBal);



            g.GetTaxReport();
            c.GetTaxReport();



        }
    }
}
