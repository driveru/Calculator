using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    public class Division : IExpression
    {
        public const string Description = "/";
        private IExpression leftExpression;
        private IExpression rightExpression;

        public Division(IExpression leftExpression, IExpression rightExpression)
        {
            this.leftExpression = leftExpression;
            this.rightExpression = rightExpression;
        }
        private int FindHighBit(int[] num)
        {
            int i = 24;
            while (num[i] == 0) { i--; }
            return i;
        }
        private void MoveToRight(int[] num)
        {
            for (int i = 0; i < 24; i++)
            {
                num[i] = num[i + 1];
            }
        }
        public int[] interpret()
        {
            int[] ans = new int[26];
            int[] divident = leftExpression.interpret();
            int[] divider = rightExpression.interpret();
            int divident_high_bit = FindHighBit(divident);
            int divider_high_bit = FindHighBit(divider);
            for (int i = divider_high_bit; i > 0; i--)
            {
                divider[i + (divident_high_bit - divider_high_bit)] = divider[i];
            }
            //long num1 = long.Parse(ConverterUtils.ConvertToString(leftExpression.interpret()));
            //long num2 = long.Parse(ConverterUtils.ConvertToString(rightExpression.interpret()));

            while (divident_high_bit > divider_high_bit)
            {
                if (Comparison.ComparisonFunc(divident, divider))
                {
                    ans[divident_high_bit - divider_high_bit]++;
                    divident = (new Substract(new Number(divident), new Number(divider))).interpret();
                    divident_high_bit = FindHighBit(divident);
                }
                else 
                {
                    MoveToRight(divider);
                }
            }
            return ans;
        }
    }
} 
