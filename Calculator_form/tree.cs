using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_form
{
    class tree
    {
        static public Node MakeTree(string[] expression, int first, int last)
        {
                int MinPrt, i, k = 0, prt;
                Node Tree = new Node();
                int nest = 0;
                if (first == last)
                {
                    Tree.data = expression[last];
                    Tree.left = null;
                    Tree.right = null;
                    return Tree;
                }
                MinPrt = 100;
                for (i = first; i <= last; i++)
                {
                    if (expression[i] == "(") // открывающая скобка
                    { nest++; continue; }
                    if (expression[i] == ")") // закрывающая скобка
                    { nest--; continue; }
                    if (nest > 0) continue;
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
                Tree.data = expression[k];
                Tree.left = MakeTree(expression, first, k - 1);
                Tree.right = MakeTree(expression, k + 1, last);
                return Tree;
        }
        static int Priority(string operation)
        {
            switch (operation)
            {
                case "+": case "-": return 1;
                case "*": case "/": return 2;
                case "^": return 3;
                case "l": return 4;
                case "s": return 4;
            }
            return 100; // это не арифметическая операция
        }
        
        static public List<string> LPK(Node Tree, List<string> expression)
        {
            if (Tree == null) { return expression; }
            expression = LPK(Tree.left, expression);
            expression = LPK(Tree.right, expression);
            expression.Add(Tree.data);
            return expression;
        }
    }
}
