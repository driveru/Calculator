namespace Calculator_form
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        public void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.sum = new System.Windows.Forms.Button();
            this.substraction = new System.Windows.Forms.Button();
            this.multiply = new System.Windows.Forms.Button();
            this.division = new System.Windows.Forms.Button();
            this.equality = new System.Windows.Forms.Button();
            this.CurrentNumber = new System.Windows.Forms.TextBox();
            this.expression = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.right_bracket = new System.Windows.Forms.Button();
            this.left_bracket = new System.Windows.Forms.Button();
            this.power = new System.Windows.Forms.Button();
            this.log = new System.Windows.Forms.Button();
            this.comma = new System.Windows.Forms.Button();
            this.sqrt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 81);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(98, 271);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 81);
            this.button2.TabIndex = 1;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(184, 271);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(80, 81);
            this.button3.TabIndex = 2;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 184);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 81);
            this.button4.TabIndex = 3;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(98, 184);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(80, 81);
            this.button5.TabIndex = 4;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(184, 184);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(80, 81);
            this.button6.TabIndex = 5;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 97);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(80, 81);
            this.button7.TabIndex = 6;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(98, 97);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(80, 81);
            this.button8.TabIndex = 7;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(184, 97);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(80, 81);
            this.button9.TabIndex = 8;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(98, 358);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(80, 81);
            this.button10.TabIndex = 9;
            this.button10.Text = "0";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // sum
            // 
            this.sum.Location = new System.Drawing.Point(339, 97);
            this.sum.Name = "sum";
            this.sum.Size = new System.Drawing.Size(80, 81);
            this.sum.TabIndex = 10;
            this.sum.Text = "+";
            this.sum.UseVisualStyleBackColor = true;
            this.sum.Click += new System.EventHandler(this.sum_Click);
            // 
            // substraction
            // 
            this.substraction.Location = new System.Drawing.Point(425, 97);
            this.substraction.Name = "substraction";
            this.substraction.Size = new System.Drawing.Size(80, 81);
            this.substraction.TabIndex = 11;
            this.substraction.Text = "-";
            this.substraction.UseVisualStyleBackColor = true;
            this.substraction.Click += new System.EventHandler(this.substraction_Click);
            // 
            // multiply
            // 
            this.multiply.Location = new System.Drawing.Point(339, 184);
            this.multiply.Name = "multiply";
            this.multiply.Size = new System.Drawing.Size(80, 81);
            this.multiply.TabIndex = 12;
            this.multiply.Text = "*";
            this.multiply.UseVisualStyleBackColor = true;
            this.multiply.Click += new System.EventHandler(this.multiply_Click);
            // 
            // division
            // 
            this.division.Location = new System.Drawing.Point(425, 184);
            this.division.Name = "division";
            this.division.Size = new System.Drawing.Size(80, 81);
            this.division.TabIndex = 13;
            this.division.Text = "/";
            this.division.UseVisualStyleBackColor = true;
            this.division.Click += new System.EventHandler(this.division_Click);
            // 
            // equality
            // 
            this.equality.Location = new System.Drawing.Point(708, 97);
            this.equality.Name = "equality";
            this.equality.Size = new System.Drawing.Size(80, 81);
            this.equality.TabIndex = 14;
            this.equality.Text = "=";
            this.equality.UseVisualStyleBackColor = true;
            this.equality.Click += new System.EventHandler(this.equality_Click);
            // 
            // CurrentNumber
            // 
            this.CurrentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CurrentNumber.Location = new System.Drawing.Point(12, 42);
            this.CurrentNumber.Name = "CurrentNumber";
            this.CurrentNumber.Size = new System.Drawing.Size(776, 49);
            this.CurrentNumber.TabIndex = 15;
            this.CurrentNumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CurrentNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CurrentNumber_KeyPress);
            // 
            // expression
            // 
            this.expression.BackColor = System.Drawing.SystemColors.Menu;
            this.expression.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.expression.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.expression.Location = new System.Drawing.Point(12, 10);
            this.expression.Name = "expression";
            this.expression.Size = new System.Drawing.Size(776, 26);
            this.expression.TabIndex = 16;
            this.expression.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.expression.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.expression_KeyPress);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(708, 184);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(80, 81);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "C";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // right_bracket
            // 
            this.right_bracket.Location = new System.Drawing.Point(425, 271);
            this.right_bracket.Name = "right_bracket";
            this.right_bracket.Size = new System.Drawing.Size(80, 81);
            this.right_bracket.TabIndex = 18;
            this.right_bracket.Text = ")";
            this.right_bracket.UseVisualStyleBackColor = true;
            this.right_bracket.Click += new System.EventHandler(this.right_bracket_Click);
            // 
            // left_bracket
            // 
            this.left_bracket.Location = new System.Drawing.Point(339, 271);
            this.left_bracket.Name = "left_bracket";
            this.left_bracket.Size = new System.Drawing.Size(80, 81);
            this.left_bracket.TabIndex = 19;
            this.left_bracket.Text = "(";
            this.left_bracket.UseVisualStyleBackColor = true;
            this.left_bracket.Click += new System.EventHandler(this.left_bracket_Click);
            // 
            // power
            // 
            this.power.Location = new System.Drawing.Point(511, 97);
            this.power.Name = "power";
            this.power.Size = new System.Drawing.Size(80, 81);
            this.power.TabIndex = 20;
            this.power.Text = "^";
            this.power.UseVisualStyleBackColor = true;
            this.power.Click += new System.EventHandler(this.power_Click);
            // 
            // log
            // 
            this.log.Location = new System.Drawing.Point(511, 184);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(80, 81);
            this.log.TabIndex = 21;
            this.log.Text = "log(a, b)";
            this.log.UseVisualStyleBackColor = true;
            this.log.Click += new System.EventHandler(this.log_Click);
            // 
            // comma
            // 
            this.comma.Location = new System.Drawing.Point(511, 271);
            this.comma.Name = "comma";
            this.comma.Size = new System.Drawing.Size(80, 81);
            this.comma.TabIndex = 22;
            this.comma.Text = ",";
            this.comma.UseVisualStyleBackColor = true;
            this.comma.Click += new System.EventHandler(this.comma_Click);
            // 
            // sqrt
            // 
            this.sqrt.Location = new System.Drawing.Point(425, 358);
            this.sqrt.Name = "sqrt";
            this.sqrt.Size = new System.Drawing.Size(80, 81);
            this.sqrt.TabIndex = 23;
            this.sqrt.Text = "sqrt";
            this.sqrt.UseVisualStyleBackColor = true;
            this.sqrt.Click += new System.EventHandler(this.sqrt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sqrt);
            this.Controls.Add(this.comma);
            this.Controls.Add(this.log);
            this.Controls.Add(this.power);
            this.Controls.Add(this.left_bracket);
            this.Controls.Add(this.right_bracket);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.expression);
            this.Controls.Add(this.CurrentNumber);
            this.Controls.Add(this.equality);
            this.Controls.Add(this.division);
            this.Controls.Add(this.multiply);
            this.Controls.Add(this.substraction);
            this.Controls.Add(this.sum);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button sum;
        private System.Windows.Forms.Button substraction;
        private System.Windows.Forms.Button multiply;
        private System.Windows.Forms.Button division;
        private System.Windows.Forms.Button equality;
        private System.Windows.Forms.TextBox CurrentNumber;
        private System.Windows.Forms.TextBox expression;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button right_bracket;
        private System.Windows.Forms.Button left_bracket;
        private System.Windows.Forms.Button power;
        private System.Windows.Forms.Button log;
        private System.Windows.Forms.Button comma;
        private System.Windows.Forms.Button sqrt;
    }
}

