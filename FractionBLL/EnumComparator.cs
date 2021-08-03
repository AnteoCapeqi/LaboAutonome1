using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FractionBLL
{
    public enum Comparator 
    {
        BiggerThen = '>',
        BiggerOrEqualThen = '>'+'=',
        SmallerThen = '<',
        SmallerOrEqualThen = '<' + '=',
        EqualTo = '=' + '=',
        NotEqualTo = '!' + '='
    }
}
