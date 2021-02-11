using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class CalculateExpression
    {
        static public string CalculateTree(List<string> expression)
        {
            try
            {
                Stack<IExpression> stack = new Stack<IExpression>();
                foreach (string s in expression)
                {
                    if (ExpressionUtils.isOperator(s))
                    {
                        IExpression rightExpression = stack.Pop();
                        IExpression leftExpression = stack.Pop();
                        IExpression oper = ExpressionUtils.getOperator(s, leftExpression, rightExpression);
                        BigInteger result = oper.interpret();
                        stack.Push(new Number(result));
                    }
                    else
                    {
                        stack.Push(new Number(s));
                    }
                }
                return stack.Pop().interpret().ToString();
            }
            catch (BadImageFormatException e)
            {
                return e.Message;
            }
        }
    }
}
