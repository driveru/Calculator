using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator_form
{
    class ConvertExpression
    {
        static public int k = -1;
        static public string[] converted_expression = new string[101];
        public static string[] ConvertExpressionFunc(string not_converted_expression)
        {
            not_converted_expression = not_converted_expression.Replace(" ", "");
            string num = ""; int i = 0; 
            char[] operations = { '+', '-', '*', '/', '^', ')' };
            while (i < not_converted_expression.Length)
            {
                char el = not_converted_expression[i];
                if (operations.Contains(el))
                {
                    if (num != "")
                    {
                        k++;
                        converted_expression[k] = num;
                        num = "";
                    }
                    k++;
                    converted_expression[k] = el.ToString();
                }
                else
                {
                    if (el == '(')
                    {
                        k++;
                        converted_expression[k] = el.ToString();
                    }
                    else
                    {
                        if (el == 'l')
                        {
                            int nest = 1;
                            i += 3;
                            int start = i + 1; int pause = 0; int last;
                            while (nest > 0)
                            {
                                i++;
                                if (not_converted_expression[i] == '(') // открывающая скобка
                                { nest++; }
                                if (not_converted_expression[i] == ')') // закрывающая скобка
                                { nest--; }
                                if (not_converted_expression[i] == ',')
                                {
                                    pause = i;
                                }
                            }
                            last = i;
                            k++;
                            converted_expression[k] = "(";
                            ConvertExpressionFunc(not_converted_expression.Substring(start, pause - start));
                            k++;
                            converted_expression[k] = ")";
                            k++;
                            converted_expression[k] = "l";
                            k++;
                            converted_expression[k] = "(";
                            ConvertExpressionFunc(not_converted_expression.Substring(pause + 1, last - pause - 1));
                            k++;
                            converted_expression[k] = ")";
                        }
                        else
                        {
                            if (el == 's')
                            {
                                int nest = 1;
                                i += 4;
                                int start = i + 1; int last;
                                while (nest > 0)
                                {
                                    i++;
                                    if (not_converted_expression[i] == '(') // открывающая скобка
                                    { nest++; }
                                    if (not_converted_expression[i] == ')') // закрывающая скобка
                                    { nest--; }
                                }
                                last = i;
                                k++;
                                converted_expression[k] = "(";
                                ConvertExpressionFunc(not_converted_expression.Substring(start, last - start + 1));
                                k++;

                                converted_expression[k] = "s";
                                k++;
                                converted_expression[k] = "0";
                            }
                            else
                            {
                                num += el.ToString();
                            }
                        }
                    }
                }
                i++;
            }
            if (num != "")
            {
                k++;
                converted_expression[k] = num;
            }
            converted_expression[100] = k.ToString();
            return converted_expression;
        }
    }
}
