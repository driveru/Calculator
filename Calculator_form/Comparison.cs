using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Comparison
    {
        static public bool Compare(BigInteger first_num, BigInteger second_num) // return true if first_num >= second_num
        {
            Part first = first_num.head;
            Part second = second_num.head;
            if (Compare_rec(first, second, 0) == 2)
                return false;
            return true;
        }

        static private int Compare_rec(Part first, Part second, int flag) // flag: 0 - unknown, 1 - first > second, 2 - seecond > first
        {
            if (first.Next != null && second.Next != null)
            {
                flag = Compare_rec(first.Next, second.Next, 0);
            }
            if (first.Next == null && second.Next != null) { return 2; }
            if (first.Next != null && second.Next == null) { return 1; }
            if (flag == 0)
            {
                if (first.value == second.value) { return 0; }
                else if (first.value > second.value) { return 1; }
                else { return 2; }
            }
            else { return flag; }
        }
    }
}
