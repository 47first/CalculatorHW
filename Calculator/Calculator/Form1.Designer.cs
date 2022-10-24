namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.textBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonDivide = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonMultiply = new System.Windows.Forms.Button();
            this.buttonCE = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // textBox
            // 
            this.textBox.Location = new System.Drawing.Point(12, 12);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(162, 23);
            this.textBox.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(68, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(50, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(124, 41);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(124, 70);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(50, 23);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(68, 70);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(50, 23);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 70);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(50, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(124, 99);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(50, 23);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(68, 99);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(50, 23);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(12, 99);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(50, 23);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // buttonDivide
            // 
            this.buttonDivide.Location = new System.Drawing.Point(180, 99);
            this.buttonDivide.Name = "buttonDivide";
            this.buttonDivide.Size = new System.Drawing.Size(50, 23);
            this.buttonDivide.TabIndex = 13;
            this.buttonDivide.Text = "/";
            this.buttonDivide.UseVisualStyleBackColor = true;
            this.buttonDivide.Click += new System.EventHandler(this.SpecialButtonClick);
            // 
            // buttonMinus
            // 
            this.buttonMinus.Location = new System.Drawing.Point(180, 70);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(50, 23);
            this.buttonMinus.TabIndex = 12;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = true;
            this.buttonMinus.Click += new System.EventHandler(this.SpecialButtonClick);
            // 
            // buttonPlus
            // 
            this.buttonPlus.Location = new System.Drawing.Point(180, 41);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(50, 23);
            this.buttonPlus.TabIndex = 11;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.SpecialButtonClick);
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(68, 128);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(50, 23);
            this.button0.TabIndex = 14;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.NumberButtonClick);
            // 
            // buttonMultiply
            // 
            this.buttonMultiply.Location = new System.Drawing.Point(180, 128);
            this.buttonMultiply.Name = "buttonMultiply";
            this.buttonMultiply.Size = new System.Drawing.Size(50, 23);
            this.buttonMultiply.TabIndex = 15;
            this.buttonMultiply.Text = "*";
            this.buttonMultiply.UseVisualStyleBackColor = true;
            this.buttonMultiply.Click += new System.EventHandler(this.SpecialButtonClick);
            // 
            // buttonCE
            // 
            this.buttonCE.Location = new System.Drawing.Point(124, 130);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(50, 21);
            this.buttonCE.TabIndex = 16;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.SpecialButtonClick);
            // 
            // buttonC
            // 
            this.buttonC.Location = new System.Drawing.Point(12, 128);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(50, 21);
            this.buttonC.TabIndex = 17;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.SpecialButtonClick);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(180, 11);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(50, 23);
            this.button10.TabIndex = 18;
            this.button10.Text = "=";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.SpecialButtonClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 161);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.buttonMultiply);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonDivide);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox textBox;
        private Button button2;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button9;
        private Button button8;
        private Button button7;
        private Button buttonDivide;
        private Button buttonMinus;
        private Button buttonPlus;
        private Button button0;
        private Button buttonMultiply;
        private Button buttonCE;
        private Button buttonC;
        private Button button10;
    }
}