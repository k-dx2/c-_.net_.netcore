using System;

namespace ConsoleApp19
{   
    public interface UPI
    {
        void ShowTransaction();
        void ShowBalance();
        void PayforProduct();

    }

    public class TataPay:UPI
    {
        private string UpiId;
        private string UpiPin;
        private DateTime PayDate;
        private double PayAmount;
        private double TotAmount;
        private bool Paystat;
        private string TransId;
            
        public TataPay()
        {
            UpiId= "";
            UpiPin = "";
            PayDate = new DateTime();
            PayAmount = 0.0;
            Paystat = false;
            TotAmount = 100000;
            TransId = "";
        }


        public void  PayforProduct()
        {
            Console.WriteLine("Enter the amount to be paid");
            PayAmount = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the UPI Id");
            UpiId = Console.ReadLine();
            Console.WriteLine("Enter the UPI Pin");
            UpiPin = Console.ReadLine();
            Console.WriteLine("Confirm your Payment");
            Paystat = Convert.ToBoolean(Console.ReadLine());

            PayDate = DateTime.Now;
            TransId = PayDate.ToString() + UpiId;


            Console.WriteLine();

            
            


        }

        public void ShowTransaction()
        {
            Console.WriteLine("Amount paid : {0}", PayAmount);
            Console.WriteLine("Transaction ID : {0}", TransId);
            Console.WriteLine("Paid through UPI  : {0}", UpiId);
            Console.WriteLine("Date and Time of Payment :{0}", PayDate);
            if(Paystat==true)
                Console.WriteLine("Payment Successful");
            else
                Console.WriteLine("Payment Unsuccessful");
            Console.WriteLine();





        }

        public void ShowBalance()
        {
            Console.WriteLine("Amount left : ");
            TotAmount = TotAmount - PayAmount;
            Console.WriteLine(TotAmount);
            Console.WriteLine();

        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            TataPay T = new TataPay();
            T.PayforProduct();
            T.ShowTransaction();
            T.ShowBalance();
        }
    }
}
