using Inlamning.TDD.Shapes;
using NUnit.Framework;
using System;

namespace Inlamning.TDD.Test
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void GetArea()
        {
            // Arrange
            var calc = new Calculator();
            // Act
            var actual = calc.GetArea(0);
            var expected = 0;
            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
