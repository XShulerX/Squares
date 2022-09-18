using Microsoft.VisualStudio.TestTools.UnitTesting;
using Squares;
using System;
using System.Collections.Generic;
using System.Text;

namespace Squares.Tests
{
    [TestClass()]
    public class TriangleTests
    {
        [TestMethod()]
        public void TriangleTest()
        {
            //arrange
            const double inputSide1 = 5;
            const double inputSide2 = 7;
            const double inputSide3 = 4;

            const double expected = 9.80;

            //act
            Triangle triangle = new Triangle(inputSide1, inputSide2, inputSide3);
            double actual = Math.Round(triangle.Square(), 2);

            //assert
            Assert.AreEqual(expected, actual, $"Треугольник с площадью {expected} должен быть с {actual}!");
        }

        [TestMethod()]
        public void StraightTriangleTest()
        {
            //arrange
            const double inputSide1 = 3;
            const double inputSide2 = 4;
            const double inputSide3 = 5;

            const double expected = 6;

            //act
            Triangle triangle = new Triangle(inputSide1, inputSide2, inputSide3);
            double actual = Math.Round(triangle.Square());

            //assert
            Assert.AreEqual(expected, actual, $"Треугольник с площадью {expected} должен быть с {actual}!");
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TriangleWithOneSide_0()
        {
            //arrange
            const double inputSide1 = 0;
            const double inputSide2 = 4;
            const double inputSide3 = 5;

            //act
            Triangle triangle = new Triangle(inputSide1, inputSide2, inputSide3);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void TriangleWithOneSideNegative()
        {
            //arrange
            const double inputSide1 = 3;
            const double inputSide2 = -4;
            const double inputSide3 = 5;

            //act
            Triangle triangle = new Triangle(inputSide1, inputSide2, inputSide3);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void ImposibleTriangleWithVeryBigSide()
        {
            //arrange
            const double inputSide1 = 3;
            const double inputSide2 = 8;
            const double inputSide3 = 4;

            //act
            Triangle triangle = new Triangle(inputSide1, inputSide2, inputSide3);
        }
    }
}