using System;

namespace ConsoleApp22
{   
    public class OfferExpiredException:Exception
    { 
        public OfferExpiredException(string message):base(message)
        {

        }
    }

    public class offer
    {
        public DateTime d;
        public offer()
        {
            d = new DateTime();
        }
        public void IsOfferExpired()
        {
            if (d > new DateTime(2021,01,31))
            {
                throw (new OfferExpiredException("Offer expired"));
            }
            else
                Console.WriteLine("Offer is valid");
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            offer f = new offer();
            Console.WriteLine("Enter the date of your Coupon");
            f.d= Convert.ToDateTime(Console.ReadLine());

            try
            {
                f.IsOfferExpired();
            }
            catch(OfferExpiredException e)
            {
                Console.WriteLine("Sorry : {0} ", e.Message); //Console.WriteLine(""Sorry : {0} ", e);
            }
        }
    }
}
