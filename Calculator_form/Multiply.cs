using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Multiply : BinaryOperation, IExpression
    {
        public const string Description = "*";

        public Multiply(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public BigInteger interpret()
        {
            BigInteger first_num = leftExpression.interpret();
            BigInteger second_num = rightExpression.interpret();
            BigInteger ans_num = new BigInteger();
            int shift = 0;
            for (Part first = first_num.head.Next; first != null; first = first.Next)
            {
                BigInteger help_num = new BigInteger();
                Part help = new Part(help_num.head);
                for (int i = 0; i < shift; help = new Part(help), i++) ;
                for (Part second = second_num.head.Next; second != null; second = second.Next)
                {
                    help.Next = new Part(help, (first.value * second.value + help.value) / 10000);
                    help.value = (first.value * second.value + help.value) % 10000;
                    help = help.Next;
                }
                ans_num = Add.Sum(ans_num, help_num);
                shift++;
            }
            ans_num.is_negative = first_num.is_negative ^ second_num.is_negative;
            return ans_num.smooth();
        }
    }
}
