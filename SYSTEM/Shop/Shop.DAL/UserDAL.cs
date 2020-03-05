using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DTO;
using System.Data.SqlClient;

namespace Shop.DAL
{
    public class UserDAL
    {
        /*Método chargeUser: retorna lista de objetos DTO, com vários atributos,
    acessando o BD para buscar TODOS os Usuários da table users */
        public IList<user_DTO> chargeUser()
        {
            try
            {
                /*Conexão com o BD
                * Seleção dos dados completos da tb_Users */
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = Properties.Settings.Default.CST;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "SELECT * FROM tbl_Users";
                cmd.Connection = conn;

                /* variávei tipo DataReader para captura de dados do BD 
                transpondo as EntidadesRelacionamento em Objetos*/
                SqlDataReader ER; 
                IList<user_DTO> listUserDTO = new List<user_DTO>();

                conn.Open(); //abertura da conexão
                ER = cmd.ExecuteReader(); //executa o comando para capturar dados

                //validação de existência de registros para enviá-los à lista
                if (ER.HasRows)
                {
                    while (ER.Read())
                    {
                        user_DTO user = new user_DTO();
                        /*Este é o objeto entidade user criado na DTO
                        *Cada um criado é enviado a lista, se houver registro */

                        //campos de um objeto user da classe DTO
                    user.cod_user = Convert.ToInt32(ER["cod_user"]);
                    user.profile = Convert.ToInt32(ER["profile"]);
                    user.register = Convert.ToDateTime(ER["register"]);
                    user.name = Convert.ToString(ER["name"]);
                    user.email = Convert.ToString(ER["email"]);
                    user.login = Convert.ToString(ER["register"]);
                    user.password = Convert.ToString(ER["password"]);
                    user.situation = Convert.ToString(ER["situation"]);
                    listUserDTO.Add(user);
                    
                    }
                }
                return listUserDTO;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
