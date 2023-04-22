namespace CalculatorApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox = new System.Windows.Forms.TextBox();
            this.input4 = new System.Windows.Forms.Button();
            this.input7 = new System.Windows.Forms.Button();
            this.input0 = new System.Windows.Forms.Button();
            this.input1 = new System.Windows.Forms.Button();
            this.input5 = new System.Windows.Forms.Button();
            this.input8 = new System.Windows.Forms.Button();
            this.inputDot = new System.Windows.Forms.Button();
            this.input2 = new System.Windows.Forms.Button();
            this.input6 = new System.Windows.Forms.Button();
            this.input9 = new System.Windows.Forms.Button();
            this.inputEqual = new System.Windows.Forms.Button();
            this.input3 = new System.Windows.Forms.Button();
            this.inputMultiplication = new System.Windows.Forms.Button();
            this.inputDivision = new System.Windows.Forms.Button();
            this.inputPlus = new System.Windows.Forms.Button();
            this.inputMinus = new System.Windows.Forms.Button();
            this.inputReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox
            // 
            this.textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F);
            this.textBox.Location = new System.Drawing.Point(99, 12);
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = true;
            this.textBox.Size = new System.Drawing.Size(577, 80);
            this.textBox.TabIndex = 0;
            this.textBox.Text = "0";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // input4
            // 
            this.input4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.input4.Location = new System.Drawing.Point(132, 272);
            this.input4.Name = "input4";
            this.input4.Size = new System.Drawing.Size(125, 124);
            this.input4.TabIndex = 1;
            this.input4.Text = "4";
            this.input4.UseVisualStyleBackColor = true;
            this.input4.Click += new System.EventHandler(this.input4_Click);
            // 
            // input7
            // 
            this.input7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.input7.Location = new System.Drawing.Point(132, 124);
            this.input7.Name = "input7";
            this.input7.Size = new System.Drawing.Size(125, 124);
            this.input7.TabIndex = 1;
            this.input7.Text = "7";
            this.input7.UseVisualStyleBackColor = true;
            this.input7.Click += new System.EventHandler(this.input7_Click);
            // 
            // input0
            // 
            this.input0.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.input0.Location = new System.Drawing.Point(132, 568);
            this.input0.Name = "input0";
            this.input0.Size = new System.Drawing.Size(125, 124);
            this.input0.TabIndex = 1;
            this.input0.Text = "0";
            this.input0.UseVisualStyleBackColor = true;
            this.input0.Click += new System.EventHandler(this.input0_Click);
            // 
            // input1
            // 
            this.input1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.input1.Location = new System.Drawing.Point(132, 420);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(125, 124);
            this.input1.TabIndex = 1;
            this.input1.Text = "1";
            this.input1.UseVisualStyleBackColor = true;
            this.input1.Click += new System.EventHandler(this.input1_Click);
            // 
            // input5
            // 
            this.input5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.input5.Location = new System.Drawing.Point(263, 272);
            this.input5.Name = "input5";
            this.input5.Size = new System.Drawing.Size(125, 124);
            this.input5.TabIndex = 1;
            this.input5.Text = "5";
            this.input5.UseVisualStyleBackColor = true;
            this.input5.Click += new System.EventHandler(this.input5_Click);
            // 
            // input8
            // 
            this.input8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.input8.Location = new System.Drawing.Point(263, 124);
            this.input8.Name = "input8";
            this.input8.Size = new System.Drawing.Size(125, 124);
            this.input8.TabIndex = 1;
            this.input8.Text = "8";
            this.input8.UseVisualStyleBackColor = true;
            this.input8.Click += new System.EventHandler(this.input8_Click);
            // 
            // inputDot
            // 
            this.inputDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputDot.Location = new System.Drawing.Point(263, 568);
            this.inputDot.Name = "inputDot";
            this.inputDot.Size = new System.Drawing.Size(125, 124);
            this.inputDot.TabIndex = 1;
            this.inputDot.Text = ".";
            this.inputDot.UseVisualStyleBackColor = true;
            this.inputDot.Click += new System.EventHandler(this.inputDot_Click);
            // 
            // input2
            // 
            this.input2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.input2.Location = new System.Drawing.Point(263, 420);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(125, 124);
            this.input2.TabIndex = 1;
            this.input2.Text = "2";
            this.input2.UseVisualStyleBackColor = true;
            this.input2.Click += new System.EventHandler(this.input2_Click);
            // 
            // input6
            // 
            this.input6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.input6.Location = new System.Drawing.Point(394, 272);
            this.input6.Name = "input6";
            this.input6.Size = new System.Drawing.Size(125, 124);
            this.input6.TabIndex = 1;
            this.input6.Text = "6";
            this.input6.UseVisualStyleBackColor = true;
            this.input6.Click += new System.EventHandler(this.input6_Click);
            // 
            // input9
            // 
            this.input9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.input9.Location = new System.Drawing.Point(394, 124);
            this.input9.Name = "input9";
            this.input9.Size = new System.Drawing.Size(125, 124);
            this.input9.TabIndex = 1;
            this.input9.Text = "9";
            this.input9.UseVisualStyleBackColor = true;
            this.input9.Click += new System.EventHandler(this.input9_Click);
            // 
            // inputEqual
            // 
            this.inputEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputEqual.Location = new System.Drawing.Point(394, 568);
            this.inputEqual.Name = "inputEqual";
            this.inputEqual.Size = new System.Drawing.Size(125, 124);
            this.inputEqual.TabIndex = 1;
            this.inputEqual.Text = "=";
            this.inputEqual.UseVisualStyleBackColor = true;
            this.inputEqual.Click += new System.EventHandler(this.inputEqual_Click);
            // 
            // input3
            // 
            this.input3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.input3.Location = new System.Drawing.Point(394, 420);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(125, 124);
            this.input3.TabIndex = 1;
            this.input3.Text = "3";
            this.input3.UseVisualStyleBackColor = true;
            this.input3.Click += new System.EventHandler(this.input3_Click);
            // 
            // inputMultiplication
            // 
            this.inputMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputMultiplication.Location = new System.Drawing.Point(525, 272);
            this.inputMultiplication.Name = "inputMultiplication";
            this.inputMultiplication.Size = new System.Drawing.Size(125, 124);
            this.inputMultiplication.TabIndex = 1;
            this.inputMultiplication.Text = "X";
            this.inputMultiplication.UseVisualStyleBackColor = true;
            this.inputMultiplication.Click += new System.EventHandler(this.inputMultiplication_Click);
            // 
            // inputDivision
            // 
            this.inputDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputDivision.Location = new System.Drawing.Point(525, 124);
            this.inputDivision.Name = "inputDivision";
            this.inputDivision.Size = new System.Drawing.Size(125, 124);
            this.inputDivision.TabIndex = 1;
            this.inputDivision.Text = "÷";
            this.inputDivision.UseVisualStyleBackColor = true;
            this.inputDivision.Click += new System.EventHandler(this.inputDivision_Click);
            // 
            // inputPlus
            // 
            this.inputPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputPlus.Location = new System.Drawing.Point(525, 568);
            this.inputPlus.Name = "inputPlus";
            this.inputPlus.Size = new System.Drawing.Size(125, 124);
            this.inputPlus.TabIndex = 1;
            this.inputPlus.Text = "+";
            this.inputPlus.UseVisualStyleBackColor = true;
            this.inputPlus.Click += new System.EventHandler(this.inputPlus_Click);
            // 
            // inputMinus
            // 
            this.inputMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputMinus.Location = new System.Drawing.Point(525, 420);
            this.inputMinus.Name = "inputMinus";
            this.inputMinus.Size = new System.Drawing.Size(125, 124);
            this.inputMinus.TabIndex = 1;
            this.inputMinus.Text = "-";
            this.inputMinus.UseVisualStyleBackColor = true;
            this.inputMinus.Click += new System.EventHandler(this.inputMinus_Click);
            // 
            // inputReset
            // 
            this.inputReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.inputReset.Location = new System.Drawing.Point(263, 709);
            this.inputReset.Name = "inputReset";
            this.inputReset.Size = new System.Drawing.Size(256, 96);
            this.inputReset.TabIndex = 2;
            this.inputReset.Text = "RESET";
            this.inputReset.UseVisualStyleBackColor = true;
            this.inputReset.Click += new System.EventHandler(this.inputReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 830);
            this.Controls.Add(this.inputReset);
            this.Controls.Add(this.inputMinus);
            this.Controls.Add(this.input3);
            this.Controls.Add(this.input2);
            this.Controls.Add(this.input1);
            this.Controls.Add(this.inputPlus);
            this.Controls.Add(this.inputEqual);
            this.Controls.Add(this.inputDot);
            this.Controls.Add(this.input0);
            this.Controls.Add(this.inputDivision);
            this.Controls.Add(this.inputMultiplication);
            this.Controls.Add(this.input9);
            this.Controls.Add(this.input6);
            this.Controls.Add(this.input8);
            this.Controls.Add(this.input5);
            this.Controls.Add(this.input7);
            this.Controls.Add(this.input4);
            this.Controls.Add(this.textBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox;
        private System.Windows.Forms.Button input4;
        private System.Windows.Forms.Button input7;
        private System.Windows.Forms.Button input0;
        private System.Windows.Forms.Button input1;
        private System.Windows.Forms.Button input5;
        private System.Windows.Forms.Button input8;
        private System.Windows.Forms.Button inputDot;
        private System.Windows.Forms.Button input2;
        private System.Windows.Forms.Button input6;
        private System.Windows.Forms.Button input9;
        private System.Windows.Forms.Button inputEqual;
        private System.Windows.Forms.Button input3;
        private System.Windows.Forms.Button inputMultiplication;
        private System.Windows.Forms.Button inputDivision;
        private System.Windows.Forms.Button inputPlus;
        private System.Windows.Forms.Button inputMinus;
        private System.Windows.Forms.Button inputReset;
    }
}

