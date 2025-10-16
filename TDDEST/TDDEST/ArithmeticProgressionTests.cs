using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TDDproject;

namespace TDDEST
{
    [TestClass]
    public class ArithmeticProgressionTests
    {
        [TestMethod]
        public void GetElement_ValidNumber_ReturnsCorrectValue()
        {
            IArithmeticProgression progression = new ArithmeticProgression(2, 3);
            int n = 5;
            double expected = 14;

            double actual = progression.GetElement(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetElement_ZeroAsNumber_ThrowsArgumentOutOfRangeException()
        {
            IArithmeticProgression progression = new ArithmeticProgression(2, 3);

            progression.GetElement(0);
        }

        [TestMethod]
        public void GetSum_ValidNumber_ReturnsCorrectSum()
        {
            IArithmeticProgression progression = new ArithmeticProgression(1, 2);
            int n = 4;
            double expected = 16;

            double actual = progression.GetSum(n);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void GetSum_NegativeNumber_ThrowsArgumentOutOfRangeException()
        {
            IArithmeticProgression progression = new ArithmeticProgression(1, 2);

            progression.GetSum(-5);
        }

        [TestMethod]
        public void Add_TwoProgressions_ReturnsNewCorrectProgression()
        {
            IArithmeticProgression p1 = new ArithmeticProgression(2, 3);
            IArithmeticProgression p2 = new ArithmeticProgression(5, 4);
            IArithmeticProgression expected = new ArithmeticProgression(7, 7);

            IArithmeticProgression actual = p1.Add(p2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtract_TwoProgressions_ReturnsNewCorrectProgression()
        {
            IArithmeticProgression p1 = new ArithmeticProgression(10, 8);
            IArithmeticProgression p2 = new ArithmeticProgression(3, 2);
            IArithmeticProgression expected = new ArithmeticProgression(7, 6);

            IArithmeticProgression actual = p1.Subtract(p2);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Multiply_ByNumber_ReturnsNewCorrectProgression()
        {
            IArithmeticProgression progression = new ArithmeticProgression(5, 10);
            double number = 3;
            IArithmeticProgression expected = new ArithmeticProgression(15, 30);

            IArithmeticProgression actual = progression.Multiply(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_NumberToProgression_ReturnsNewCorrectProgression()
        {
            IArithmeticProgression progression = new ArithmeticProgression(5, 10);
            double number = 20;
            IArithmeticProgression expected = new ArithmeticProgression(25, 10);

            IArithmeticProgression actual = progression.Add(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetElement_FirstElement_ReturnsInitialElement()
        {
            IArithmeticProgression progression = new ArithmeticProgression(10, 5);
            double expected = 10;

            double actual = progression.GetElement(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetSum_FirstElement_ReturnsInitialElement()
        {
            IArithmeticProgression progression = new ArithmeticProgression(15, 10);
            double expected = 15;

            double actual = progression.GetSum(1);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Equals_TwoIdenticalProgressions_ReturnsTrue()
        {
            IArithmeticProgression p1 = new ArithmeticProgression(1, 2);
            IArithmeticProgression p2 = new ArithmeticProgression(1, 2);

            bool areEqual = p1.Equals(p2);

            Assert.IsTrue(areEqual);
        }

        [TestMethod]
        public void Equals_TwoDifferentProgressions_ReturnsFalse()
        {
            IArithmeticProgression p1 = new ArithmeticProgression(1, 2);
            IArithmeticProgression p2 = new ArithmeticProgression(1, 3);

            bool areEqual = p1.Equals(p2);

            Assert.IsFalse(areEqual);
        }
    }
}
