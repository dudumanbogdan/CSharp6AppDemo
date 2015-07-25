using CSharp6App2.NameOf;
using CSharp6App2.StringInterpol;
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
            //var customer = new Customer("John D.");
            //customer.Name = "John Denver";
            #endregion

            #region nameOf - ex2
            // WpfApp1
            #endregion

            #region String Interpolation - ex1
            // 1. -> PersonUnitTests.cs
            #endregion

            #region String Interpolation - ex2
            var p = new Person("", "John");

            #endregion

            #region Null Conditional Operator

            FooBar nullSample = null;

            // 1
            if (nullSample != null && nullSample.Foo != null && nullSample.Foo.Bar != null)
            {
                nullSample.Foo.Bar.SayBar();
            }

            // 2
            nullSample?.Foo?.Bar?.SayBar();

            #endregion

            Console.WriteLine("");
        }
    }
}

