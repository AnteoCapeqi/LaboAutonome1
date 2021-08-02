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

    }
}
