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
        
        // Says what to do when add button is clicked on 
        private void button1_Click(object sender, EventArgs e)
        {
            // Calls the print result method, passing in an anonymous lambda function as parameter. Read as 'given parameters a, b, perform addition on them wherever the ofBinaryOp function is used in the function definition. Other calls to Print result below work analogously for the -, *, and / operators.
            PrintResult((a, b) => (a + b));
        }
        // Says what to do when multiply button is clicked on.
        private void button2_Click(object sender, EventArgs e)
        {
            PrintResult((a, b) => (a * b));
        }

        // A function taking a binary operation as a parameter. What binary operation to use is determined by what is passed in during the function call.
        private void PrintResult(Func<decimal, decimal, decimal> ofBinaryOp)
        {
            try
            {
                // Ensure the values passed in by the user can be parsed as doubles
                if (decimal.TryParse(value1Textbox.Text, out decimal input1)
                    && decimal.TryParse(value2Textbox.Text, out decimal input2))
                {
                    // If they can, print the result of the binary operation passed in on the result label in string format...
                    resultLabel.Text = (ofBinaryOp(input1, input2)).ToString();
                    // in yellow;
                    resultLabel.ForeColor = Color.Yellow;
                }
                else
                {
                    // Otherwise, give the reader a warning message
                    resultLabel.Text = "Both values must be numeric and > 0.";
                    // ...in red.
                    resultLabel.ForeColor = Color.Red;
                }

            }
            // Ensure that user receives an error message on attempting to divide by zero.
            catch (DivideByZeroException)
            {
                resultLabel.Text = "Cannot divide by zero";
                resultLabel.ForeColor = Color.Red;
            }
            // ...and make the label object on which the result is printed visible
            resultLabel.Visible = true;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            PrintResult((a, b) => (a / b));
        }

        private void subtractButton_Click(object sender, EventArgs e)
        {
            PrintResult((a, b) => (a - b));

        }
    }
}
