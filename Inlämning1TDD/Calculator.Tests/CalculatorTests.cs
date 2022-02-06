using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inlämning1TDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inlämning1TDD.Shapes;

namespace Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
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