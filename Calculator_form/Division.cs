using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    public class Division : Expression
    {
        private Expression leftExpression;
        private Expression rightExpression;

        public Division(Expression leftExpression, Expression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public int[] interpret()
        {
            return ConverterUtils.ConvertToNewNumberSystem((long.Parse(ConverterUtils.ConvertToString(leftExpression.interpret())) / long.Parse(ConverterUtils.ConvertToString(rightExpression.interpret()))).ToString());
        }
    }
}
