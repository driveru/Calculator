using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Division : BinaryOperation, IExpression
    {
        public const string Description = "/";

        public Division(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public BigInteger interpret()
        {
            BigInteger devident = leftExpression.interpret();
            BigInteger devisor = rightExpression.interpret();
            if (devisor.head.Next == null)
            {
                throw new DivideByZeroException();
            }
            BigInteger ans = new BigInteger();
            BigInteger slice = new BigInteger();

            ans.is_negative = devident.is_negative ^ devisor.is_negative;

            foreach (Part cur in devident)
            {
                slice.AddHead(new Part(cur.value));
                if (Comparison.Compare(slice, devisor))
                {
                    (BigInteger to_subtract, int to_ans) = FindResut(slice, devisor);
                    Subtract.Subtraction(slice, to_subtract);
                    ans.AddHead(new Part(to_ans));
                }
                else
                    ans.AddHead(new Part());
            }
            return ans.smooth();
        }
        public static (BigInteger num, int result) FindResut(BigInteger devident, BigInteger devisor)
        {
            int result;
            int right = 9999;
            int left = 0;
            while (left <= right)
            {
                result = (left + right) / 2;
                BigInteger help_num = new Multiply(new Number(devisor), new Number(new BigInteger(result))).interpret();

                if (Comparison.Compare(devident, help_num))
                {
                    if (!Comparison.Compare(devident, Add.Sum(help_num, devisor)))
                        return (help_num, result);
                    else
                        left = result;
                }
                else
                    right = result;
            }
            return (new BigInteger(), -1);
        }
    }
} 
