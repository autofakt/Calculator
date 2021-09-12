﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        double operand1;
        string operator1;
        double operand2;
        double sum;

        bool gotFirstOperand = false;
        bool inputOn = true; //allows the reset of the input instead of concatination

        public MainForm()
        {
            InitializeComponent();
        }

        
      

        private void button9_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(displayLabel.Text);
            operator1 = "*";
            gotFirstOperand = true;
            inputOn = false;
        }

        private void sevenBtn_Click(object sender, EventArgs e)
        {
            if (inputOn)
            {
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 7.ToString();
                }
                else
                    displayLabel.Text += 7.ToString();
            }
            else
            {
                displayLabel.Text = "";
                inputOn = true;
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 7.ToString();
                }
                else
                    displayLabel.Text += 7.ToString();
            }

        }

        private void eightBtn_Click(object sender, EventArgs e)
        {
            if (inputOn)
            {
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 8.ToString();
                }
                else
                    displayLabel.Text += 8.ToString();
            }
            else
            {
                displayLabel.Text = "";
                inputOn = true;
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 8.ToString();
                }
                else
                    displayLabel.Text += 8.ToString();
            }

        }

        private void nineBtn_Click(object sender, EventArgs e)
        {
            if (inputOn)
            {
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 9.ToString();
                }
                else
                    displayLabel.Text += 9.ToString();
            }
            else
            {
                displayLabel.Text = "";
                inputOn = true;
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 9.ToString();
                }
                else
                    displayLabel.Text += 9.ToString();
            }

        }

        private void sixBtn_Click(object sender, EventArgs e)
        {
            if (inputOn)
            {
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 6.ToString();
                }
                else
                    displayLabel.Text += 6.ToString();
            }
            else
            {
                displayLabel.Text = "";
                inputOn = true;
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 6.ToString();
                }
                else
                    displayLabel.Text += 6.ToString();
            }

        }

        private void fiveBtn_Click(object sender, EventArgs e)
        {
            if (inputOn)
            {
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 5.ToString();
                }
                else
                    displayLabel.Text += 5.ToString();
            }
            else
            {
                displayLabel.Text = "";
                inputOn = true;
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 5.ToString();
                }
                else
                    displayLabel.Text += 5.ToString();
            }

        }

        private void fourBtn_Click(object sender, EventArgs e)
        {
            if (inputOn)
            {
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 4.ToString();
                }
                else
                    displayLabel.Text += 4.ToString();
            }
            else
            {
                displayLabel.Text = "";
                inputOn = true;
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 4.ToString();
                }
                else
                    displayLabel.Text += 4.ToString();
            }

        }

        private void threeBtn_Click(object sender, EventArgs e)
        {
            if (inputOn)
            {
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 3.ToString();
                }
                else
                    displayLabel.Text += 3.ToString();
            }
            else
            {
                displayLabel.Text = "";
                inputOn = true;
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 3.ToString();
                }
                else
                    displayLabel.Text += 3.ToString();
            }

        }

        private void twoBtn_Click(object sender, EventArgs e)
        {
            if (inputOn)
            {
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 2.ToString();
                }
                else
                    displayLabel.Text += 2.ToString();
            }
            else
            {
                displayLabel.Text = "";
                inputOn = true;
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 2.ToString();
                }
                else
                    displayLabel.Text += 2.ToString();
            }

        }

        private void oneBtn_Click(object sender, EventArgs e)
        {
            if (inputOn)
            {
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 1.ToString();
                }
                else
                    displayLabel.Text += 1.ToString();
            }
            else
            {
                displayLabel.Text = "";
                inputOn = true;
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 1.ToString();
                }
                else
                    displayLabel.Text += 1.ToString();
            }

        }

        private void zeroBtn_Click(object sender, EventArgs e)
        {
            if (inputOn)
            {
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 0.ToString();
                }
                else
                    displayLabel.Text += 0.ToString();
            }
            else
            {
                displayLabel.Text = "";
                inputOn = true;
                if (displayLabel.Text.Equals("0"))
                {
                    displayLabel.Text = "";
                    displayLabel.Text += 0.ToString();
                }
                else
                    displayLabel.Text += 0.ToString();
            }

        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(displayLabel.Text);
            operator1 = "+";
            gotFirstOperand = true;
            inputOn = false;
        }

        private void equalsBtn_Click(object sender, EventArgs e)
        {
            if (gotFirstOperand)
            {
                operand2 = double.Parse(displayLabel.Text); // add try parse here
                switch (operator1)
                {
                    case "+":
                        sum = operand1 + operand2;
                        break;
                    case "-":
                        sum = operand1 - operand2;
                        break;
                    case "*":
                        sum = operand1 * operand2;
                        break;
                    case "/":
                        sum = operand1 / operand2;
                        break;
                }

                displayLabel.Text = sum.ToString();
                operand1 = sum;
                inputOn = false;
            }
        }

        private void subtractBtn_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(displayLabel.Text);
            operator1 = "-";
            gotFirstOperand = true;
            inputOn = false;
        }

        private void divBtn_Click(object sender, EventArgs e)
        {
            operand1 = double.Parse(displayLabel.Text);
            operator1 = "/";
            gotFirstOperand = true;
            inputOn = false;
        }

        private void negateBtn_Click(object sender, EventArgs e)
        {
            double convertToDouble = double.Parse(displayLabel.Text);
            if (convertToDouble != 0)
            {
                convertToDouble = convertToDouble * -1;
                displayLabel.Text = convertToDouble.ToString();
            }
        }

        private void sRootBtn_Click(object sender, EventArgs e)
        {
            double convertToDouble = double.Parse(displayLabel.Text);

            if (convertToDouble < 0)
                displayLabel.Text = "Invalid Input";
            else
                displayLabel.Text = Math.Sqrt(convertToDouble).ToString();
        }
    }
}