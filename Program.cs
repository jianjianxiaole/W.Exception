using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //TestThrow();
                 TestThrowWithMessage("This is test Exception");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void TestThrowWithMessage(string message)
        {
            //throw new InitializateException(message);
            throw new ImagerException(message);
        }

        public static void TestThrow()
        {
            throw new WangException();
        }
    }    
}
