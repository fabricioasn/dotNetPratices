using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSExercicios0
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, result;
            try{
                num1 = int.Parse(textBoxNum1.Text);
                num2 = int.Parse(textBoxNum2.Text);
                result = num1 + num2;
                textBoxResult.Text = result.ToString();
            }
            catch(Exception)
            {
                MessageBox.Show("Digite apenas valores numéricos!");
            }
            finally
            {
                MessageBox.Show("Aperte OK para sair.");
                Close();
            }
        }
    }
}
