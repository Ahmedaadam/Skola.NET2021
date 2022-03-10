using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inlämning1.Geometri.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circles.Tests
{
    [TestClass()]
    public class CirclesTests
    {
        [TestMethod()]
        public void GetAreaCircleTest()
        {
            //Assert
            var circle = new Circle(6);

            //Act
            var expected = 113.097336f;
            var actual = circle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TryCircleGetArea_NegativeInput()
        {
            //Assert
            var circle = new Circle(-6);

            //Act
            var expected = 0f;
            var actual = circle.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetPerimeterCircleTest()
        {
            //Arrange
            var circle = new Circle(6);

            //Act
            var expected = 37.699112f;
            var actual = circle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TryCircleGetPerimeter_NegativeInput()
        {
            //Assert
            var circle = new Circle(-6);

            //Act
            var expected = 0f;
            var actual = circle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}