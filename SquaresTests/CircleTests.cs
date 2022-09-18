using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Squares.Tests
{
    [TestClass()]
    public class CircleTests
    {
        [TestMethod()]
        public void CircleTest()
        {
            //arrange
            const double input = 5;
            const double expected = 5;

            //act
            Circle actual = new Circle(input);

            //assert
            Assert.AreEqual(expected, actual.Radius, "Круг с радиусом {0} должен быть с {1}!");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CircleWithRadius_0()
        {
            //arrange
            const double input = 0;

            //act
            Circle actual = new Circle(input);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CircleWithNegativeRadius()
        {
            //arrange
            const double input = -5;

            //act
            Circle actual = new Circle(input);
        }

        [TestMethod()]
        public void CircleSquareTest()
        {
            //arrange
            const double input = 5;
            const double expected = 79;

            //act
            Circle circle = new Circle(input);
            double actual = Math.Round(circle.Square());
            //assert
            Assert.AreEqual(expected, actual, $"Круг с радиусом {expected} должен быть с {actual}!");
        }
    }
}