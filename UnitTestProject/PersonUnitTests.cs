using CSharp6App2.StringInterpol;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProject.StringInterpol
{
    [TestClass]
    public class PersonUnitTests
    {
        [TestMethod]
        public void Test_String_Using_StringFormat()
        {
            // prepare
            var p = new Person("Johny", "Mont") { Age = 35 };

            // act
            string message = string.Format("Hello!  My name is {0} {1} and I am {2} years old.", p.FirstName, p.LastName, p.Age);

            // assert
            AreEqual("Hello!  My name is Johny Mont and I am 35 years old.", message);
        }

        #region Ex1 - string interpolation
        [TestMethod]
        public void Test_String_Using_StringInterpolation()
        {
            // prepare
            var p = new Person("Johny", "Mont") { Age = 35 };

            // act
            string message = $"Hello!  My name is {p.FirstName} {p.LastName} and I am {p.Age} years old.";

            // assert
            AreEqual<string>("Hello!  My name is Johny Mont and I am 35 years old.", message);
        }
        #endregion
    }
}
