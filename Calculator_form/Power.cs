using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Power : BinaryOperation, IExpression
    {
        public const string Description = "^";

        public Power(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public BigInteger interpret()
        {
            return new Number(Math.Pow(double.Parse(leftExpression.interpret().ToString()), double.Parse(rightExpression.interpret().ToString())).ToString()).interpret();
        }
    }
}
