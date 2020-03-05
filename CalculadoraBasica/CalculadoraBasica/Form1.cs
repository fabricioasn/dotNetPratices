using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBasica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            double num1, num2, result;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            result = num1 / num2;
            txtResultado.Text = result.ToString();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            result = num1 - num2;
            txtResultado.Text = result.ToString();



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double num1, num2, result;
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            result = num1 + num2;
            txtResultado.Text = result.ToString();  


        }

        private void button3_Click(object sender, EventArgs e)
        {
            double num1, num2, result;  
            num1 = Convert.ToDouble(txtNum1.Text);
            num2 = Convert.ToDouble(txtNum2.Text);
            result = num1 * num2;
            txtResultado.Text = result.ToString();


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResultado.Text = ""; 

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
