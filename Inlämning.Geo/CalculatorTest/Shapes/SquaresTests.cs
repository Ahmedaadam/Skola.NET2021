using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inlämning1.Geometri.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Squares.Tests
{
    [TestClass()]
    public class SquaresTests
    {
        [TestMethod()]
        public void GetPerimeterSquareTest()
        {
            //Arrange
            var square = new Square(5);

            //Act
            var expected = 20;
            var actual = square.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterSquareTest_NegativeInput()
        {
            //Arrange
            var square = new Square(-5);

            //Act
            var expected = 0;
            var actual = square.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAreaSquareTest()
        {
            //Arrange
            var square = new Square(5);

            //Act
            var expected = 25;
            var actual = square.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAreaSquareTest_NegativeInput()
        {
            //Arrange
            var square = new Square(-5);

            //Act
            var expected = 0;
            var actual = square.GetArea();

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}