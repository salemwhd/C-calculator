using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationperformed = false;
        public Form1()
        {
            InitializeComponent();
            textBox_Result.Height = 40;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

         void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonOne_Click(object sender, EventArgs e)
        {
            
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox_Result.Text == "0")||(isOperationperformed))
                textBox_Result.Clear();

            isOperationperformed = false;
            Button button = (Button)sender;

            if (button.Text == ".")
            {
                if (!textBox_Result.Text.Contains("."))
                    textBox_Result.Text = textBox_Result.Text + button.Text;

            }
            else
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }
        

        private void operaror_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox_Result.Text);
            labelCurrent.Text = resultValue + " " + operationPerformed;
            isOperationperformed = true;
        }

        private void buttonCe_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultValue = 0;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            switch (operationPerformed) {
                case "+" :
                    textBox_Result.Text = (resultValue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultValue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultValue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultValue / Double.Parse(textBox_Result.Text)).ToString();
                    break;

                default:
                    break;



            }
        }
    }
}
