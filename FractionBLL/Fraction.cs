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
                decimal tempRes = fraction.Numerateur / fraction.Denominateur;
                int res =decimal.ToInt32(tempRes);
                fraction.Numerateur = fraction.Numerateur % fraction.Denominateur;
                SimpleFraction = new Tuple<int, int, int>(res, fraction.Numerateur, fraction.Denominateur);
            } else if(fraction.Numerateur == fraction.Denominateur)
            {
                int res = fraction.Numerateur / fraction.Denominateur;
                SimpleFraction = new Tuple<int, int, int>(res, 1, 1);
            }
            else
            {
                SimpleFraction = new Tuple<int, int, int>(0, fraction.Numerateur, fraction.Denominateur);
            }
            return SimpleFraction;
        }
        public static Fraction MathSimplification(Fraction fraction) 
        {
            int PGCD = (int)GCD((ulong)fraction.Denominateur,(ulong)fraction.Numerateur);
            if (PGCD != 1)
            {
                fraction.Denominateur = fraction.Denominateur / PGCD;
                fraction.Numerateur = fraction.Numerateur / PGCD;
            }
            return fraction;
        }
        private static ulong GCD(ulong a, ulong b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a %= b;
                else
                    b %= a;
            }

            return a == 0 ? b : a;
        }

        public static Fraction operator +(Fraction a, Fraction b) 
        {
            Fraction res = new Fraction(1,1);
            Tuple < Fraction, Fraction, Fraction > temp = DenominateurCommun(a, b, res);
            a = temp.Item1;
            b = temp.Item2;
            res = temp.Item3;
            res.Numerateur = a.Numerateur + b.Numerateur;
            res = Fraction.MathSimplification(res);
            return res;
        }
        public static Fraction operator -(Fraction a, Fraction b)
        {
            Fraction res = new Fraction(1, 1);
            Tuple<Fraction, Fraction, Fraction> temp = DenominateurCommun(a, b, res);
            a = temp.Item1;
            b = temp.Item2;
            res = temp.Item3;
            res.Numerateur = a.Numerateur - b.Numerateur;
            res = Fraction.MathSimplification(res);
            return res;
        }
        private static Tuple<Fraction, Fraction, Fraction> DenominateurCommun(Fraction a, Fraction b, Fraction res) 
        {
            if (a.Denominateur != b.Denominateur)
            {
                int calc = a.Denominateur * b.Denominateur;
                a.Numerateur *= b.Denominateur;
                b.Numerateur *= a.Denominateur;
                a.Denominateur = calc;
                b.Denominateur = calc;
                res.Denominateur = calc;
            }
            else
            {
                res.Denominateur = a.Denominateur;
            }
            return new Tuple<Fraction, Fraction, Fraction>(a,b,res);
        }

    }
}
