using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Comparison
    {
        public static bool ComparisonFunc(int[] int_num_1, int[] int_num_2) //возвращает true если num1 >= num2
        {
            for (int i = 24; i > -1; i--)
            {
                if (int_num_1[i] > int_num_2[i])
                {
                    return true;
                }
                else
                {
                    if (int_num_1[i] < int_num_2[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
