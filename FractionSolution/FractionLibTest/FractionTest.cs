using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionLib;


namespace FractionLibTest
{
    [TestClass]
    public class FractionTest
    {
        [TestMethod]
        [Owner("Marketing")]
        [TestCategory("Important")]
        public void Constructor_WithNoArguments()
        {
            //arrange
            int expectedTop = 0;
            int expectedBottom = 1;

            //act
            Fraction f = new Fraction();

            //assert
            Assert.AreEqual(expectedTop, f.Top);
            Assert.AreEqual(expectedBottom, f.Bottom);
        }

        [TestMethod]
        [Owner("Marketing")]
        [TestCategory("Important")]
        public void Constructor_WithOneArguments()
        {
            //arrange
            int expectedTop = 10;
            int expectedBottom = 1;

            //act
            Fraction f = new Fraction(expectedTop);

            //assert
            Assert.AreEqual(expectedTop, f.Top);
            Assert.AreEqual(expectedBottom, f.Bottom);
        }

        [TestMethod]
        [Owner("Marketing")]
        [TestCategory("Very Important")]
        public void Constructor_WithTwoArguments()
        {
            //arrange
            int expectedTop = 10;
            int expectedBottom = 9;

            //act
            Fraction f = new Fraction(expectedTop, expectedBottom);

            //assert
            Assert.AreEqual(expectedTop, f.Top);
            Assert.AreEqual(expectedBottom, f.Bottom);
        }

        [TestMethod]
        [Owner("Sales")]
        [TestCategory("Very Important")]

        public void ToStringArguments()
        {
            //arrange
            int top = 5;
            int bottom = 3;
            string expectedString = "5/3"

            //act
            Fraction f = new Fraction(top, bottom);
            string actualString = f.ToString();

            //assert
            Assert.AreEqual(expectedString, actualString);
        }

        [TestMethod]
        [Owner("Sales")]
        [TestCategory("Ultra Important")]

        public void Addition_TwoArguments()
        {
            //arrange
            int topLeft = 3;
            int bottomLeft = 5;

            int topRight = 1;
            int bottomRight = 2;

            int expectedTop = 11;
            int expectedBottom = 10;

            //act
            Fraction fLeft = new Fraction(topLeft, bottomLeft);
            Fraction fRight = new Fraction(topRight, bottomRight);

            Fraction fResult = fLeft + fRight;

            //assert
            Assert.AreEqual(expectedTop, fResult.Top);
            Assert.AreEqual(expectedBottom, fResult.Bottom);
        }

        [TestMethod]
        [Owner("IT")]
        [TestCategory("Ultra Important")]

        public void Subtraction_TwoArguments_NoException()
        {
            //arrange
            int topLeft = 3;
            int bottomLeft = 5;

            int topRight = 1;
            int bottomRight = 2;

            int expectedTop = 1;
            int expectedBottom = 10;

            //act
            Fraction fLeft = new Fraction(topLeft, bottomLeft);
            Fraction fRight = new Fraction(topRight, bottomRight);

            Fraction fResult = fLeft - fRight;

            //assert
            Assert.AreEqual(expectedTop, fResult.Top);
            Assert.AreEqual(expectedBottom, fResult.Bottom);
        }

        [TestMethod]
        [Owner("IT")]
        [TestCategory("Ultra Important")]

        [ExpectedException(typeof(Exception))]
        public void Subtraction_TwoArguments_WithException()
        {
            //arrange
            int topLeft = 1;
            int bottomLeft = 2;

            int topRight = 3;
            int bottomRight = 5;

            int expectedTop = 1;
            int expectedBottom = 10;

            //act
            Fraction fLeft = new Fraction(topLeft, bottomLeft);
            Fraction fRight = new Fraction(topRight, bottomRight);

            Fraction fResult = fLeft - fRight;

            //assert
        }
    }
}
