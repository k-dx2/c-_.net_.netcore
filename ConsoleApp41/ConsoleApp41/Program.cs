using System;
using System.Collections.Generic;

namespace ConsoleApp41
{   
    public abstract class Hospital
    {
        public void IsEligibleForLoan(double a)
        {
            if(a>=1000000)
            {
                Console.WriteLine("Not Eligible for Medical Insurance");
            }
            else
                Console.WriteLine("Eligible for Medical Insurance");

            Console.WriteLine();
        }

        public abstract void GetPatientDetails();
        public abstract void PreviouAilments();


    }
    public class Patient:Hospital
    {
        public string PName;
        public string PId;
        public int PAge;
        public int PAilno;
        public double PMedi;
        public List<string> PAil;

        public Patient ()
        {
            PName = "";
            PId = "";
            PAge = 0;
            PAil = new List<string>();
            PMedi = 0.0;
        }
        public void Show()
        {

            Console.WriteLine("Name "+PName);
            Console.WriteLine("ID "+PId);
            Console.WriteLine("Age "+PAge);
            Console.WriteLine("Previous Aliment ");
            
            foreach(var i in PAil)
            {
                Console.Write(i + " ");
            }

        }
        public override void GetPatientDetails()
        {
            Console.WriteLine("Entre the Name");
            PName = Console.ReadLine();
            Console.WriteLine("Entre the ID");
            PId = Console.ReadLine();
            Console.WriteLine("Entre the age");
            PAge = Convert.ToInt32(Console.ReadLine());
           

        }
        public override void PreviouAilments()
        {
            Console.WriteLine("Enter the number Previos Ailments");
            PAilno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Previos Ailments");
            for (int i = 0; i < PAilno; i++)
            {
                PAil.Add(Console.ReadLine());
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Patient p1 = new Patient();
            p1.GetPatientDetails();
            p1.PreviouAilments();
            Console.WriteLine("Enter the amount for Medical Insurance");
            p1.PMedi = Convert.ToDouble(Console.ReadLine());
            p1.IsEligibleForLoan(p1.PMedi);
            p1.Show();


        }
    }
}
