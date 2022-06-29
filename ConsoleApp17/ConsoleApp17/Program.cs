using System;

namespace ConsoleApp17
{       
    //interface
    public interface ITransaction
    {
        double GetAmount();
        void ShowTransaction();

    }

    public class Transaction:ITransaction
    {
        private string TransId;
        private double TransAmount;
        private string TransDate;

        public Transaction()
        {
            TransId ="";
            TransAmount = 0.0;
            TransDate = "";

        }
        public Transaction(string a, double b, string c)
        {
            TransId = a;
            TransAmount = b;
            TransDate = c;

        }
        public double GetAmount()
        {
            return TransAmount;
        }
        public void ShowTransaction()
        {
            Console.WriteLine("Transaction ID : {0}",TransId);
            Console.WriteLine("Transaction Date : {0}", TransDate);
            Console.WriteLine("Transaction Amount : {0}", TransAmount);
            Console.WriteLine();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Transaction t1 = new Transaction("1234", 23999.99, "13/02/2020");
            Transaction t2 = new Transaction("5678", 2999.99, "15/10/2020");

            t1.ShowTransaction();
            t2.ShowTransaction();

        }
    }
}
