using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator_form
{
    class ConvertExpression
    {
        private List<string> expression = new List<string>();
        public ConvertExpression(string not_converted_expression)
        {
            try
            {
                expression = Tokenize(not_converted_expression);
            }
            catch (Exception)
            {
                expression = null;
            }
        }
        List<string> Tokenize(string not_converted_expression)
        {
            try
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
                            expression.Add(num);
                            num = "";
                        }
                        expression.Add(el.ToString());
                    }
                    else
                    {
                        if (el == '(')
                        {
                            expression.Add(el.ToString());
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
                                expression.Add("(");
                                Tokenize(not_converted_expression.Substring(start, pause - start));
                                expression.Add(")");
                                expression.Add("l");
                                expression.Add("(");
                                Tokenize(not_converted_expression.Substring(pause + 1, last - pause - 1));
                                expression.Add(")");
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
                                    expression.Add("(");
                                    Tokenize(not_converted_expression.Substring(start, last - start + 1));
                                    expression.Add("s");
                                    expression.Add("0");
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
                    expression.Add(num);
                }
                return expression;
            }     
            catch (Exception)
            {
                return null;
            }
        }
        /*
        bool ValidateExpression()
        {
            
            int brackets = 0;
            bool left_isOperator = false;
            bool right_isOperator = true;
            int start = 0;
            int ln = expression.Count();
            for (int i = 0; i < ln; i++)
            {
                if (expression[i] == "(")
                {
                    brackets++;
                    continue;
                }
                else if (expression[i] == ")")
                {
                    brackets--;
                    if (brackets < 0) { return false; }
                    continue;
                }
                if (!ExpressionUtils.isOperator(expression[i]))
                {
                    start = i;
                    break;
                }
            }
            for (int j = start + 1; j < ln; j++)
            {
                right_isOperator = (ExpressionUtils.isOperator(expression[j]));
                if (expression[j] == "(")
                {
                    brackets++;
                    continue;
                }
                else if (expression[j] == ")")
                {
                    brackets--;
                    if (brackets < 0) { return false; }
                    continue;
                }
                if ((right_isOperator && left_isOperator) || (!right_isOperator && !left_isOperator))
                {
                    return false;
                }
                left_isOperator = right_isOperator;
            }
            return true;
        }
        */
        public List<string> GetExpression()
        {
            Node Tree = tree.MakeTree(expression, 0, expression.Count() - 1);
            List<string> good_expression = new List<string>();
            return tree.LPK(Tree, good_expression); //expression;
        }
    }
}
