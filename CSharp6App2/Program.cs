using CSharp6App2.NameOf;
using CSharp6App2.UsingStatic;
using System;

namespace CSharp6App2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Using static - ex1
            //EncryptUtil.EncryptFiles();
            #endregion

            #region nameOf - ex1
            var customer = new Customer("John D.");
            customer.Name = "John Denver";
            #endregion

            #region nameOf - ex2

            #endregion

            #region MyRegion

            #endregion

            Console.WriteLine("");
        }
    }
}

