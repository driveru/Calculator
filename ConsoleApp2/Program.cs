using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Buffers;
using System.Data;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = "10";
            string num2 = "1";
            Console.WriteLine(Calculate.calculate(num1, num2, "-"));
        }
    }
    class Calculate
    {   
        static public string calculate(string num1, string num2, string operation)
        {
            int[] cnum_1 = Converter(num1);
            int[] cnum_2 = Converter(num2);
            int[] ans = new int[26];

            if (operation == "+" || operation == "-")
            {
                if (operation == "-")
                {
                    cnum_2[25] *= -1;
                }
                if (cnum_1[25] == cnum_2[25])
                {
                    ans = Sum(cnum_1, cnum_2);
                    ans[25] = cnum_1[25];
                }
                else
                {
                    if (Comparison(cnum_1, cnum_2))
                    {
                        // cnum_1 >= cnum_2
                        ans = Substraction(cnum_1, cnum_2);
                        if (cnum_1[25] == -1)
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
                        ans = Substraction(cnum_2, cnum_1);
                        if (cnum_2[25] == -1)
                        {
                            ans[25] = -1;
                        }
                        else
                        {
                            ans[25] = 1;
                        }
                    }
                }
            }
            else
            {
                switch (operation)
                {
                    case "*":
                        int j = 0;

                        for (int i = 0; i < 12; i++)
                        {
                            j = i;
                            int[] help_num = new int[26];
                            for (int k = 0; k < 12; k++)
                            {
                                help_num[j + 1] = (cnum_2[i] * cnum_1[k]) / 10000;
                                help_num[j] = ((cnum_2[i] * cnum_1[k]) % 10000) + help_num[j];
                                j++;
                            }
                            ans = Sum(ans, help_num);
                        }

                        ans[25] = cnum_1[25] * cnum_2[25];
                        break;
                    case "/":
                        return (decimal.Parse(num1) / decimal.Parse(num2)).ToString();
                }
            }
        return ConverterReversed(ans);
        }

        private static int[] Converter(string num)
        {
            int[] convertered = new int[26];
            if (num[0] == '-') { 
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
        private static string ConverterReversed(int[] num)
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
            while (ans[0] == '0') { ans = ans.Substring(1);  }
            if (num[25] == -1)
            {
                ans = "-" + ans;
            }
            return ans;
        }
        private static bool Comparison(int[] num1, int[] num2) //возвращает true если num1 >= num2
        {
            for (int i = 24; i > -1; i--)
            {
                if (num1[i] > num2[i]) 
                {
                    return true;
                }
                else
                {
                    if (num1[i] < num2[i])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        private static int[] Sum(int[] num1, int[] num2)
        {
            int[] ans = new int[26];
            for (int i = 0; i < 24; i++)
            {
                
                ans[i + 1] = (num1[i] + num2[i] + ans[i]) / 10000;
                ans[i] = (num1[i] + num2[i] + ans[i]) % 10000;
            }
            return ans;
        }
        private static int[] Substraction(int[] num1, int[] num2) //num1 >= num2, num1 - num2
        {
            int[] ans = new int[26];
            for (int i = 0; i < 24; i++)
            {
                // Console.WriteLine(num1[i] + "|" + num2[i]);
                if (num1[i] < num2[i])
                {
                    ans[i] = num1[i] + 10000 - num2[i];
                    num1[i + 1] -= 1;
                }
                else
                {
                    ans[i] = num1[i] - num2[i];
                }
                
            }
            return ans;
        }
        private static string ConvertToQuad(int num)
        {
            string num_s = num.ToString();
            int ln = num_s.Length;
            for (int i = 0; i < 4 - ln; i++) { num_s = "0" + num_s; }
            return num_s;
        } 
    }
}
