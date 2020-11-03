using System;
using System.Linq;

namespace calculator
{
    class Program
    {
        static int k = -1;
        static string[] converted_expression = new string[101];
        static void Main(string[] args)
        {
            // добавить в калькулятор 
            
            Console.Write("Введите выражение: ");
            string s = "25 - (36 * 2 - 6 / 6) * log(10*5, 5+5)";
            string[] ans = ConvertExpression(s);
            for (int i = 0; i < int.Parse(ans[100])+1; i++)
            {
                Console.WriteLine(ans[i]);
            }
            Console.WriteLine(ans[100]);
        }
        /*
        static string[] ConvertExpression(string not_converted_expression)
        {
            not_converted_expression = not_converted_expression.Replace(" ", "");
            string num = ""; int k = -1;
            string[] converted_expression = new string[101];
            char[] operations = { '+', '-', '*', '/', '^', ')' };

            foreach (char el in not_converted_expression)
            {
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
                        num += el.ToString();
                    }
                   
                }
            }
            if (num != "")
            {
                k++;
                converted_expression[k] = num;
            }
            k++;
            converted_expression[100] = k.ToString();
            return converted_expression;
        }
        */
        public static string[] ConvertExpression(string not_converted_expression)
        {
            not_converted_expression = not_converted_expression.Replace(" ", "");
            string num = "";  int i = 0;
            
            char[] operations = { '+', '-', '*', '/', '^', ')' };
            int expression_length = not_converted_expression.Length;

            while (i < expression_length)
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
                            ConvertExpression(not_converted_expression.Substring(start, pause - start));
                            k++;
                            converted_expression[k] = ")";
                            k++;
                            converted_expression[k] = "l";
                            k++;
                            converted_expression[k] = "(";
                            ConvertExpression(not_converted_expression.Substring(pause + 1, last - pause - 1));
                            k++;
                            converted_expression[k] = ")";
                        }
                        else
                        {
                            num += el.ToString();
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
