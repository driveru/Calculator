using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Log : Expression
    {
        private Expression leftExpression;
        private Expression rightExpression;

        public Log(Expression leftExpression, Expression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public int[] interpret()
        {
            return ConverterUtils.ConvertToNewNumberSystem((Convert.ToInt32(Math.Log(double.Parse(ConverterUtils.ConvertToString(leftExpression.interpret())), double.Parse(ConverterUtils.ConvertToString(rightExpression.interpret()))))).ToString());
        }
    }
}
