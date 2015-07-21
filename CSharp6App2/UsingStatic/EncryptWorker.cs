using static System.ConsoleColor;
using static System.Console;

namespace CSharp6App2.UsingStatic
{
    public class EncryptWorker
    {
        public static void DoWork()
        {
            ForegroundColor = Red;
            WriteLine("Doing work..");
            ForegroundColor = White;
        }
    }
}
