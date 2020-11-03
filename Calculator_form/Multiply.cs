using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Multiply : Expression
    {
        private Expression leftExpression;
        private Expression rightExpression;

        public Multiply(Expression leftExpression, Expression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        public int[] interpret()
        {
            int[] ans = new int[26];
            int[] int_num_1 = leftExpression.interpret();
            int[] int_num_2 = rightExpression.interpret();
            int j;

            for (int i = 0; i < 12; i++)
            {
                j = i;
                int[] help_num = new int[26];
                for (int k = 0; k < 12; k++)
                {
                    help_num[j + 1] = (int_num_2[i] * int_num_1[k]) / 10000;
                    help_num[j] = ((int_num_2[i] * int_num_1[k]) % 10000) + help_num[j];
                    j++;
                }
                ans = Add.Sum(ans, help_num);
            }
            ans[25] = int_num_1[25] * int_num_2[25];
            return ans;
        }
    }
}
