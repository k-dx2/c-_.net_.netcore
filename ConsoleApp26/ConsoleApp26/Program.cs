using System;
using System.Collections.Generic;

namespace ConsoleApp26
{
    public abstract class Employee
    {
        public double TotSalary { get; set; }
        public double CalSalary(double Basic, double Allowances, double IncomeTax, double Pf, double Bonus)
        {
            TotSalary = Basic + Allowances + Bonus - IncomeTax - Pf;
            return TotSalary;

        }
        public abstract void GetDetails();
        public abstract void GetTechstack();
    }

    public class PermanentEmployee:Employee
     {
        private string EmpName;
        private string EmpId;
        private string EmpLoc;
        private string EmpSkill;
        public double EmpBasic;
        public double EmpAllow;
        public double EmpBonus;
        public double EmpIT;
        public double EmpPf;


        public override void GetDetails()
        {
            Console.WriteLine("Entre the Employee ID");
            EmpId = Console.ReadLine();
            Console.WriteLine("Entre the Employee Name");
            EmpName= Console.ReadLine();
            Console.WriteLine("Entre the Employee Location");
            EmpLoc = Console.ReadLine();

        }
        public override void GetTechstack()
        {
            Console.WriteLine("Entre the Technical Stack Employee Working on");
            EmpSkill = Console.ReadLine();
           
            
        }
        public void EmpGetSalary()
        {
            Console.WriteLine("Entre the Basic");
            EmpBasic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre the Allowance");
            EmpAllow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre the Income Tax");
            EmpIT= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre the PF");
            EmpPf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre the Bonus");
            EmpBonus = Convert.ToInt32(Console.ReadLine());



        }
        public void EmpShow()
        {
            Console.WriteLine("Employee ID " + EmpId);
            Console.WriteLine("Employee Name "+EmpName);
            Console.WriteLine("Employee Location "+EmpLoc);
            Console.WriteLine("Technical Stack Employee Working on "+EmpSkill);



        }


    }
    public class ContractEmployee : Employee
    {
        private string CEmpName;
        private string CEmpId;
        private string CEmpLoc;
        private string CEmpComp;
        private string CEmpSkill;
        private int CEmpExp;
        public double CEmpBasic;
        public double CEmpAllow;
        public double CEmpIT;
        public double CEmpBonus;
        public double CEmpPf;

        public override void GetDetails()
        {
            Console.WriteLine("Entre the Employee ID");
            CEmpId = Console.ReadLine();
            Console.WriteLine("Entre the Employee Name");
            CEmpName = Console.ReadLine();
            Console.WriteLine("Entre the Employee Location");
            CEmpLoc = Console.ReadLine();
            Console.WriteLine("Entre the Employee's Comapany");
            CEmpComp = Console.ReadLine();
        }

        public override void GetTechstack()
        {
            Console.WriteLine("Entre the Technical Stack Employee Working on");
            CEmpSkill = Console.ReadLine();
            Console.WriteLine("Entre the Experience of the Employee in current Technical Stack");
            CEmpExp = Convert.ToInt32(Console.ReadLine());
        }
           
        public void CEmpGetSalary()
        {
            Console.WriteLine("Entre the Basic");
            CEmpBasic = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre the Allowance");
            CEmpAllow = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre the Income Tax");
            CEmpIT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre the PF");
            CEmpPf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Entre the Bonus");
            CEmpBonus = Convert.ToInt32(Console.ReadLine());


        }
        public void CEmpShow()
        {
            Console.WriteLine("Employee ID " + CEmpId);
            Console.WriteLine("Employee Name " + CEmpName);
            Console.WriteLine("Employee Location " + CEmpLoc);
            Console.WriteLine("Technical Stack Employee Working on " + CEmpSkill);
            Console.WriteLine("Experience of the Employee in current Technical Stack "+ CEmpExp);



        }

    }
    class Program
    {
        static void Main(string[] args)
        {       int c,choice1,choice2;

                List <PermanentEmployee> PEmp= new List<PermanentEmployee>();
                List<ContractEmployee> CEmp = new List<ContractEmployee>();

            while (true)
            {
                Console.WriteLine("Welcome");
                Console.WriteLine("1.Entering DataBase");
                Console.WriteLine("2.Showing DataBase");
                Console.WriteLine("3.To Exit");

                c = Convert.ToInt32(Console.ReadLine());
                if (c == 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("1.Permanent");
                    Console.WriteLine("1.Contractor");
                    choice1=Convert.ToInt32(Console.ReadLine());
                    if(choice1==1)
                    {
                        PermanentEmployee e = new PermanentEmployee();
                        e.GetDetails();
                        e.GetTechstack();
                        e.EmpGetSalary();
                        PEmp.Add(e);

                    }
                    else if(choice1==2)
                    {
                        ContractEmployee a = new ContractEmployee();
                        a.GetDetails();
                        a.GetTechstack();
                        a.CEmpGetSalary();
                        CEmp.Add(a);
                    }
                    else
                    {
                        Console.WriteLine("Wrong Choice");
                    }
                    
                }
                else if (c == 2)
                {
                    Console.WriteLine();
                    Console.WriteLine("1.Permanent");
                    Console.WriteLine("2.Contractor");
                    choice2 = Convert.ToInt32(Console.ReadLine());
                    if (choice2 == 1)
                    {
                        foreach(var e in PEmp)
                        {
                            Console.WriteLine();
                            e.EmpShow();
                            Console.WriteLine("The salary is {0}", e.CalSalary(e.EmpBasic, e.EmpAllow, e.EmpIT, e.EmpPf, e.EmpBonus));
                            Console.WriteLine();
                        }
                    }
                    else if (choice2 == 2)
                    {
                        foreach (var e in CEmp)
                        {
                            Console.WriteLine();
                            e.CEmpShow();
                            Console.WriteLine("The salary is {0}", e.CalSalary(e.CEmpBasic, e.CEmpAllow, e.CEmpIT, e.CEmpPf, e.CEmpBonus));
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("Wrong Choice");
                    }

                }
                else if (c == 3)
                {
                    break;
                }
                else 
                { 
                    Console.WriteLine("Wrong Choice"); 
                }
                

                
                
               
            }



        }
    }
}
