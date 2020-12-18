using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_form
{
    class RoundBracketException : Exception
    {
        public RoundBracketException()
            : base("Нарушена вложенность скобок!")
        {
        }  
    }
    class NegativeNumberSqrt : Exception
    {
        public NegativeNumberSqrt()
            : base("Корень из отрицального числа!")
        {
        }
    }
}
