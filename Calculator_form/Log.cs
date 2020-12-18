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
        public int[] interpret()
        {
            return new Number(Math.Log(double.Parse(ConverterUtils.ConvertToString(leftExpression.interpret())), double.Parse(ConverterUtils.ConvertToString(rightExpression.interpret()))).ToString()).interpret();
        }
    }
}
