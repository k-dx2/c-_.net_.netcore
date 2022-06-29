using System;

namespace ConsoleApp18
{
    public interface IPayments
    {
        void PayforOrder();
        void CheckPaymentStatus();
        void ShowPaymentDetails();


    }

    public class GpayConnectsAmazon:IPayments
     {  
        private string UPIId;
        private string UPIPin;
        private double PayAmount;
        private bool Paystat;
        private DateTime PayDate;
        private string TransId;

        public GpayConnectsAmazon()
        {
            UPIId = "";
            UPIPin = "";
            Paystat = false;
            PayDate = new DateTime();
            TransId = "";



        }

        public void PayforOrder()
        {
            Console.WriteLine("Entre the Amount to be Paid");
            PayAmount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre the UPI ID");
            UPIId = Console.ReadLine();

            Console.WriteLine("Entre the UPI Pin");
            UPIPin = Console.ReadLine();

            Console.WriteLine("Confirming payment( Type true to Confirm) ");
            Paystat = Convert.ToBoolean(Console.ReadLine());

            PayDate = DateTime.Now;
            TransId = PayDate.ToString() + UPIId;

        }
        public void CheckPaymentStatus()
        {
            Console.WriteLine();
            if (Paystat == true)
                Console.WriteLine("Payment Successful");
            else
                Console.WriteLine("Payment Unsuccessful");

            Console.WriteLine();
        }

        public void ShowPaymentDetails()
        {
            Console.WriteLine("Transaction ID {0}", TransId);
            Console.WriteLine("Transaction Date and Time {0}", PayDate);
            Console.WriteLine("Transaction Payed with UPI ID : {0}", UPIId);
            Console.WriteLine("Amount Paid : {0}",PayAmount);
            if(Paystat==true)
                Console.WriteLine("Transaction Status : Sucessfull");
            else
                Console.WriteLine("Transaction Status : Unsucessfull");

            Console.WriteLine();


        }

        
     }


    class Program
    {
        static void Main(string[] args)
        {
            GpayConnectsAmazon customer = new GpayConnectsAmazon();
            customer.PayforOrder();
            customer.CheckPaymentStatus();
            customer.ShowPaymentDetails();

        }
    }
}
