using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class ExpressionUtils
    {
        public static bool isOperator(string s)
        {
            if ((s == "+") || (s == "-") || (s == "*") || (s == "/") || (s == "l") || (s == "s") || (s == "^"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static Expression getOperator(string s, Expression left, Expression right)
        {
            switch (s)
            {
                case "+":
                    return new Add(left, right);
                case "-":
                    return new Substract(left, right);
                case "*":
                    return new Multiply(left, right);
                case "/":
                    return new Division(left, right);
                case "l":
                    return new Log(left, right);
                case "s":
                    return new Sqrt(left, right);
                case "^":
                    return new Power(left, right);
            }
            return null;
        }
    }
}
