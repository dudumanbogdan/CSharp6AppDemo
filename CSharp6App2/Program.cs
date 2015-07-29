using CSharp6App2.AutoProperty;
using CSharp6App2.DictionaryInitializer;
using CSharp6App2.ExceptionImprov;
using CSharp6App2.NameOf;
using CSharp6App2.NullCondiOp;
using CSharp6App2.StringInterpol;
using CSharp6App2.UsingStatic;
using System;
using System.Collections.Generic;

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
            //customer.FullName = "John Denver";
            //customer.FullName = "Bob C.";
            #endregion

            #region nameOf - ex2
            // WpfApp1
            #endregion

            #region String Interpolation - ex1
            // 1. -> PersonUnitTests.cs
            #endregion

            #region String Interpolation - ex2
            //var p = new Person("", "John");
            //Console.WriteLine($"p.FullName: {p.FullName}");
            #endregion

            #region Null Conditional Operator - ex1 FooBar

            FooBar nullSample = null;

            #region 1
            if (nullSample != null && nullSample.Foo != null && nullSample.Foo.Bar != null)
            {
                nullSample.Foo.Bar.SayBar();
            }
            #endregion

            #region 2
            nullSample?.Foo?.Bar?.SayBar();
            #endregion

            #endregion

            #region Null Conditional Operator - ex2
            // Customer.cs - Null-Cond Operator - ex2
            #endregion

            #region Null Conditional Operator - ex3
            var points = new[]
            {
                new Point() {X = 3100, Y = 3200 },
                null
            };

            //Console.WriteLine(points[0]?.ToString());
            //Console.WriteLine(points[1]?.ToString());
            #endregion

            #region Null Conditional Operator - ex 4
            //Point[] points2 = null;
            //Point[] points3 = new Point[] { }; // !
            //Console.WriteLine(points2?[0]?.ToString());
            #endregion

            #region AutoProperty - ex1

            //var company1 = Company.NewCompany1;

            #endregion

            #region Expression Bodied Methods - ex1
            //var company2 = Company.NewCompany2();
            #endregion

            #region Expression Bodied Methods - ex2
            //var company3 = new Company("Coca-Cola", "Iasi");
            //Console.WriteLine(company3.ToString());
            #endregion

            #region Expression Bodied Methods - ex3
            var companies = new Companies();
            companies.Add(new Company("c1", "Iasi"));
            companies.Add(new Company("c2", "Cluj"));
            companies.Add(new Company("c3", "Bucuresti"));


            Console.WriteLine($"expression bodied methods - ex3, company: {companies["c3"]}");

            #endregion

            #region DictionaryInitializer - ex1
            var dicHelper = new DictionaryHelper();
            #endregion

            #region DictionaryInitializer - ex3
            var dic = dicHelper.Ex3();
            Console.WriteLine("ex3 - dictionary initializer");

            Console.WriteLine(dic[10]);

            // ! Console.WriteLine(dic[2]);

            #endregion

            #region DictionaryInitializer - ex4
            //var list = dicHelper.Ex4();

            ////Console.WriteLine(list[2]);
            #endregion

            #region ExceptionImprov - ex1
            var wHandler = new ExceptionHelper();
            //wHandler.ReadDataFromGoogle();
            #endregion

            #region ExceptionImprov - ex2 await
            var wHandler2 = new ExceptionHelper();
            //wHandler2.ReadDataFromGoogle2();
            #endregion

            #region ExceptionImprov - ex3
            wHandler.ShowCompanyDetails();
            #endregion

            Console.WriteLine("");
        }
    }
}

