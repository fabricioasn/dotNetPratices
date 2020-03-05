using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculoMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            txtNota1.Text = "";
            txtNota2.Text = "";
            txtNota3.Text = "";
            txtMedia.Text = "";
            

        }

        private void btnSair_Click(object sender, EventArgs e)
        {

            Close();  


        }

        private void button1_Click(object sender, EventArgs e)
        {

            double n1, n2, n3, media;
            n1 = Convert.ToDouble(txtNota1.Text);
            n2 = Convert.ToDouble(txtNota2.Text);
            n3 = Convert.ToDouble(txtNota3.Text);
            media = (n1 + n2 + n3) / 3;
            txtMedia.Text = media.ToString();

            if (media >= 7)
            {
                MessageBox.Show("Você foi aprovado.","Resultado",MessageBoxButtons.OK,MessageBoxIcon.Information);  
            }
            else
            {
                MessageBox.Show("Você foi reprovado.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               
            }
              

            
        }
    }
}
