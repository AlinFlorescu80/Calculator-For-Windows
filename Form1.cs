using System;
using System.Data;
using System.Windows.Forms;

namespace CalculatorApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool nuSeTerminaCuOperator()
        {
            return textBox.Text.EndsWith(".") || textBox.Text.EndsWith("+") || textBox.Text.EndsWith("-") || textBox.Text.EndsWith("/") || textBox.Text.EndsWith("*");
        }

        private bool nuEOperatorSau0()
        {
            return textBox.Text != "0" && !textBox.Text.EndsWith("+") && !textBox.Text.EndsWith("-") && !textBox.Text.EndsWith("*") && !textBox.Text.EndsWith("/") && !textBox.Text.EndsWith(".");
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void input7_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
            {
                textBox.Text += "7";
            }
            else
            {
                textBox.Text = "7";
            }
        }
        private void inputReset_Click(object sender, EventArgs e)
        {
            textBox.Text = "0";
        }

        private void input0_Click(object sender, EventArgs e)
        {
            if(textBox.Text != "0")
            {
                textBox.Text += "0";
            }
        }

        private void input1_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
            { 
                textBox .Text += "1";
            }
            else
            {
                 textBox .Text = "1";
            }
        }

        private void input2_Click(object sender, EventArgs e)
        {
            if(textBox.Text != "0")
            {
                textBox.Text += "2";
            }
            else
            {
                textBox.Text = "2";
            }
        }

        private void input3_Click(object sender, EventArgs e)
        {
            if(textBox.Text != "0")
            {
                textBox.Text += "3";
            }
            else
            {
                textBox.Text = "3";
            }
        }

        private void inputMinus_Click(object sender, EventArgs e)
        {
            if (nuEOperatorSau0())
            {
                textBox.Text += "-";
            }
        }

        private void inputEqual_Click(object sender, EventArgs e)
        {
            if (nuSeTerminaCuOperator())
            {
                MessageBox.Show("Input invalid!", "Message", MessageBoxButtons.OK);
                textBox.Text = "0";
            }
            
            else
            {
                string expression = textBox.Text;
                DataTable table = new DataTable();
                var result = table.Compute(expression, "");
                textBox.Text = result.ToString();
            }
        }

             private void inputDot_Click(object sender, EventArgs e)
        {
            try
            {
                string expression = textBox.Text+".";
                DataTable table = new DataTable();
                var result = table.Compute(expression, "");
                
                textBox.Text += ".";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Input invalid!", "Message", MessageBoxButtons.OK);
            }
        }

        private void inputPlus_Click(object sender, EventArgs e)
        {
            if (nuEOperatorSau0())
            {
                textBox.Text += "+";
            }
        }

                private void input4_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
            {
                textBox.Text += "4";
            }
            else
            {
                textBox.Text = "4";
            }
        }

        private void input5_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
            {
                textBox.Text += "5";
            }
            else
            {
                textBox.Text = "5";
            }
        }

        private void input6_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
            {
                textBox.Text += "6";
            }
            else
            {
                textBox.Text = "6";
            }
        }

        private void inputMultiplication_Click(object sender, EventArgs e)
        {
            if (nuEOperatorSau0())
            {
                textBox.Text += "*";
            }
        }

        private void input8_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
            {
                textBox.Text += "8";
            }
            else
            {
                textBox.Text = "8";
            }
        }

        private void input9_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "0")
            {
                textBox.Text += "9";
            }
            else
            {
                textBox.Text = "9";
            }
        }

        private void inputDivision_Click(object sender, EventArgs e)
        {
            if(nuEOperatorSau0())
            {
                textBox.Text += "/";
            }
        }
    }
}
