using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    public class Add : IExpression
    {
        public const string Description = "+";
        private IExpression leftExpression;
        private IExpression rightExpression;

        public Add(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public static BigInteger Sum(BigInteger first_num, BigInteger second_num)
        {
            BigInteger ans_num = new BigInteger();
            Part first = first_num.head;
            Part second = second_num.head;
            Part ans = new Part(ans_num.head);
            while (first.Next != null && second.Next != null)
            {
                first = first.Next;
                second = second.Next;
                ans.Next = new Part((first.value + second.value + ans.value) / 10000);
                ans.value = (first.value + second.value + ans.value) % 10000;
                ans = ans.Next;
            }
            Part cur = (first.Next == null) ? second : first;
            while (cur.Next != null)
            {
                cur = cur.Next;
                ans.Next = new Part((cur.value + ans.value) / 10000);
                ans.value = (cur.value + ans.value) % 10000;
                ans = ans.Next;
            }
            return ans_num.smooth();
        }
        public BigInteger interpret()
        {
            BigInteger first_num = leftExpression.interpret();
            BigInteger second_num = rightExpression.interpret();
            BigInteger ans = new BigInteger();
            if (first_num.is_negative && second_num.is_negative)
            {
                ans = Sum(first_num, second_num);
                ans.is_negative = true;
            }
            else if (!first_num.is_negative && second_num.is_negative)
            {
                //int flag = Comparision.Compare(first_num, second_num);
                if (Comparison.Compare(first_num, second_num))
                {
                    ans = Subtract.Subtraction(first_num, second_num);
                }
                else
                {
                    ans = Subtract.Subtraction(second_num, first_num);
                    ans.is_negative = true;
                }
            }
            else if (first_num.is_negative && !second_num.is_negative)
            {
                //int flag = Comparision.Compare(first_num, second_num);
                if (Comparison.Compare(first_num, second_num))
                {
                    ans = Subtract.Subtraction(first_num, second_num);
                    ans.is_negative = true;
                }
                else
                {
                    ans = Subtract.Subtraction(second_num, first_num);
                }
            }
            else { ans = Sum(first_num, second_num); }
            return ans;
        }
    }
}
