using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shop.DAL;
using Shop.DTO;

namespace Shop.BLL
{
    public class UserBLL
    {
     /*Método chargeUser: retorna lista de objetos DTO, com vários atributos,
     acessando o BD para buscar TODOS os Usuários da table users */

    public IList<user_DTO> chargeUser()
        {
            try
            {
                return new UserDAL().chargeUser();
            }catch(Exception ex)
            {
                throw ex;
            }
        }
     public int inserirUsuario(user_DTO user)
        {
            //sobreescrita do método que será criado na DAL
            try
            {
                return new UserDAL().inserirUsuario(user);
            }catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
