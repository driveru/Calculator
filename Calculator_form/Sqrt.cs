using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Sqrt : IExpression
    {
        public const string Description = "s";
        private IExpression leftExpression;
        private IExpression rightExpression;

        public Sqrt(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public int[] interpret()
        {
            try
            {
                return new Number(Math.Sqrt(double.Parse(ConverterUtils.ConvertToString(leftExpression.interpret()))).ToString()).interpret();
            }
            catch (Exception)
            {
                throw new NegativeNumberSqrt();
            }
        }
    }
}
