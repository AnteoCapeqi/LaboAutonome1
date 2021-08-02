using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionBLL;
using System;

namespace TestFraction
{
    [TestClass]
    public class FractionOperationTest
    {
        //[1,2]Longueur de 2 => int[2] {1,2}
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

        [DataRow(new int[2] { 1, 1 }, new int[4] { 1, 1, 1, 1 }, DisplayName = "1/1 * 1/1 = 1/1")]
        [DataRow(new int[2] { 25, 4 }, new int[4] { 5, 1, 5, 4 }, DisplayName = "1/5 * 4/5 = 4/25")]
        [DataRow(new int[2] { 15, 4 }, new int[4] { 3, 4, 5, 1 }, DisplayName = "4/3 * 1/5 = 4/15")]
        [DataRow(new int[2] { 1, 20 }, new int[4] { 3, 4, 1, 15 }, DisplayName = "4/3 * 15/1 = 20/1")]
        [TestMethod]
        public void MultiplicationFractionObject(int[] ExpectedValue, int[] givenvalue)
        {
            Fraction fraction1 = new Fraction(givenvalue[0], givenvalue[1]);
            Fraction fraction2 = new Fraction(givenvalue[2], givenvalue[3]);
            Fraction res = fraction1 * fraction2;
            Assert.IsTrue(res.Denominateur == ExpectedValue[0] && res.Numerateur == ExpectedValue[1],
                "Resultat : " + res.Numerateur + "/" + (res.Denominateur)
                + " Execpted Value : " + ExpectedValue[1] +"/" + ExpectedValue[0]);
        }

        [DataRow(new int[2] { 1, 1 }, new int[4] { 1, 1, 1, 1 }, DisplayName = "1/1 / 1/1 = 1/1")]
        [DataRow(new int[2] { 4, 1 }, new int[4] { 5, 1, 5, 4 }, DisplayName = "1/5 / 4/5 = 5/20")]
        [DataRow(new int[2] { 44, 5 }, new int[4] { 11, 1, 5, 4 }, DisplayName = "1/11 / 4/5 = 5/44")]
        [DataRow(new int[2] { 3, 20 }, new int[4] { 3, 4, 5, 1 }, DisplayName = "4/3 / 1/5 = 20/3")]
        [TestMethod]
        public void DivisionFractionObject(int[] ExpectedValue, int[] givenvalue)
        {
            Fraction fraction1 = new Fraction(givenvalue[0], givenvalue[1]);
            Fraction fraction2 = new Fraction(givenvalue[2], givenvalue[3]);
            Fraction res = fraction1 / fraction2;
            Assert.IsTrue(res.Denominateur == ExpectedValue[0] && res.Numerateur == ExpectedValue[1],
                "Resultat : " + res.Numerateur.ToString() + "/" + res.Denominateur.ToString());
        }

    }

}
