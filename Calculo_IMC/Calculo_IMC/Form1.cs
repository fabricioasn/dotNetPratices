using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculo_IMC
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double peso, altura, imc;
            peso = Convert.ToDouble(txtPeso.Text);
            altura = Convert.ToDouble(txtAltura.Text);
            imc = peso / (altura * altura);
            txtImc.Text = imc.ToString("0.00");

            if (imc < 18.49)
            {
                MessageBox.Show("Situação: Você está abaixo do Peso.", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (imc < 24.99)
            {
                MessageBox.Show("Situação: Você está com peso dentro dos padrões normais.", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (imc < 29.99)
            {
                MessageBox.Show("Situação: Você está acima do peso.", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (imc < 34.99)
            {
                MessageBox.Show("Atenção! Você está com Obesidade Grau I.", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else if (imc < 39.99)
            {
                MessageBox.Show("Atenção! Você está com Obesidade grave(grau II).", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                MessageBox.Show("Atenção! Você está com Obesidade grau III(Mórbida).", "IMC", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }




        }

        private void button2_Click(object sender, EventArgs e)
        {

            txtAltura.Text = "";
            txtPeso.Text = "";
            txtPeso.Text = "";
            txtImc.Text = "";  



        }
    }
}
