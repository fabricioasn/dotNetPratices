using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Banco_De_Dados
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = Properties.Settings.Default.CST;

            try
            {
                conn.Open();
                /* Criar comando SQL, selecionando todos os registros da tbl.Clientes no BD Loja */
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT * FROM tbl_Clientes";
                cmd.CommandType = CommandType.Text;
                cmd.Connection = conn;
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                /* Carregar dados do DataGrid, puxados do BD Loja */
                DataTable dt = new DataTable();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dataGridView1.Refresh();

                conn.Close();
                MessageBox.Show("A conexão foi realizada com sucesso!");
            }catch(Exception ex)
            {
                MessageBox.Show(String.Format("Falha na conexão: {0}", ex.Message));
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
