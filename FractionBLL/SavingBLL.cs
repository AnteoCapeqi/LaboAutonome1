using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FractionDAL;

namespace FractionBLL
{
    public class SavingBLL
    {
        public static void CallDALMethodArith(Fraction fraction1,Fraction fraction2,string ope,Fraction fraction3) 
        {
            SavingToFile.SaveToArithLog(new Tuple<string, string, string, string>
                (fraction1.ToString(),
                ope,
                fraction2.ToString(),
                fraction3.ToString())
                );
        }
        public static void CallDALMethodCompa(Fraction fraction1, Fraction fraction2, string ope, string res)
        {
            SavingToFile.SaveToCompaLog(new Tuple<string, string, string, string>
                (fraction1.ToString(),
                ope,
                fraction2.ToString(),
                res)
                );
        }
    }
}
