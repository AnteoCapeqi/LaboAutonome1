using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionBLL;
using System;

namespace TestFraction
{
    [TestClass]
    public class FractionOperationTest
    {
        [DataRow(new int[2] { 1, 2 }, new int[4] { 1, 1, 1 , 1 }, DisplayName = "1/1 + 1/1 = 2/1")]
        [DataRow(new int[2] { 1, 1 }, new int[4] { 5, 4 , 5 , 1 }, DisplayName = "4/5 + 1/5 = 1/1")]
        [DataRow(new int[2] { 15, 23 }, new int[4] { 3, 4, 5, 1 }, DisplayName = "4/3 + 1/5 = 23/15")]
        [TestMethod]
        public void AdditionFractionObject(int[] ExpectedValue, int[] givenvalue)
        {
            Fraction fraction1 = new Fraction(givenvalue[0], givenvalue[1]);
            Fraction fraction2 = new Fraction(givenvalue[2], givenvalue[3]);
            Fraction res = fraction1 + fraction2;
            Assert.IsTrue(res.Denominateur == ExpectedValue[0] && res.Numerateur == ExpectedValue[1],
                res.Numerateur.ToString() + "/" + res.Denominateur.ToString());
        }
        [DataRow(new int[2] { 1, 2 }, new int[4] { 1, 1, 1, 1 }, DisplayName = "1/1 - 1/1 = 0/1")]
        [DataRow(new int[2] { 1, 1 }, new int[4] { 5, 1, 5, 4 }, DisplayName = "1/5 - 4/5 = -3/1")]
        [DataRow(new int[2] { 15, 23 }, new int[4] { 3, 4, 5, 1 }, DisplayName = "4/3 - 1/5 = 17/15")]
        [TestMethod]
        public void SoustractionFractionObject(int[] ExpectedValue, int[] givenvalue)
        {
            Fraction fraction1 = new Fraction(givenvalue[0], givenvalue[1]);
            Fraction fraction2 = new Fraction(givenvalue[2], givenvalue[3]);
            Fraction res = fraction1 + fraction2;
            Assert.IsTrue(res.Denominateur == ExpectedValue[0] && res.Numerateur == ExpectedValue[1],
                res.Numerateur.ToString() + "/" + res.Denominateur.ToString());
        }

    }

}
