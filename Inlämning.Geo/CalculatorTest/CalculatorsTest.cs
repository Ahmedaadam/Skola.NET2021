using Inlämning1.Geometri;
using Inlämning1.Geometri.Interface;
using Inlämning1.Geometri.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]
    public class CalculatorsTest
    {
        [TestMethod()]
        public void GetAreaTest()
        {
            // Arrange
            var geoThings = new IGeometricThing[]
            {
                new Triangle(3,4,6),
                new Circle(6),
                new Square(5),
                new Rectangle(4,5)
            };

            //Act
            var actual = GeoCalculator.GetPerimeter(geoThings);
            const float expected = 13 + 37.699112f + 20 + 18;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
