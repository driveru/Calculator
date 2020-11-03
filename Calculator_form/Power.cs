using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Power : Expression
    {
        private Expression leftExpression;
        private Expression rightExpression;

        public Power(Expression leftExpression, Expression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public int[] interpret()
        {
            return ConverterUtils.ConvertToNewNumberSystem((Convert.ToInt32(Math.Pow(double.Parse(ConverterUtils.ConvertToString(leftExpression.interpret())), double.Parse(ConverterUtils.ConvertToString(rightExpression.interpret()))))).ToString());
        }
    }
}
