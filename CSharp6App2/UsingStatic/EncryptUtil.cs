#region Static
using static CSharp6App2.UsingStatic.EncryptWorker;
using static System.Console;
using static System.ConsoleColor;
using static System.IO.Directory;
using static System.Threading.Tasks.Parallel;
using static System.Tuple;
#endregion
using System;

namespace CSharp6App2.UsingStatic
{
    public class EncryptUtil
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("SonarQube", "S2228:Console logging should not be used", Justification = "<Pending>")]
        public static void EncryptFiles()
        {
            ConsoleColor color = ForegroundColor;

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
                });

                ForegroundColor = Yellow;
                WriteLine("Encryption completed");
            }
            finally
            {
                ForegroundColor = color;
                WriteLine("Finished");
            }
        }

        private static void Encrypt(string fileName)
        {
            //
            if(Exists(fileName))
            {
                Write("File Exists", fileName);


                var obj = Create(1, 2, 3);
            }

            #region 2
            //else if(System.IO.File.Exists(fileName))
            //{
            //    Write("File Exists", fileName);
            //}
            #endregion
        }
    }
}
