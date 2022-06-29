using System;

namespace ConsoleApp20
{   
    public class Math
    {
        private int result;
        public Math()
        {
            result = 0;
        }
        public void divide(int a ,int b)
        {
           
            try
            {
                result = a / b;
            }
            catch(DivideByZeroException e) //catch(Exception e) or catch(SystemException e) or catch(ArithmeticException e)
            {
                Console.WriteLine("Exception caught : {0}",e);
            }
            catch(Exception e)
            {
                Console.WriteLine("Sorry : {0}", e);
            }
            finally
            {
                Console.WriteLine("Result : {0}", result);
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Math m = new Math();
            m.divide(23, 0);

        }
    }
}
