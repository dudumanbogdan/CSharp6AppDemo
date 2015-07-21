#region Static
using static CSharp6App2.UsingStatic.EncryptWorker;
using static System.Console;
using static System.ConsoleColor;
using static System.IO.Directory;
using static System.Threading.Interlocked;
using static System.Threading.Tasks.Parallel; 
#endregion
using System;

namespace CSharp6App2.UsingStatic
{
    public class EncryptUtil
    {
        public static int EncryptFiles()
        {
            ConsoleColor color = ForegroundColor;
            int fileCount = 0;

            try
            {
                ForegroundColor = Yellow;
                WriteLine("Start encryption...");

                string directoryPath = @"C:\Users\bduduman\Downloads";
                string[] files = GetFiles(directoryPath);

                ForegroundColor = White;

                ForEach(files, (fileName) =>
                {
                    DoWork();
                    Encrypt(fileName);
                    WriteLine("\t '{0}' encrypted ", fileName);
                    Increment(ref fileCount);
                });

                ForegroundColor = Yellow;
                WriteLine("Encryption completed");
            }
            finally
            {
                ForegroundColor = color;
                WriteLine("Finished");
            }

            return fileCount;
        }

        private static void Encrypt(string fileName)
        {
            Write(fileName);
        }
    }
}
