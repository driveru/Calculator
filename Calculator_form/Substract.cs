using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Substract : Expression
    {
        private Expression leftExpression;
        private Expression rightExpression;

        public Substract(Expression leftExpression, Expression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public static int[] Substraction(int[] int_num_1, int[] int_num_2) //num1 >= num2, num1 - num2
        {
            int[] ans = new int[26];
            for (int i = 0; i < 24; i++)
            {
                if (int_num_1[i] < int_num_2[i])
                {
                    ans[i] = int_num_1[i] + 10000 - int_num_2[i];
                    int_num_1[i + 1] -= 1;
                }
                else
                {
                    ans[i] = int_num_1[i] - int_num_2[i];
                }
            }
            return ans;
        }
        public int[] interpret()
        {
            int[] int_num_2 = rightExpression.interpret();
            int_num_2[25] *= -1;
            rightExpression = new Number(int_num_2);
            int[] ans = new Add(leftExpression, rightExpression).interpret();
            return ans;
        }
    }
}
