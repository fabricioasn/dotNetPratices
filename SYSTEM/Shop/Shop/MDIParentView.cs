using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shop
{
    public partial class MDIParentView : Form
    {
        private int childFormNumber = 0;

        public MDIParentView()
        {
            InitializeComponent();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Chamada do form para cadastro de usuários que referencia a classe DTO User */
            Form childForm = new Cadastro_usuario();
            childForm.MdiParent = this;
            childForm.Show();
        }
    }      
}
