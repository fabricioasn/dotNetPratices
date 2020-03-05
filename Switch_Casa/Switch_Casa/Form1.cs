using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Switch_Casa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cboSemana.Text)
            {
                case "Domingo":
                    MessageBox.Show("Você escolheu Domingo, o 1º dia da semana.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case "Segunda":
                    MessageBox.Show("Você escolheu Segunda, o 2º dia da semana.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Terça":
                    MessageBox.Show("Você escolheu Terça, o 3º dia da semana.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Quarta":
                    MessageBox.Show("Você escolheu Quarta, o 4º dia da semana.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Quinta":
                    MessageBox.Show("Você escolheu Quinta, o 5º dia da semana.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Sexta":
                    MessageBox.Show("Você escolheu Sexta, o 6º dia da semana.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;

                case "Sábado":
                    MessageBox.Show("Você escolheu Sábado, o 7º dia da semana.", "Mensagem", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;


            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 novo = new Form2();
            novo.Show();
            this.Visible = false;


        }
    }
}
