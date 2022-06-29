using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace ConsoleApp43
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = {"kunal","adarsh","sumant","Sachin","amal","nalanda","sumit", };
            
            /*LINQ for Collections*/

            //using LINQ
            UsingLINQ(names);

            //using LINQ Extensions
            UsingLINQExtensions(names);

            //using LINQ functions
            UsingLINQFunctions(names);

            //using Anonymous function
            UsingAnonymousFunctions(names);

            /*LINQ for XMLs*/

            string myXML = @"<Departments>                    
                             <Department>Accounts</Department>
                             <Department>Sales</Department>
                             <Department>Pre-Sales</Department>
                             <Department>Marketing</Department>
                             </Departments>"; //@ for multiline string accept by compiler
           
            XDocument xdoc = new XDocument();
            xdoc = XDocument.Parse(myXML);

            //Add Element in XML (by default adds in last position)
            xdoc.Element("Departments").Add(new XElement("Department", "Finance"));

            //Add Element at First
            xdoc.Element("Departments").AddFirst(new XElement("Department", "Support"));

            var result = xdoc.Element("Departments").Descendants();
            
            foreach ( XElement item in result)
            {
                Console.WriteLine("Department Name- " + item.Value);
            }


            //Removes Sales department
            Console.WriteLine("After Deleting Sales Department");

            xdoc.Descendants().Where(s => s.Value == "Sales").Remove();

            var result1 = xdoc.Element("Departments").Descendants();

            foreach (XElement item in result1)
            {
                Console.WriteLine("Department Name- " + item.Value);
            }
        }
        private static void UsingLINQ(string[] names )
        {
            IEnumerable<string> query = from s in names
                                        where s.Length == 5
                                        orderby s
                                        select s.ToUpper();
            foreach (string s in query)
                Console.WriteLine(s);
            //Console.Read();


        }
        private static void UsingLINQExtensions(string[] names)
        {
            IEnumerable<string> query = names
                                        .Where(s=> s.Length == 5)
                                        .OrderBy(s=>s)
                                        .Select(s=>s.ToUpper());
            foreach (string s in query)
                Console.WriteLine(s);
            //Console.Read();


        }

        private static void UsingLINQFunctions(string[] names)
        {
            Func<string, bool> filter = s => s.Length == 5;
            Func<string, string> extract = s => s;
            Func<string, string> project = s => s.ToUpper();

            IEnumerable<string> query = names
                                       .Where(filter)
                                       .OrderBy(extract)
                                       .Select(project);
            foreach (string s in query)
                Console.WriteLine(s);
            //Console.Read();


        }

        private static void UsingAnonymousFunctions(string[] names)
        {
            Func<string, bool> filter = delegate (string s)
            {
                //add more code according to the senario
                return s.Length == 5;
            };

            Func<string, string> extract = delegate (string s)
            {
                //add more code according to the senario
                return s;
            };
            Func<string, string> project= delegate (string s)
            {
                //add more code according to the senario
                return s.ToUpper();
            };


            IEnumerable<string> query = names
                                       .Where(filter)
                                       .OrderBy(extract)
                                       .Select(project);
            foreach (string s in query)
                Console.WriteLine(s);
            //Console.Read();



        }
    }
}
