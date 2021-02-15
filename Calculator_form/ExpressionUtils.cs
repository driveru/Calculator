using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class ExpressionUtils
    {
        public static IExpression getOperator(string s, IExpression left, IExpression right)
        {
            switch (s)
            {
                case Add.Description:
                    return new Add(left, right);
                case Subtract.Description:
                    return new Subtract(left, right);
                case Multiply.Description:
                    return new Multiply(left, right);
                case Division.Description:
                    return new Division(left, right);
                case Log.Description:
                    return new Log(left, right);
                case Sqrt.Description:
                    return new Sqrt(left, right);
                case Power.Description:
                    return new Power(left, right);
            }
            return null;
        }
    }
}
