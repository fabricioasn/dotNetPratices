using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_de_Média
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateAvg_Click(object sender, EventArgs e)
        {
            try { 
            double num1, num2, num3, result;
            num1 = Convert.ToDouble(txtBoxGrade1.Text);
            num2 = Convert.ToDouble(txtBoxGrade2.Text);
            num3 = Convert.ToDouble(txtBoxGrade3.Text);
            result = (num1 + num2 + num3) / 3;
            txtBoxResult.Text = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Digite apenas valores numéricos!");  
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtBoxGrade1.Text = "";
            txtBoxGrade2.Text = "";
            txtBoxGrade3.Text = "";
            txtBoxResult.Text = "";
        }
    }
}
