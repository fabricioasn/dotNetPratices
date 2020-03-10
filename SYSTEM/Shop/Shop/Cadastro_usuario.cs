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
        string mode = "";
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

        private void btnNew_Click(object sender, EventArgs e)
        {
            //chamada de método para limpeza dos campos
            limpar_campos();
            //inserir no campo register a data atual, após clicar em Novo
            txtBoxReg.Text = Convert.ToString(System.DateTime.Now);
            //registro em string do click no botão novo, carregado após o feito
            mode = "novo"; 
        }
      // método para limpar todos os campos
       private void limpar_campos()
        {
            txtBoxName.Text = "";
            txtBoxLogin.Text = "";
            txtBoxPswd.Text = "";
            txtBoxEmail.Text = "";
            txtBoxReg.Text = "";
            cboProfile.Text = "";
            cboSituation.Text = "";

        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (mode == "novo")
            {
                try
                {
                    //instanciação do objeto usuário, que conta registros de usuário no BD
                    user_DTO user = new user_DTO();
                    user.name = txtBoxName.Text;
                    user.login = txtBoxLogin.Text;
                    user.password = txtBoxPswd.Text;
                    user.email = txtBoxEmail.Text;
                    user.register = System.DateTime.Now;
                    if(cboSituation.Text == "Ativo")
                    {
                        user.situation = "A";
                    }else
                    {
                        user.situation = "I";
                    }
                    switch (cboProfile.Text)
                    {
                        case "Administrador":
                            user.profile = 1;
                            break;
                        case "Operacional":
                            user.profile = 2;
                            break;
                        case "Gerencial":
                            user.profile = 3;
                            break;
                    }

                    //teste do método para inserção de novo usuário na classe BLL
                    int cont = new UserBLL().inserirUsuario(user);
                    if (cont > 0)
                    {
                     MessageBox.Show("Novo usuário gravado com sucesso!");

                    }

                }catch(Exception ex)
                {
                    MessageBox.Show("Erro Inesperado!" + ex.Message);
                }



            }
            mode = "";
        }
    }
}
