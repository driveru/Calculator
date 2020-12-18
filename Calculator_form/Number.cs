using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Number : IExpression
    {
        private int[] n;
        public Number(string num)
        {
            // add convertation
            int[] convertered = new int[26];
            if (num == "")
            {
                this.n = convertered;
            }
            if (num[0] == '-')
            {
                convertered[25] = -1;
                num = num.Substring(1);
            }
            else { convertered[25] = 1; }

            int ln = num.Length; int k = 0;

            while (ln > 3)
            {
                convertered[k] = int.Parse(num.Substring(ln - 4, 4));
                ln -= 4;
                k++;
            }
            if (ln > 0)
            {
                convertered[k] = int.Parse(num.Substring(0, ln));
            }
            this.n = convertered;
        }
        public Number(int[] n)
        {
            this.n = n;
        }
        public int[] interpret()
        {
            return n;
        }
    }
}
