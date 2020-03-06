using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shop.BLL;
using Shop.DTO;
namespace Shop
{
    public partial class Cadastro_usuario : Form
    {
        public Cadastro_usuario()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboSituation_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cadastro_usuario_Load(object sender, EventArgs e)
        {
            try
            {
                IList<user_DTO> listUser_DTO = new List<user_DTO>();
                listUser_DTO = new UserBLL().chargeUser();
                //preenchimento dos dados no DataGridView
                dataGridView1.DataSource = listUser_DTO;


            } catch (Exception ex)
            {
                throw ex;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /* evento para exibir nos campos a linha que estiver 
             * selecionada no momento */
            int selected = dataGridView1.CurrentRow.Index;
            //valor de cada dataGrid enviado para o respectivo txtBox
            txtBoxName.Text = Convert.ToString(dataGridView1["name", selected].Value);
            txtBoxLogin.Text = Convert.ToString(dataGridView1["login", selected].Value);
            txtBoxEmail.Text = Convert.ToString(dataGridView1["email", selected].Value);
            txtBoxPswd.Text = Convert.ToString(dataGridView1["password", selected].Value);
            txtBoxReg.Text = Convert.ToString(dataGridView1["register", selected].Value);
            /*validação condicional para verificar a situação, 
             * caso A combobox seleciona Ativo, caso I seleciona Inativo*/
            if (Convert.ToString(dataGridView1["situation", selected].Value) == "A")
            {
                cboSituation.Text = "Ativo";
            }
            else {
                cboSituation.Text = "Inativo";
                cboProfile.Text = Convert.ToString(dataGridView1["profile", selected].Value);
            }
            switch (Convert.ToString(dataGridView1["profile", selected].Value)){
                /*switchcase para escolher qual o nome exibido no data grid 
                 * para o perfil designado 1-admin, 2-operac, 3-gerenc */
                case "1":
                    cboProfile.Text = "Administrador";
                    break;
                case "2":
                    cboProfile.Text = "Operacional";
                    break;
                case "3":
                    cboProfile.Text = "Gerencial";
                    break;
            }
         }
 }
}
