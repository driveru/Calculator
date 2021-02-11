using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Subtract : IExpression
    {
        public const string Description = "-";
        private IExpression leftExpression;
        private IExpression rightExpression;

        public Subtract(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public static BigInteger Subtraction(BigInteger first_num, BigInteger second_num) //second_num <= first_num
        {
            Part first = first_num.head;
            Part second = second_num.head;
            while (second.Next != null)
            {
                first = first.Next;
                second = second.Next;
                if (second.value > first.value)
                {
                    first.Next.value--;
                    first.value = first.value + 10000 - second.value;
                }
                else
                {
                    first.value = first.value - second.value;
                }
            }
            return first_num.smooth();
        }
        public BigInteger interpret()
        {
            BigInteger num = rightExpression.interpret();
            num.is_negative = !num.is_negative;
            rightExpression = new Number(num);
            BigInteger ans = new Add(leftExpression, rightExpression).interpret();
            return ans;
        }
    }
}
