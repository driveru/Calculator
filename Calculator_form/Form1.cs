using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_form
{
    public partial class Form1 : Form
    {
        string solution;
        bool flag = true; bool log_flag = false; bool sqrt_flag = false;
        int log_brackets = 1;
        bool now_operator = false;
        bool cooma_in_log = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            now_operator = false;
            if (!flag)
            {
                flag = true;
                clear_arrays();
                CurrentNumber.Text = "";
            }
            CurrentNumber.Text += 1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            now_operator = false;
            if (!flag)
            {
                flag = true;
                clear_arrays();
                CurrentNumber.Text = "";
            }
            CurrentNumber.Text += 2;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            now_operator = false;
            if (!flag)
            {
                flag = true;
                clear_arrays();
                CurrentNumber.Text = "";
            }
            CurrentNumber.Text += 3;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            now_operator = false;
            if (!flag)
            {
                flag = true;
                clear_arrays();
                CurrentNumber.Text = "";
            }
            CurrentNumber.Text += 4;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            now_operator = false;
            if (!flag)
            {
                flag = true;
                clear_arrays();
                CurrentNumber.Text = "";
            }
            CurrentNumber.Text += 5;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            now_operator = false;
            if (!flag)
            {
                flag = true;
                clear_arrays();
                CurrentNumber.Text = "";
            }
            CurrentNumber.Text += 6;
        }
        private void button7_Click(object sender, EventArgs e)
        {
            now_operator = false;
            if (!flag)
            {
                flag = true;
                clear_arrays();
                CurrentNumber.Text = "";
            }
            CurrentNumber.Text += 7;
        }
        private void button8_Click(object sender, EventArgs e)
        {
            now_operator = false;
            if (!flag)
            {
                flag = true;
                clear_arrays();
                CurrentNumber.Text = "";
            }
            CurrentNumber.Text += 8;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            now_operator = false;
            if (!flag)
            {
                flag = true;
                clear_arrays();
                CurrentNumber.Text = "";
            }
            CurrentNumber.Text += 9;
        }
        private void button10_Click(object sender, EventArgs e)
        {
            now_operator = false;
            if (!flag)
            {
                flag = true;
                clear_arrays();
                CurrentNumber.Text = "";
            }
            if (CurrentNumber.Text != "")
            {
                CurrentNumber.Text += 0;
            }
        }
        private void sum_Click(object sender, EventArgs e)
        {
            operation_func('+');
        }
        private void substraction_Click(object sender, EventArgs e)
        {
            operation_func('-');
        }
        private void multiply_Click(object sender, EventArgs e)
        {
            operation_func('*');
        }
        private void division_Click(object sender, EventArgs e)
        {
            operation_func('/');
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            clear_arrays();
            flag = true;
            CurrentNumber.Text = "";
        }
        private void equality_Click(object sender, EventArgs e)
        {
            equality_func();
        }
        private void clear_arrays() // очищаем калькулятор
        {
            expression.Text = "";
        }
        private void CurrentNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char el = e.KeyChar;

            switch (el)
            {
                case '+': operation_func('+'); break;
                case '-': operation_func('-'); break;
                case '*': operation_func('*'); break;
                case '/': operation_func('/'); break;
                case '=': equality_func(); break;
                case 'l': log_or_sqrt('l'); break;
                case 's': log_or_sqrt('s'); break;
            }
            if (!Char.IsDigit(el))
            {
                e.Handled = true;
            }
            CurrentNumber.SelectionStart = CurrentNumber.Text.Length;
        }
        private void expression_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        private void left_bracket_Click(object sender, EventArgs e)
        {
            if (log_flag)
            {
                log_brackets++;
                CurrentNumber.Text += " ( ";
            }
            else
            {
                expression.Text += CurrentNumber.Text;
                CurrentNumber.Text = "";
                expression.Text += " ( ";
            }
        }
        private void right_bracket_Click(object sender, EventArgs e)
        { 
            if (log_flag)
            {
                log_brackets--;
                if (log_brackets == 0)
                {
                    expression.Text += CurrentNumber.Text;
                    CurrentNumber.Text = "";
                    expression.Text += ")";
                    log_brackets = 1;
                    log_flag = false;
                    cooma_in_log = false;
                }
                else
                {
                    CurrentNumber.Text += " ) ";
                }
            }
            else
            {
                expression.Text += CurrentNumber.Text;
                CurrentNumber.Text = "";
                expression.Text += " ) ";
            } 
        }
        private void power_Click(object sender, EventArgs e)
        {
            operation_func('^');
        }
        private void log_Click(object sender, EventArgs e)
        {
            log_or_sqrt('l');
        }
        private void comma_Click(object sender, EventArgs e)
        {
            if (log_flag && !cooma_in_log && CurrentNumber.Text != "log(")
            {
                cooma_in_log = true;
                CurrentNumber.Text += " , ";
            }   
        }
        private void sqrt_Click(object sender, EventArgs e)
        {
            log_or_sqrt('s');
        }
        private void operation_func(char operation)
        {
            if (now_operator)
            {
                DeleteLastOperation();
            }
            if (!flag)
            {
                flag = true;
                clear_arrays();
            }
            if ((log_flag) || (sqrt_flag))
            {
                CurrentNumber.Text += $" {operation} ";
            }
            else
            {
                expression.Text += CurrentNumber.Text;
                CurrentNumber.Text = "";
                expression.Text += $" {operation} ";
            }
            now_operator = true;
        }
        private void equality_func()
        {
            sqrt_flag = false; log_flag = false;
            if (flag)
            {
                if (CurrentNumber.Text != "")
                {
                    expression.Text += CurrentNumber.Text;
                    try
                    {
                        solution = new ConvertExpression(expression.Text).GetExpression().ToString();
                    }
                    catch (Exception e)
                    {
                        solution = e.Message;
                    }
                    expression.Text += " =";
                }
                else
                {
                    try
                    {
                        solution = new ConvertExpression(expression.Text).GetExpression().ToString(); ;
                    }
                    catch (Exception e)
                    {
                        solution = e.Message;
                    }
                }
                CurrentNumber.Text = solution;
                flag = false;
            }
            else // если хотим повторитть последнюю операцию с полученным ответом.
            {
                clear_arrays();
            }
        }
        private void log_or_sqrt(char el)
        {
            flag = true;
            expression.Text += CurrentNumber.Text;
            if (el == 'l')
            {
                log_flag = true;
                CurrentNumber.Text = "log(";
            }
            else
            {
                sqrt_flag = true;               
                CurrentNumber.Text = "sqrt( ";
            }
        }
        private void DeleteLastOperation()
        {
            int k = 1;
            char current_symbol = expression.Text[expression.Text.Length - k];
            while (!char.IsDigit(current_symbol))
            {
                k++;
                current_symbol = expression.Text[expression.Text.Length - k];
            }
            expression.Text = expression.Text.Substring(0, expression.Text.Length - k + 1);
        }
    }
    
}
