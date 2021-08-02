
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionBLL;
using System;

namespace TestFraction
{
    [TestClass]
    public class FractionComparatorTest
    {
        [DataRow(true, new int[4] { 5, 4 ,5 ,3 }, DisplayName = "4/5 > 3/5 || True")]
        [DataRow(false, new int[4] { 2, 1, 5, 4 }, DisplayName = "1/2 > 4/5 || False")]
        [TestMethod]
        public void FractionBiggerThenTest(bool ExpectedValue, int[] givenvalue)
        {
            Fraction fraction1 = new Fraction(givenvalue[0], givenvalue[1]);
            Fraction fraction2 = new Fraction(givenvalue[2], givenvalue[3]);
            bool token = fraction1 > fraction2;
            Assert.IsTrue(ExpectedValue == token,
                fraction1.ToString() + " > " + fraction2.ToString());
        }

        [DataRow(true, new int[4] { 5, 4, 5, 3 }, DisplayName = "4/5 > 3/5 || True")]
        [DataRow(false, new int[4] { 2, 1, 5, 4 }, DisplayName = "1/2 > 4/5 || False")]
        [DataRow(true, new int[4] { 2, 1, 8, 4 }, DisplayName = "1/2 > 8/4 || True")]
        [TestMethod]
        public void FractionBiggerOrEqualToTest(bool ExpectedValue, int[] givenvalue)
        {
            Fraction fraction1 = new Fraction(givenvalue[0], givenvalue[1]);
            Fraction fraction2 = new Fraction(givenvalue[2], givenvalue[3]);
            bool token = fraction1 >= fraction2;
            Assert.IsTrue(ExpectedValue == token,
                fraction1.ToString() + " >= " + fraction2.ToString());
        }


        [DataRow(false, new int[4] { 5, 4, 5, 3 }, DisplayName = "4/5 > 3/5 || False")]
        [DataRow(true, new int[4] { 2, 1, 5, 4 }, DisplayName = "1/2 > 4/5 || True")]
        [TestMethod]
        public void FractionSmallerThenTest(bool ExpectedValue, int[] givenvalue)
        {
            Fraction fraction1 = new Fraction(givenvalue[0], givenvalue[1]);
            Fraction fraction2 = new Fraction(givenvalue[2], givenvalue[3]);
            bool token = fraction1 < fraction2;
            Assert.IsTrue(ExpectedValue == token,
                fraction1.ToString() + " < " + fraction2.ToString());
        }

        [DataRow(false, new int[4] { 5, 4, 5, 3 }, DisplayName = "4/5 > 3/5 || False")]
        [DataRow(true, new int[4] { 2, 1, 5, 4 }, DisplayName = "1/2 > 4/5 || True")]
        [DataRow(true, new int[4] { 2, 1, 8, 4 }, DisplayName = "1/2 > 4/8 || True")]
        [TestMethod]
        public void FractionSmallerOrEqualToTest(bool ExpectedValue, int[] givenvalue)
        {
            Fraction fraction1 = new Fraction(givenvalue[0], givenvalue[1]);
            Fraction fraction2 = new Fraction(givenvalue[2], givenvalue[3]);
            bool token = fraction1 <= fraction2;
            Assert.IsTrue(ExpectedValue == token,
                fraction1.ToString() + " <= " + fraction2.ToString());
        }

        [DataRow(false, new int[4] { 5, 4, 5, 3 }, DisplayName = "4/5 > 3/5 || False")]
        [DataRow(false, new int[4] { 2, 1, 5, 4 }, DisplayName = "1/2 > 4/5 || False")]
        [DataRow(true, new int[4] { 2, 1, 8, 4 }, DisplayName = "1/2 > 4/8 || True")]
        [TestMethod]
        public void FractionSigneEqualToTest(bool ExpectedValue, int[] givenvalue)
        {
            Fraction fraction1 = new Fraction(givenvalue[0], givenvalue[1]);
            Fraction fraction2 = new Fraction(givenvalue[2], givenvalue[3]);
            bool token = fraction1 == fraction2;
            Assert.IsTrue(ExpectedValue == token,
                fraction1.ToString() + " == " + fraction2.ToString());
        }
        [DataRow(true, new int[4] { 5, 4, 5, 3 }, DisplayName = "4/5 > 3/5 || True")]
        [DataRow(true, new int[4] { 2, 1, 5, 4 }, DisplayName = "1/2 > 4/5 || True")]
        [DataRow(false, new int[4] { 2, 1, 8, 4 }, DisplayName = "1/2 > 4/8 || False")]
        [TestMethod]
        public void FractionNotEqualToTest(bool ExpectedValue, int[] givenvalue)
        {
            Fraction fraction1 = new Fraction(givenvalue[0], givenvalue[1]);
            Fraction fraction2 = new Fraction(givenvalue[2], givenvalue[3]);
            bool token = fraction1 != fraction2;
            Assert.IsTrue(ExpectedValue == token,
                fraction1.ToString() + " != " + fraction2.ToString());
        }
        [DataRow(false, new int[4] { 5, 4, 5, 3 }, DisplayName = "4/5 > 3/5 || False")]
        [DataRow(false, new int[4] { 2, 1, 5, 4 }, DisplayName = "1/2 > 4/5 || False")]
        [DataRow(true, new int[4] { 2, 1, 8, 4 }, DisplayName = "1/2 > 4/8 || True")]
        [TestMethod]
        public void FractionEqualToTest(bool ExpectedValue, int[] givenvalue)
        {
            Fraction fraction1 = new Fraction(givenvalue[0], givenvalue[1]);
            Fraction fraction2 = new Fraction(givenvalue[2], givenvalue[3]);
            bool token = fraction1.Equals(fraction2);
            Assert.IsTrue(ExpectedValue == token,
                fraction1.ToString() + " == " + fraction2.ToString());
        }


    }

}
