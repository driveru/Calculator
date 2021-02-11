using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Number : IExpression
    {
        private BigInteger n;
        public Number(string num)
        {
            BigInteger convertered = new BigInteger();
            if (num[0] == '-')
            {
                convertered.is_negative = true;
                num = num.Substring(1);
            }

            int ln = num.Length; 
            Part current = convertered.head;

            while (ln > 3)
            {
                if (current.Next == null)
                {
                    current = new Part(current);
                }
                else { current = current.Next; }
                current.value = int.Parse(num.Substring(ln - 4, 4));
                ln -= 4;
            }
            if (ln > 0)
            {
                if (current.Next == null)
                {
                    current = new Part(current);
                }
                else { current = current.Next; }
                current.value = int.Parse(num.Substring(0, ln));
            }
            this.n = convertered.smooth();
        }
        public Number(BigInteger n)
        {
            this.n = n;
        }
        public BigInteger interpret()
        {
            return n;
        }
    }
}
