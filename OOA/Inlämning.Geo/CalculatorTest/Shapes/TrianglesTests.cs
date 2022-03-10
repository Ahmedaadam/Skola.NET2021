using Microsoft.VisualStudio.TestTools.UnitTesting;
using Inlämning1.Geometri.Shapes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles.Tests
{
    [TestClass()]
    public class TrianglesTests
    {
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