using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class Number : Expression
    {
        private int[] n;
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
