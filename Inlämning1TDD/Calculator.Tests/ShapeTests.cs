using Inlämning1TDD;
using Inlämning1TDD.Shapes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculator.Tests
{
    [TestClass]
    public class ShapeTest
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

        [TestMethod()]
        public void GetPerimeterTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(3, 4, 3);

            //Act
            var expected = 10;
            var actual = triangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetPerimeterTriangleTest_NegativeInput()
        {
            //Arrange
            var triangle = new Triangle(-3, 4, 3);

            //Act
            var expected = 0;
            var actual = triangle.GetPerimeter();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAreaTriangleTest()
        {
            //Arrange
            var triangle = new Triangle(2, 5, 1);

            //Act
            var expected = 5;
            var actual = triangle.GetArea();

            //Act
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void GetAreaTriangleTest_NegativeInput()
        {
            //Arrange
            var triangle = new Triangle(-2, 5, 1);

            //Act
            var expected = 0;
            var actual = triangle.GetArea();

            //Act
            Assert.AreEqual(expected, actual);
        }
    }
}
