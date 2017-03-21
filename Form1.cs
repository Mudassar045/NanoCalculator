using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double res = 0;
        String op = "";
        bool isOperation = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            if (screen.Text == "0" || isOperation )
                screen.Clear();
            isOperation = false;
            Button input = (Button)sender;
            if (input.Text == ".")
            {
                if(!screen.Text.Contains("."))
                    screen.Text = screen.Text + input.Text;
            }
            else
            screen.Text = screen.Text + input.Text;
           
        }

        private void op_click(object sender, EventArgs e)
        {
            Button op_input = (Button)sender;
            if (res != 0)
            {
                button11.PerformClick();
                op = op_input.Text;
                if (op == "sin" || op == "cos" || op == "tan")
                {
                    labelOperation.Text = op + "( " + res + " )";
                    isOperation = true;
                }
                else
                {
                    labelOperation.Text = res + " " + op;
                    isOperation = true;
                }
            }
            else
            {
                op = op_input.Text;
                res = Convert.ToDouble(screen.Text);
                if (op == "sin" || op == "cos" || op == "tan")
                {
                    labelOperation.Text = op + "( " + res + " )";
                    isOperation = true;
                }
                else
                {
                    labelOperation.Text = res + " " + op;
                    isOperation = true;
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
            labelOperation.Text = "";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            screen.Text = "0";
            labelOperation.Text = "";
            res = 0;
        }

        private void operation(object sender, EventArgs e)
        {
            switch (op)
            {
                case "+":
                    screen.Text = (res + Convert.ToDouble(screen.Text)).ToString();
                    break;
                case "-":
                    screen.Text = (res - Convert.ToDouble(screen.Text)).ToString();
                    break;
                case "*":
                    screen.Text = (res * Convert.ToDouble(screen.Text)).ToString();
                    break;
                case "/":
                    screen.Text = (res / Convert.ToDouble(screen.Text)).ToString();
                    break;
                case "!":
                    {
                        int fact = 1;
                        if (res>=3)
                        {
                            Console.WriteLine(res);
                            for (int i = 1; i <= res; i++)
                            {
                                fact *= i;
                            }
                        }
                        screen.Text = fact.ToString();
                    }
                    break;
                case "sin":
                    {
                        screen.Text = (Math.Sin(60)).ToString();
                    }
                    break;
                case "cos":
                    {
                        screen.Text = (Math.Cos(res)).ToString();
                    }
                    break;
                case "tan":
                    {
                        screen.Text = (Math.Tan(res)).ToString();
                    }
                    break;

                default:
                    break;
            }
            res = Convert.ToDouble(screen.Text);
            labelOperation.Text ="";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.BackColor = colorDialog1.Color;
               // this.ForeColor = colorDialog1.Color;
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.ForeColor = colorDialog1.Color;
            }
        }
    }
}
