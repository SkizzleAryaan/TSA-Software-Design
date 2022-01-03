using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSA
{
    public partial class fArith : Form
    {
        Double resultValue = 0; // the value of the result 
        String operationPerformed = ""; // String to hold the value (+, -, *, /) to use in calculation function
        bool isOperationPerformed = false; // checks to see if a person selected a operation before pressing equal to sign
        public fArith()
        {
            InitializeComponent();

            one.FlatStyle = FlatStyle.Flat;
            one.FlatAppearance.BorderSize = 1;

            two.FlatStyle = FlatStyle.Flat;
            two.FlatAppearance.BorderSize = 1;

            three.FlatStyle = FlatStyle.Flat;
            three.FlatAppearance.BorderSize = 1;

            four.FlatStyle = FlatStyle.Flat;
            four.FlatAppearance.BorderSize = 1;

            five.FlatStyle = FlatStyle.Flat;
            five.FlatAppearance.BorderSize = 1;

            five.FlatStyle = FlatStyle.Flat;
            five.FlatAppearance.BorderSize = 1;

            six.FlatStyle = FlatStyle.Flat;
            six.FlatAppearance.BorderSize = 1;

            seven.FlatStyle = FlatStyle.Flat;
            seven.FlatAppearance.BorderSize = 1;

            eight.FlatStyle = FlatStyle.Flat;
            eight.FlatAppearance.BorderSize = 1;

            nine.FlatStyle = FlatStyle.Flat;
            nine.FlatAppearance.BorderSize = 1;

            zero.FlatStyle = FlatStyle.Flat;
            zero.FlatAppearance.BorderSize = 1;

            add.FlatStyle = FlatStyle.Flat;
            add.FlatAppearance.BorderSize = 1;

            subtract.FlatStyle = FlatStyle.Flat;
            subtract.FlatAppearance.BorderSize = 1;

            multiply.FlatStyle = FlatStyle.Flat;
            multiply.FlatAppearance.BorderSize = 1;

            divide.FlatStyle = FlatStyle.Flat;
            divide.FlatAppearance.BorderSize = 1;

            clearall.FlatStyle = FlatStyle.Flat;
            clearall.FlatAppearance.BorderSize = 1;

            clearpart.FlatStyle = FlatStyle.Flat;
            clearpart.FlatAppearance.BorderSize = 1;

            arithmeticEqualButton.FlatStyle = FlatStyle.Flat;
            arithmeticEqualButton.FlatAppearance.BorderSize = 1;

            arithback.FlatStyle = FlatStyle.Flat;
            arithback.FlatAppearance.BorderSize = 1;

            dec.FlatStyle = FlatStyle.Flat;
            dec.FlatAppearance.BorderSize = 1;
        }

        private void one_Click(object sender, EventArgs e)
        {
            if ((arithmeticTextBox.Text == "0") || (isOperationPerformed))
            {
                arithmeticTextBox.Clear();
            }
            arithmeticTextBox.Text = arithmeticTextBox.Text + "1";
            isOperationPerformed = false;
        }

        private void two_Click(object sender, EventArgs e)
        {
            if ((arithmeticTextBox.Text == "0") || (isOperationPerformed))
            {
                arithmeticTextBox.Clear();
            }
            arithmeticTextBox.Text = arithmeticTextBox.Text + "2";
            isOperationPerformed = false;
        }

        private void three_Click(object sender, EventArgs e)
        {
            if ((arithmeticTextBox.Text == "0") || (isOperationPerformed))
            {
                arithmeticTextBox.Clear();
            }
            arithmeticTextBox.Text = arithmeticTextBox.Text + "3";
            isOperationPerformed = false;
        }

        private void four_Click(object sender, EventArgs e)
        {
            if ((arithmeticTextBox.Text == "0") || (isOperationPerformed))
            {
                arithmeticTextBox.Clear();
            }
            arithmeticTextBox.Text = arithmeticTextBox.Text + "4";
            isOperationPerformed = false;
        }

        private void five_Click(object sender, EventArgs e)
        {
            if ((arithmeticTextBox.Text == "0") || (isOperationPerformed))
            {
                arithmeticTextBox.Clear();
            }
            arithmeticTextBox.Text = arithmeticTextBox.Text + "5";
            isOperationPerformed = false;
        }

        private void six_Click(object sender, EventArgs e)
        {
            if ((arithmeticTextBox.Text == "0") || (isOperationPerformed))
            {
                arithmeticTextBox.Clear();
            }
            arithmeticTextBox.Text = arithmeticTextBox.Text + "6";
            isOperationPerformed = false;
        }

        private void seven_Click(object sender, EventArgs e)
        {
            if ((arithmeticTextBox.Text == "0") || (isOperationPerformed))
            {
                arithmeticTextBox.Clear();
            }
            arithmeticTextBox.Text = arithmeticTextBox.Text + "7";
            isOperationPerformed = false;
        }

        private void eight_Click(object sender, EventArgs e)
        {
            if ((arithmeticTextBox.Text == "0") || (isOperationPerformed))
            {
                arithmeticTextBox.Clear();
            }
            arithmeticTextBox.Text = arithmeticTextBox.Text + "8";
            isOperationPerformed = false;
        }

        private void nine_Click(object sender, EventArgs e)
        {
            if ((arithmeticTextBox.Text == "0") || (isOperationPerformed))
            {
                arithmeticTextBox.Clear();
            }
            arithmeticTextBox.Text = arithmeticTextBox.Text + "9";
            isOperationPerformed = false;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            if ((arithmeticTextBox.Text == "0") || (isOperationPerformed))
            {
                arithmeticTextBox.Clear();
            }
            arithmeticTextBox.Text = arithmeticTextBox.Text + "0";
            isOperationPerformed = false;
        }

        private void dec_Click(object sender, EventArgs e)
        {
            if (!arithmeticTextBox.Text.Contains("."))
            {
                arithmeticTextBox.Text = arithmeticTextBox.Text + ".";
            }
            isOperationPerformed = false;
        }

        

        private void arithback_Click(object sender, EventArgs e)
        {
            Calculator fm0 = new Calculator();
            fm0.Show();
            this.Hide();
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            String str = arithmeticTextBox.Text;
            if (str.EndsWith("+") || str.EndsWith("-") || str.EndsWith("/") || str.EndsWith("*"))
            {

                arithmeticTextBox.Text = resultValue.ToString();
                operationPerformed = "";
                labeCurrentOperation.Text = resultValue.ToString();
                MessageBox.Show("Please only use 1 operation between numbers");

            }
            else if (resultValue != 0)
            {

                arithmeticEqualButton.PerformClick();
                arithmeticTextBox.Text = arithmeticTextBox.Text + button.Text;
                operationPerformed = button.Text;
                labeCurrentOperation.Text = resultValue + " " + operationPerformed;
                isOperationPerformed = true;
            }
            else
            {

                try 
                {
                    resultValue = Double.Parse(arithmeticTextBox.Text);
                    arithmeticTextBox.Text = arithmeticTextBox.Text + button.Text;
                    operationPerformed = button.Text;
                    labeCurrentOperation.Text = resultValue + " " + operationPerformed;
                    isOperationPerformed = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Please Enter a value first");
                }
                
                

            }



        }

        private void clearpart_Click(object sender, EventArgs e)
        {
            arithmeticTextBox.Text = "0";
        }

        private void clearall_Click(object sender, EventArgs e)
        {
            arithmeticTextBox.Text = "0";
            resultValue = 0;
            labeCurrentOperation.Text = "";
            operationPerformed = "";
        }

        private void arithmeticEqualButton_Click(object sender, EventArgs e)
        {
            switch (operationPerformed)
            {
                case "+":
                    arithmeticTextBox.Text = (resultValue + Double.Parse(arithmeticTextBox.Text)).ToString();
                    resultValue = Double.Parse(arithmeticTextBox.Text);
                    break;
                case "-":
                    arithmeticTextBox.Text = (resultValue - Double.Parse(arithmeticTextBox.Text)).ToString();
                    resultValue = Double.Parse(arithmeticTextBox.Text);
                    break;
                case "*":
                    arithmeticTextBox.Text = (resultValue * Double.Parse(arithmeticTextBox.Text)).ToString();
                    resultValue = Double.Parse(arithmeticTextBox.Text);
                    break;
                case "/":
                    arithmeticTextBox.Text = (resultValue / Double.Parse(arithmeticTextBox.Text)).ToString();
                    resultValue = Double.Parse(arithmeticTextBox.Text);
                    break;
                default:
                    break;
            }




            operationPerformed = "";



            //resultValue = Double.Parse(arithmeticTextBox.Text);
            labeCurrentOperation.Text = resultValue.ToString();

        }

        
    }
}
