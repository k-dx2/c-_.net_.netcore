using System;
using System.Collections.Generic;
namespace ConsoleApp38
{   
    public class Account
    {
        public static List<Account> AccList;
        public string AccId { get; set; }
        public string AccName { get; set; }
        public double AccBal { get; set; }

        public Account()
        {
            AccId = "";
            AccName = "";
            AccBal = 0.0;
        }

        public void AddAcc(Account a1)
        {
            AccList.Add(a1);

        }
        public static void ShowAcc()
        {
            foreach (var i in Account.AccList)
            {
                Console.WriteLine("Acount ID " + i.AccId);
                Console.WriteLine("Acount Name " + i.AccName);
                Console.WriteLine("Acount Balance " + i.AccBal);
                Console.WriteLine();

            }
        }

}
    class Program
    {
        static void Main(string[] args)
        {
            int c;
            Account.AccList = new List<Account>();
            Console.WriteLine("Welcome");
            while(true)
            {
                Console.WriteLine("1.Add Account");
                Console.WriteLine("2. Show Account");
                Console.WriteLine("3. Exit");
                c = Convert.ToInt32(Console.ReadLine());

                if (c == 1)
                {
                    Account a = new Account();
                    Console.WriteLine("Entre the Acount ID");
                    a.AccId = Console.ReadLine();
                    Console.WriteLine("Entre the Acount Name");
                    a.AccName = Console.ReadLine();
                    Console.WriteLine("Entre the Acount Balance");
                    a.AccBal = Convert.ToDouble(Console.ReadLine());

                    a.AddAcc(a);

                }
                else if (c == 2)
                {
                    Account.ShowAcc();

                }
                else if (c == 3)
                    break;
                else
                    Console.WriteLine("Wrong Choice");


            }

            

        }
    }
}
