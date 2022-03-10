using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inlämning1.Geometri.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangles.Tests
{
    [TestClass()]
    public class RectangleTests
    {
        [TestMethod()]
        public void GetPerimeterRectangleTest()
        {
            //Arrange
            var rectangel = new Rectangle(6, 5);

            //Act
            var expected = 22;

            //Assert
            var actual = rectangel.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterRectangleTest_NegativeInput()
        {
            //Arrange
            var rectangel = new Rectangle(-6, 5);

            //Act
            var expected = 0;

            //Assert
            var actual = rectangel.GetPerimeter();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAreaRectangleTest()
        {
            //Arrange
            var rectangel = new Rectangle(6, 5);

            //Act
            var expected = 30;
            var actual = rectangel.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAreaRectangleTest_NegativeInput()
        {
            //Arrange
            var rectangel = new Rectangle(-6, 5);

            //Act
            var expected = 0;
            var actual = rectangel.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}