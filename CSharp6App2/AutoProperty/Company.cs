using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp6App2.AutoProperty
{
    public class Company
    {
        #region ex1 -Auto-Property initializer - old

        private int _size = 10;

        public int CompanySize1
        {
            get { return _size; }
            set { _size = value; }
        }

        public int CompanySize2 { get; set; }

        #endregion

        //#region ex1 - old - Getter & Set
        ////public string FullName { get; private set; }
        //#endregion

        public Company()
        {
            Console.WriteLine("New Company created");

            #region ex1 -Auto-property initializer - old
            CompanySize2 = 10;
            #endregion
        }

        public Company(string companyName, string city)
        {
            #region ex1 - Getter-only Auto-Property
            FullName = $"{companyName}  {city}";
            #endregion
        }

        public static Company NewCompany1 => new Company();
        public static Company NewCompany2() => new Company();

        #region ex1 - Auto-Property initializer
        public int CompanySize { get; set; } = 10;
        #endregion

        #region ex2 - Auto-Property initializer
        public string CompanyName => FullName.Split(' ')[0];
        public string City => FullName.Split(' ')[2];
        #endregion

        #region ex1 - Getter-only Auto-Property
        public string FullName { get; }
        #endregion

        #region ex2 - Expression-bodied methods
        public override string ToString() => $"Company: {CompanyName}, City: {City}";
        #endregion

    }

    public class Companies : List<Company>
    {
        public Company this[string companyName] => this.FirstOrDefault(x => x.CompanyName == companyName);
    }
}
