using System;

namespace FractionBLL
{
    public class Fraction 
    {

        private int numerateur;
        public int Numerateur
        {
            get { return numerateur; }
            set { numerateur = value; }
        }
        private int denominateur;
        public int Denominateur
        {
            get { return denominateur; }
            set {
                if (value == 0)
                {
                    throw new Exception("Le dénominateur ne peut etre plus petit que 0");
                }
                else
                {
                    denominateur = value;
                }

            }
        }

        public Fraction(int pDenominateur, int pNumerateur)
        {
            this.Denominateur = pDenominateur;
            this.Numerateur = pNumerateur;
        }

        public static Tuple<int,int,int> UserSimplification(Fraction fraction) 
        {
            Tuple<int, int, int> SimpleFraction = new Tuple<int, int, int>( 0, 0, 0 );
            if (fraction.numerateur > fraction.Denominateur)
            {
                decimal tempRes = fraction.numerateur / fraction.denominateur;
                int res =decimal.ToInt32(tempRes);
                fraction.numerateur = fraction.numerateur % fraction.denominateur;
                SimpleFraction = new Tuple<int, int, int>(res, fraction.numerateur, fraction.denominateur);
            } else if(fraction.numerateur == fraction.Denominateur)
            {
                int res = fraction.numerateur / fraction.denominateur;
                SimpleFraction = new Tuple<int, int, int>(res, 1, 1);
            }
            else
            {
                SimpleFraction = new Tuple<int, int, int>(0, fraction.numerateur, fraction.denominateur);
            }
            return SimpleFraction;
        }
        //public static Fraction MathSimplification()
        //{
        //}
    }
}
