using Microsoft.VisualStudio.TestTools.UnitTesting;
using FractionBLL;

namespace TestFraction
{
    [TestClass]
    public class UnitTest1
    {
        [DataRow(new int[2] { 0, 0}, new int[2] { 0, 0}, DisplayName = "Creation d'une Fraction")]
        [TestMethod]
        public void CreateFractionObject(int[] ExpectedValue, int[] givenvalue)
        {
            Fraction fraction = new Fraction(givenvalue[0],givenvalue[1]);
            Assert.IsTrue(fraction.Numerateur == ExpectedValue[0] && fraction.Denominateur == ExpectedValue[1]);

        }
    }
}
