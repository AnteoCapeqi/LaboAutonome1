using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionBLL;
using System;

namespace TestFraction
{
    [TestClass]
    public class FractionSimplificationTest
    {
        [DataRow(new int[3] { 1, 1 , 1}, new int[2] { 5, 5 }, DisplayName = "Simplification d'une Fraction lambda 1")]
        [DataRow(new int[3] { 1, 1 , 4 } ,new int[2] { 4, 5 }, DisplayName = "Simplification d'une Fraction lambda 2")]
        [DataRow(new int[3] { 0, 1, 4 }, new int[2] { 4, 1 }, DisplayName = "Simplification d'une Fraction lambda 3")]
        [DataRow(new int[3] { 10, 3, 4 }, new int[2] { 4, 43 }, DisplayName = "Simplification d'une Fraction lambda 4")]
        [TestMethod]
        public void FractionUserSimplificationTest(int[] ExpectedValue, int[] givenvalue)
        {
            Fraction fraction = new Fraction(givenvalue[0], givenvalue[1]);
            Tuple<int, int, int> SimpleFraction = Fraction.UserSimplification(fraction); 
            Assert.IsTrue(SimpleFraction.Item1 == ExpectedValue[0] 
                && SimpleFraction.Item2 == ExpectedValue[1]
                && SimpleFraction.Item3 == ExpectedValue[2]);
            
        }
        [DataRow(new int[2] { 1 , 5 }, new int[2] { 5 , 1 }, DisplayName = "Simplification d'une Fraction lambda 1")]
        [DataRow(new int[2] { 1, 5 }, new int[2] { 25, 5 }, DisplayName = "Simplification d'une Fraction lambda 2")]
        [DataRow(new int[2] { 30 , 1 }, new int[2] { 4 , 120 }, DisplayName = "Simplification d'une Fraction lambda 3")]
        [DataRow(new int[2] { 3, 1 }, new int[2] { 15, 45 }, DisplayName = "Simplification d'une Fraction lambda 3")]
        [TestMethod]
        public void FractionMathSimplificationTest(int[] ExpectedValue, int[] givenvalue)
        {
            Fraction fraction = new Fraction(givenvalue[0], givenvalue[1]);
            Fraction SimpleFraction = Fraction.MathSimplification(fraction);
            Assert.IsTrue(SimpleFraction.Numerateur == ExpectedValue[0]
                && SimpleFraction.Denominateur == ExpectedValue[1],
                SimpleFraction.Numerateur.ToString() + SimpleFraction.Denominateur.ToString());

        }


    }

}
