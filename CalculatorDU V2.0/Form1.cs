using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatorDU_V2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double value = 0;
        string operation = "";
        bool operation_pressed = false;

        private void button6_Click(object sender, EventArgs e) // C
        {
            result.Clear();
            value = 0;
        }

        private void button_Click(object sender, EventArgs e) //cisla
        {
            if ((result.Text == "0")||(operation_pressed)) //ked he operation pressed true tak clearuje
            {
                result.Clear();
            }

            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }

        private void button5_Click(object sender, EventArgs e) //CE
        {
            result.Text = "0";
        }

        private void operator_click(object sender, EventArgs e) //operatory
        {
            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
        }

        private void button11_Click(object sender, EventArgs e) // =
        {
            equation.Text = "";
            switch (operation)
            {
                
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;

                default:
                    break;
            }
        }
    }
}
