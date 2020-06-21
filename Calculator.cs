using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsCalculator
{
    public partial class Calculator : Form
    {
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double input1 = GetDouble(textBox1);
                double input2 = GetDouble(textBox2);
                resultLabel.Text = (input1 + input2).ToString();
                resultLabel.ForeColor = Color.Yellow;
                resultLabel.Visible = true;
            }
            catch
            {
                resultLabel.Text = "Value must be numeric and > 0.";
                resultLabel.ForeColor = Color.Red;
                resultLabel.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                double input1 = GetDouble(textBox1);
                double input2 = GetDouble(textBox2);
                resultLabel.Text = (input1 * input2).ToString();
                resultLabel.ForeColor = Color.Yellow;
                resultLabel.Visible = true;
            }
            catch
            {
                resultLabel.Text = "Value must be numeric and > 0.";
                resultLabel.ForeColor = Color.Red;
                resultLabel.Visible = true;
            }

        }

        private double GetDouble(TextBox fromTextBox)
        {
            double myDouble = 0;
            // Ensure user enters a number
            myDouble = double.Parse(fromTextBox.Text);
            return myDouble;
        }

    }
}
