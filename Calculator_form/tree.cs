using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_form
{
    class tree
    {
        static public IExpression MakeTree(List<string> expression, int first, int last)
        {
            try
            {
                int MinPrt, i, k = 0, prt;
                IExpression Tree;
                int nest = 0;
                if (first >= last)
                {
                    Tree = new Number(expression[last]);
                    return Tree;
                }
                MinPrt = 100;
                for (i = first; i <= last; i++)
                {
                    if (expression[i] == "(") // открывающая скобка
                    { nest++; continue; }
                    if (expression[i] == ")") // закрывающая скобка
                    { nest--; continue; }
                    if (nest > 0) { continue; }
                    prt = Priority(expression[i]);
                    if (prt <= MinPrt)
                    {                 // ищем последнюю операцию
                        MinPrt = prt; // с наименьшим приоритетом
                        k = i;
                    }
                }
                if ((MinPrt == 100) && (expression[first] == "(") && (expression[last] == ")"))
                {
                    Tree = null;
                    return MakeTree(expression, first + 1, last - 1);
                }
                Tree = ExpressionUtils.getOperator(expression[k], MakeTree(expression, first, k - 1), MakeTree(expression, k + 1, last));
                return Tree;
            }
            catch(ArgumentOutOfRangeException)
            {
                throw new RoundBracketException();
            }
        }
        static int Priority(string operation)
        {
            switch (operation)
            {
                case Add.Description: case Subtract.Description: return 1;
                case Multiply.Description: case Division.Description: return 2;
                case Power.Description: return 3;
                case Log.Description: return 4;
                case Sqrt.Description: return 4;
            }
            return 100; // это не арифметическая операция
        }    
    }
}
