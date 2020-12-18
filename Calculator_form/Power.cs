using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Power : IExpression
    {
        public const string Description = "^";
        private IExpression leftExpression;
        private IExpression rightExpression;

        public Power(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public int[] interpret()
        {
            return new Number(Math.Pow(double.Parse(ConverterUtils.ConvertToString(leftExpression.interpret())), double.Parse(ConverterUtils.ConvertToString(rightExpression.interpret()))).ToString()).interpret();
        }
    }
}
