using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Log : BinaryOperation, IExpression
    {
        public const string Description = "l";

        public Log(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public BigInteger interpret()
        {
            try
            {
                return new Number(Math.Round(Math.Log(double.Parse(leftExpression.interpret().ToString()), double.Parse(rightExpression.interpret().ToString()))).ToString()).interpret();
            }
            catch (Exception)
            {
                throw new LogException();
            }
        }
    }
}
