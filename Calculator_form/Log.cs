using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Log : IExpression
    {
        public const string Description = "l";
        private IExpression leftExpression;
        private IExpression rightExpression;

        public Log(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public BigInteger interpret()
        {
            return new Number(Math.Log(double.Parse(leftExpression.interpret().ToString()), double.Parse(rightExpression.interpret().ToString())).ToString()).interpret();
        }
    }
}
