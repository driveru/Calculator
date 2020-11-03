using System;
using System.Collections.Generic;
using System.Text;

namespace Calculator_form
{
    class ConverterUtils
    {
        public static int[] ConvertToNewNumberSystem(string num)
        {
            int[] convertered = new int[26];
            if (num == "")
            {
                return convertered;
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
            return convertered;
        }
        public static string ConvertToString(int[] num)
        {
            string ans = ""; string bufer = "";
            int ln = num.Length;

            for (int i = 0; i < 25; i++)
            {
                if (num[i] == 0)
                {
                    bufer = "0000" + bufer;
                }
                else
                {
                    ans = bufer + ans;
                    ans = ConvertToQuad(num[i]) + ans;
                    bufer = "";
                }
            }
            if (ans == "")
            {
                ans = "0";
            }
            else
            {
                while (ans[0] == '0') { ans = ans.Substring(1); }
                if (num[25] == -1)
                {
                    ans = "-" + ans;
                }
            }
            return ans;
        }
        public static string ConvertToQuad(int num)
        {
            string num_s = num.ToString();
            int ln = num_s.Length;
            for (int i = 0; i < 4 - ln; i++) { num_s = "0" + num_s; }
            return num_s;
        }
    }
}
