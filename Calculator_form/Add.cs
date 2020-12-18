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
        public static int[] Sum(int[] num1, int[] num2)
        {
            int[] ans = new int[26];
            for (int i = 0; i < 24; i++)
            {
                ans[i + 1] = (num1[i] + num2[i] + ans[i]) / 10000;
                ans[i] = (num1[i] + num2[i] + ans[i]) % 10000;
            }
            return ans;
        }
        public int[] interpret()
        {
            int[] int_num_1 = leftExpression.interpret();
            int[] int_num_2 = rightExpression.interpret();
            int[] ans = new int[26];

            if (int_num_1[25] == int_num_2[25])
            {
                ans = Sum(int_num_1, int_num_2);
                ans[25] = int_num_1[25];
            }
            else
            {
                if (Comparison.ComparisonFunc(int_num_1, int_num_2))
                {
                    // cnum_1 >= cnum_2
                    ans = Substract.Substraction(int_num_1, int_num_2);
                    if (int_num_1[25] == -1)
                    {
                        ans[25] = -1;
                    }
                    else
                    {
                        ans[25] = 1;
                    }
                }
                else
                {
                    // cnum_1 < cnum_2
                    ans = Substract.Substraction(int_num_2, int_num_1);
                    if (int_num_2[25] == -1)
                    {
                        ans[25] = -1;
                    }
                    else
                    {
                        ans[25] = 1;
                    }
                }
            }  
            return ans;
        }
    }
}
