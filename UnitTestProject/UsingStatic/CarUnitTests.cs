using Microsoft.VisualStudio.TestTools.UnitTesting;

#region Using Static
using static Microsoft.VisualStudio.TestTools.UnitTesting.Assert;
#endregion

namespace UnitTestProject
{
    internal class Car
    {
        public string Name { get; set; }
        public string Model { get; set; }

        public static Car NewCar()
        {
            return new Car { Name = "DefaultName", Model = "DefaultModel" };
        }
    }

    [TestClass]
    public class CarUnitTests
    {
        #region UsingStatic
        [TestMethod]
        public void Test_Car_Default_Name()
        {
            // prepare
            var car = Car.NewCar();

            // act

            // assert
            AreEqual(car.Name, "DefaultName");
        }

        [TestMethod]
        public void Test_Car_Default_Model()
        {
            // prepare
            var car = Car.NewCar();

            // act

            // assert

            AreNotEqual(car.Model, "DefaultName");
        }

        #endregion
    }
}
