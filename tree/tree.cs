using System;

namespace tree
{
    class tree
    {
        static void Main(string[] args)
        {
            string[] expression = { "10", "*", "2", "-", "5", "*", "4" };
            Node Tree = MakeTree(expression, 0, 6);
            Console.WriteLine(CalcTree(Tree));
        }
        static string CalcTree(Node Tree)
        {
            string num1, num2;
            if (Tree.left == null) // если нет потомков,
                return Tree.data; // вернули число
            num1 = CalcTree(Tree.left); // вычисляем поддеревья
            num2 = CalcTree(Tree.right);
            return Calculate.calculate(num1, num2, Tree.data);
        }

        static Node MakeTree(string[] expression, int first, int last)
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
            }
            return 100; // это не арифметическая операция
        }
    }

    public class Node
    {
        public string data;
        public Node left, right;
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
                if (operation == "-") // вычетание == сложение с обратным
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
