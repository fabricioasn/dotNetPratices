using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginSenha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConfirma_Click(object sender, EventArgs e)
        {
            string user, pass;
            user = txtUser.Text;
            pass = txtPass.Text;

            if(user=="Admin" && pass == "12345678")
            {
                Form2 novo = new Form2();
                novo.Show();
                this.Visible = false; 
                           
            }

        }
    }
}
