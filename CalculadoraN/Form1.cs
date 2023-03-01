using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace CalculadoraN
{
    public partial class Form1 : Form
    {
        decimal value1 = 0, value2 = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn9.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox1.Text += btn0.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            value1 = Decimal.Parse(textBox1.Text);
            textBox1.Text += btnPlus;
            textBox1.Text = "";
            operacao = "SOMA";
        }
        private void btnSub_Click(object sender, EventArgs e)
        {
            value1 = Decimal.Parse(textBox1.Text);
            textBox1.Text += btnSub;
            textBox1.Text = "";
            operacao = "SUB";

        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            value1 = Decimal.Parse(textBox1.Text);
            textBox1.Text += btnMult;
            textBox1.Text = "";
            operacao = "MULT";
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            value1 = Decimal.Parse(textBox1.Text);
            textBox1.Text += btnDiv;
            textBox1.Text = "";
            operacao = "DIV";
        }
        private void btnEqual_Click(object sender, EventArgs e)
        {
            value2 = Decimal.Parse(textBox1.Text);
            if(operacao == "SOMA")
            {
                textBox1.Text = Convert.ToString(value1 + value2);
            }

            if (operacao == "SUB")
            {
                textBox1.Text = Convert.ToString(value1 - value2);
            }

            if (operacao == "MULT")
            {
                textBox1.Text = Convert.ToString(value1 * value2);
            }

            if (operacao == "DIV")
            {
                textBox1.Text = Convert.ToString(value1 / value2);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            textBox1.Text += btnComma.Text;
        }

        
    }
}
