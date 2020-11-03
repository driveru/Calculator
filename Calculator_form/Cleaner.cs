using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_form
{
    class Cleaner
    {
        static public void ClearExpressionConverter()
        {
            for (int i = 0; i < 101; ConvertExpression.converted_expression[i++] = "") { }
            ConvertExpression.k = -1;
        }
    }
}
