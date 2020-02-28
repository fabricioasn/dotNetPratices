using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraBásica
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(txtBoxNum1.Text);
            num2 = Convert.ToDouble(txtBoxNum2.Text);
            result = num1 + num2;
            txtBoxResult.Text = result.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxNum1.Text = "";
            txtBoxNum2.Text = "";
            txtBoxResult.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(txtBoxNum1.Text);
            num2 = Convert.ToDouble(txtBoxNum2.Text);
            result = num1 - num2;
            txtBoxResult.Text = result.ToString();
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            double num1, num2, result;
            num1 = Convert.ToDouble(txtBoxNum1.Text);
            num2 = Convert.ToDouble(txtBoxNum2.Text);
            result = num1 * num2;
            txtBoxResult.Text = result.ToString();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {

            try { 
            double num1, num2, result;
            num1 = Convert.ToDouble(txtBoxNum1.Text);
            num2 = Convert.ToDouble(txtBoxNum2.Text);
            result = num1 / num2;
            txtBoxResult.Text = result.ToString();
            }
            catch (DivideByZeroException)
            {
            MessageBox.Show("O segundo número é o denominador e, portanto, não pode ser 0!");
            }

        }
    }
}
