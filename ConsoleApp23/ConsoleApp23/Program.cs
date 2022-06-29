using System;
using System.Threading;

namespace ConsoleApp23
{   
   
    public interface DebitPayOnAmazon
    {
        void MakePaymentUsingNumber();
        void IsPaymentSuccessful();
        void OrderDetails();
    }
    public class SbiOrder:DebitPayOnAmazon
    {
        public int DebitCardNo;
        public string ExpDate;
        public string NameOnCard;
        public int Cvv;
        public double Amount;
        public int Otp;
        public bool PayStat;
        public DateTime PayDate;

        public SbiOrder()
        {
            DebitCardNo = 0;
            ExpDate = " ";
            NameOnCard = " ";
            Cvv = 0;
            Amount = 0.0;
            Otp = 0;
            PayStat = false;
            PayDate = new DateTime();
        }
        public void MakePaymentUsingNumber()
        {
            Console.WriteLine("Entre the Amount to be paid");
            Amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Entre the Debit Card Number");
            DebitCardNo= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Entre the Name on written on Debit Card");
            NameOnCard = Console.ReadLine();

            Console.WriteLine("Entre the Expiry Date written on Debit Card");
            ExpDate= Console.ReadLine();

            Console.WriteLine("**************************************************************************************");
            Console.WriteLine("Sending the OTP on registered Mobile Number");
            Console.WriteLine("**************************************************************************************");
            Thread.Sleep(5000);

            Console.WriteLine("Entre the OTP");
            Otp = Convert.ToInt32(Console.ReadLine());

            if(Otp==12345)
            {
                PayStat = true;
            }
            else
            {
                PayStat = false;

            }
            PayDate = DateTime.Now;

            Console.WriteLine();

         }

        public void IsPaymentSuccessful()
        {
            if (PayStat == true)
                Console.WriteLine("Payment is successful");
            else
                Console.WriteLine("Payment is unsuccessful");

            Console.WriteLine();

        }
        public void OrderDetails()
        {
            if (PayStat == true)
            {
                Console.WriteLine("Your Order is Confirmed, Order Details are mentioned Below");
                Console.WriteLine("1.Iphone 12 pro Max  -- 1 unit");
                Console.WriteLine("Paid using : " + DebitCardNo);
                Console.WriteLine("Paid on : " + PayDate);
                Console.WriteLine("Delivery Expected by 15th February");
            }
            else
            {
                Console.WriteLine("Order is failed");
            }
            Console.WriteLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {

            SbiOrder s = new SbiOrder();
            s.MakePaymentUsingNumber();
            s.IsPaymentSuccessful();
            s.OrderDetails();
        }


    }
}
