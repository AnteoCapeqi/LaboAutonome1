using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionBLL;
using System;

namespace TestFraction
{
    [TestClass]
    public class FractionObjectTest
    {
        [DataRow(new int[2] { 1, 1}, new int[2] { 1, 1}, DisplayName = "Creation d'une Fraction vide")]
        [DataRow(new int[2] { 4, 5 }, new int[2] { 4, 5 }, DisplayName = "Creation d'une Fraction lambda")]
        [TestMethod]
        public void CreateFractionObject(int[] ExpectedValue, int[] givenvalue)
        {
            Fraction fraction = new Fraction(givenvalue[0],givenvalue[1]);
            Assert.IsTrue(fraction.Denominateur == ExpectedValue[0] && fraction.Numerateur == ExpectedValue[1]);
        }
        [TestMethod]
        public void CreateFractionObjectValidateZeroDenominateur()
        {
            try
            {
                Fraction fraction = new Fraction(0, 1);
                Assert.Fail("Erreur attendue non rencontrée.");
            }
            catch (Exception ex) // <-- Expected Exception class
            {
                Assert.AreEqual("Le dénominateur ne peut etre egal a 0", ex.Message);
            }
        }
    }

}
