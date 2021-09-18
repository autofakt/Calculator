using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class MainForm : Form
    {
        double operand1;
        string operator1 = "";
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
                historyListBox.Items.Add(operand1 + " " + operator1 + " " + operand2 + " = " + sum);
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
                historyListBox.Items.Add("negation(" + (convertToDouble * -1).ToString() + ") = " + convertToDouble.ToString());
            }
        }

        private void sRootBtn_Click(object sender, EventArgs e)
        {
            double convertToDouble = double.Parse(displayLabel.Text);

            if (convertToDouble < 0)
                displayLabel.Text = "Invalid Input";
            else
            {
                displayLabel.Text = Math.Sqrt(convertToDouble).ToString();
                historyListBox.Items.Add("√" + convertToDouble.ToString() + " = " + Math.Sqrt(convertToDouble).ToString());
            }
        }

        private void cBtn_Click(object sender, EventArgs e)
        {
            operand1 = 0;
            operand2 = 0;
            operator1 = "";
            gotFirstOperand = false;
            inputOn = true;
            displayLabel.Text = "0";
        }

        private void x2Btn_Click(object sender, EventArgs e)
        {
            double convertToDouble = double.Parse(displayLabel.Text);
            displayLabel.Text = (convertToDouble * convertToDouble).ToString();
            historyListBox.Items.Add(convertToDouble.ToString() + "²" + " = " + (convertToDouble * convertToDouble).ToString());

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            if (inputOn)
            {
                string text = displayLabel.Text;
                if (text.Length > 1)
                {
                    string newText = text.Remove(text.Length - 1);
                    displayLabel.Text = newText;
                }
                else
                    displayLabel.Text = "0";
            }
            else
                SystemSounds.Beep.Play();
        }

        private void dotBtn_Click(object sender, EventArgs e)
        {
            string temp = displayLabel.Text;
            if (operator1=="")
            {
                if (temp.Contains('.'))
                    ;
                else
                {
                    displayLabel.Text = temp + ".";
                }
            }
            else if (operand1.ToString() == displayLabel.Text)
            {
                displayLabel.Text = "0.";
            }
            else
            {
                if (temp.Contains('.'))
                    ;
                else
                {
                    displayLabel.Text = temp + ".";
                }
            }
        }

        private void ceBtn_Click(object sender, EventArgs e)
        {
            displayLabel.Text = "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (historyPanel.Visible == false)
                historyPanel.Visible = true;
            else
                historyPanel.Visible = false;
        }

        private void historyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void x1Btn_Click(object sender, EventArgs e)
        {
            double convertToDouble = double.Parse(displayLabel.Text);
            displayLabel.Text = (1/ convertToDouble).ToString();
            historyListBox.Items.Add("1/" + convertToDouble.ToString()  + " = " + (1 / convertToDouble).ToString());

        }

        private void eraseHistoryBtn_Click(object sender, EventArgs e)
        {
            historyListBox.Items.Clear();
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            if (gotFirstOperand)
            {
                double percentage = double.Parse(displayLabel.Text);
                double result = operand1 * percentage / 100;
                displayLabel.Text = result.ToString();
                historyListBox.Items.Add(percentage.ToString() + "% of " + operand1 + " = " + result.ToString());
            }
                
            else
            {
                displayLabel.Text = "0";
            }
        }
    }
}
