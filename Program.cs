using System;

namespace ConsoleApplication
{
    ///use cases for exception
    
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
            throw new MotionMovedException(message);
        }

        public static void TestThrow()
        {
            throw new WangException();
        }
    }    
}
