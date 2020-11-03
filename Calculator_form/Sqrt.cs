using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Sqrt : Expression
    {
        private Expression leftExpression;
        private Expression rightExpression;

        public Sqrt(Expression leftExpression, Expression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public int[] interpret()
        {
            return ConverterUtils.ConvertToNewNumberSystem((Convert.ToInt32(Math.Sqrt(double.Parse(ConverterUtils.ConvertToString(leftExpression.interpret()))))).ToString());
        }
    }
}
