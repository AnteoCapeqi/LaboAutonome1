using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionBLL
{
    public class ArithLogs : Logs
    {
        public string Fraction_Res { get; set; }
        public ArithLogs(string date, string heure, string f1, string op, string f2, string res)
        {
            this.Date = date;
            this.Heure = heure;
            this.Fraction_1 = f1;
            this.Operant = op;
            this.Fraction_2 = f2;
            this.Fraction_Res = res;
        }
    }
}
