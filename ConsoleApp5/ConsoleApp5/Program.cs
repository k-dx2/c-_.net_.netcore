using System;

namespace ConsoleApp5
{
    class Program: ProtectedSample //inhertitence 
    {
        static void Main(string[] args)
        {   
            //public
            ProgramSample ps = new ProgramSample();
            Console.WriteLine(ps.namepublic);
            ps.Msgpublic("Dekate");

            //private
            PrivateSample pvts = new PrivateSample();
            //Console.WriteLine(pvts.nameprivate); Error coz pvts.name is private
            //pvts.Msgprivate("Dekate"); Error coz pvts.Msg is private


            //protected
            Program prot = new Program();
            Console.WriteLine(prot.nameprotect);
            prot.Msgprotect("dekate");


            //interanl
            InternalSample internalsample= new InternalSample();
            Console.WriteLine(internalsample.nameinternal);
            internalsample.Msginternal("Dekate");

        }

    }

    class Program1:ProtectedSample
    {
        


    }
}
