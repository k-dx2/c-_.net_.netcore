using System;
using System.Collections.Generic;
using System.Collections;




namespace ConsoleApp40
{
    public interface  IStudent
    {
        public void GetStudentDetails();
        public void StudentMark();
        public void GetStudentSubjects();
    }

    public class Student:IStudent
    {
        public string SName;
        public string SId;
        public int SPhone;
        public int SSubNo;
        public List<string> SSub;
        public SortedList<string,int> SMark;

        public Student()
        {
            SName = "";
            SId = "";
            SPhone = 0;
            SSub = new List<string>();
            SMark = new SortedList<string,int>();
        }
        public void GetStudentDetails()
        {
            Console.WriteLine("Entre the Name");
            SName = Console.ReadLine();
            Console.WriteLine("Enter the ID");
            SId = Console.ReadLine();
            Console.WriteLine("Entre the Phone Number");
            SPhone = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Number of subjects");
            SSubNo = Convert.ToInt32(Console.ReadLine());
           
           
        }
        public void GetStudentSubjects()
        {
            Console.WriteLine("Entre the Subjects");
            for (int i = 0; i < SSubNo; i++)
            {
                SSub.Add(Console.ReadLine());

            }
        }
        public void StudentMark()
        {
            Console.WriteLine();
            Console.WriteLine("Entre the Marks of subject");
            for (int i = 0; i < SSubNo; i++)
            {
                int m = Convert.ToInt32(Console.ReadLine());

                SMark.Add(SSub[i], m);

            }


        }

        public void ShowStudent()
        {
            Console.WriteLine();
            Console.WriteLine("Name " + SName);
            Console.WriteLine("ID " + SId);
            Console.WriteLine("Phone Number " + SPhone);
            Console.WriteLine("Subjects ");
            foreach (var i in SSub)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("The Marks");
            

            /* OLD WAY for using this we have to declare only 
             * SortedList l= new SortedList(); ie a generic
             * ICollection key1 = SMark.Keys;
            foreach(string k in key1)
                Console.WriteLine(k + " : " + SMark[k]);
            */

            foreach (KeyValuePair<string,int> k in SMark )
            {
                Console.WriteLine(k.Key+ " : " + k.Value);
                Console.WriteLine();
            }


        }




    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.GetStudentDetails();
            s1.GetStudentSubjects();
            s1.StudentMark();
            s1.ShowStudent();
        }
    }
}
