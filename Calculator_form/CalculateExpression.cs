using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class CalculateExpression
    {
        static public string CalculateTree(List<string> expression)
        {
            Stack<Expression> stack = new Stack<Expression>();
            foreach (string s in expression)
            {
                if (ExpressionUtils.isOperator(s))
                {
                    Expression rightExpression = stack.Pop();
                    Expression leftExpression = stack.Pop();
                    Expression oper = ExpressionUtils.getOperator(s, leftExpression, rightExpression);
                    int[] result = oper.interpret();
                    stack.Push(new Number(result));
                }
                else
                {
                    stack.Push(new Number(ConverterUtils.ConvertToNewNumberSystem(s)));
                }
            }
            return ConverterUtils.ConvertToString(stack.Pop().interpret());
        }
    }
}
