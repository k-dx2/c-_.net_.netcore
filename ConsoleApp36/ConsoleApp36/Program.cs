using System;
using System.IO;
using System.Text;


namespace ConsoleApp36
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create object of FileInfo for speicific path
            FileInfo fi = new FileInfo(@"Test.txt");

            //Open File For Read/Write
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);

            //Create byte Array of same size as FileStream Length
            byte[] fileByte = new byte[fs.Length];

            //define Counter to check how much bytes to read,decrease counter as you read each byte
            int source = (int)fileByte.Length;

            //Counter to indicate Number of bytes already read
            int destination = 0;
            
            //iterate till all the bytes read from FileStream
            while(source>0)
            {
                int n = fs.Read(fileByte, destination, source);

                if (n == 0)
                    break;

                destination += n;
                source -= n;

                
            }
            //Once you read all the bytes from FileStream, you can convert it into string using UTF8 encoding
            string fileString = Encoding.UTF8.GetString(fileByte);
            Console.WriteLine(fileString);

            //Close StreamReader object after operation
            fs.Close();
            Console.WriteLine();

            

            //Simple Method
               
            //Create object of FileInfo for speicific path
             FileInfo fi1 = new FileInfo(@"Test1.txt");
            
            //Open File For Read/Write
             FileStream fs1 = fi1.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

            //Create a Object of StreamReader by passing the FileStream object on which it needs to operate on
             StreamReader sr1 = new StreamReader(fs1);

            //Use ReadToEnd method to read all the content from file
             string FileContent1 = sr1.ReadToEnd();
             Console.WriteLine(FileContent1);

            //Close StreamReader object after operation
             sr1.Close();
             fs1.Close();



            //Simple Method with try catch block
            
            FileStream fs2=null;
            StreamReader sr2 = null;
            try
            {   //Create object of FileInfo for speicific path
                FileInfo fi2 = new FileInfo(@"Test2.txt");

                //Open File For Read/Write
                fs2 = fi2.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

                //Create a Object of StreamReader by passing the FileStream object on which it needs to operate on
                sr2 = new StreamReader(fs2);

                //Use ReadToEnd method to read all the content from file
                string FileContent2 = sr2.ReadToEnd();
                Console.WriteLine(FileContent2);

                

            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine("This is Exception : " + e);
            }


            finally
            {
                //Close StreamReader object after operation
                sr2.Close();
                fs2.Close();


            }
            
            



        }
    }
}
