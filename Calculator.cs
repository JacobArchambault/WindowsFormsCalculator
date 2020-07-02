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
            // Calls the print result method, passing in an anonymous lambda function as parameter. Read as 'given parameters a, b, perform addition on them wherever the ofBinaryOp function is used in the function definition.
            PrintResult((a, b) => (a + b));
        }
        // Says what to do when multiply button is clicked on.
        private void button2_Click(object sender, EventArgs e)
        {
            // Calls the PrintResult method, passing in an anonymous lambda function as parameter. Read as 'given parameters a, b, perform multiplication on them wherever the ofBinaryOp function is used in the function definition.
            PrintResult((a, b) => (a * b));
        }

        // A function taking a binary operation as a parameter. What binary operation to use is determined by what is passed in during the function call.
        private void PrintResult(Func<double, double, double> ofBinaryOp)
        {
            // Ensure the values passed in by the user can be parsed as doubles
            if (double.TryParse(value1Textbox.Text, out double input1)
                && double.TryParse(value2Textbox.Text, out double input2))
            {
                // If they can, print the result of the binary operation passed in on the result label in string format...
                resultLabel.Text = (ofBinaryOp(input1, input2)).ToString();
                // in yellow;
                resultLabel.ForeColor = Color.Yellow;
            }
            else
            {
                // Otherwise, give the reader a warning message
                resultLabel.Text = "Value must be numeric and > 0.";
                // ...in red.
                resultLabel.ForeColor = Color.Red;
            }
            // ...and make the label object on which the result is printed visible
            resultLabel.Visible = true;
        }
    }
}
