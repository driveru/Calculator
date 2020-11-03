using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_form
{
    class PrepareExpression
    {
        static public List<string> PrepareExpressionFunc(string not_converted_expression)
        {
            string[] expression = ConvertExpression.ConvertExpressionFunc(not_converted_expression);
            Node Tree = tree.MakeTree(expression, 0, int.Parse(expression[100]));
            List<string> expression_1 = new List<string>();
            return tree.LPK(Tree, expression_1);
        }
    }
}
