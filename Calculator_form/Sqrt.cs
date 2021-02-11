using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Sqrt : UnaryOperation, IExpression
    {
        public const string Description = "s";

        public Sqrt(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
        }
        public BigInteger interpret()
        {
            try
            {
                return new Number(Math.Round(Math.Sqrt(double.Parse(leftExpression.interpret().ToString()))).ToString()).interpret();
            }
            catch (Exception)
            {
                throw new NegativeNumberSqrt();
            }
        }
    }
}
