using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionBLL;
using System;

namespace TestFraction
{
    [TestClass]
    public class FractionConversionTest
    {
        [DataRow(1D, new int[2] { 1, 1 }, DisplayName = "Conversion de 1/1 en decimal")]
        [DataRow(0.8D, new int[2] { 5, 4 }, DisplayName = "Conversion de 4/5 en decimal")]
        [TestMethod]
        public void ConversionFractionToDecimal(double ExpectedValue, int[] givenvalue)
        {
            Fraction fraction = new Fraction(givenvalue[0], givenvalue[1]);
            decimal res = (decimal)fraction;
            Assert.IsTrue(res == (decimal)ExpectedValue,res.ToString() +"   " + fraction.ToString());
        }
        [DataRow(new int[2] { 5, 4 }, 0.8D, DisplayName = "Conversion de 0.8 en Fraction ")]
        [DataRow(new int[2] { 1, 1 }, 1D, DisplayName = "Conversion de 1 en Fraction ")]
        [DataRow(new int[2] { 20, 1 }, 0.05D, DisplayName = "Conversion de 0.05 en Fraction ")]
        [TestMethod]
        public void ConversionDecimalToFraction(int[] ExpectedValue, double givenvalue)
        {
            decimal res = (decimal)givenvalue;
            Fraction fraction = (Fraction)res;
            Assert.IsTrue(fraction.Denominateur == ExpectedValue[0] && fraction.Numerateur == ExpectedValue[1],
                fraction.Numerateur.ToString() + "/" + fraction.Denominateur.ToString());
        }

    }

}
