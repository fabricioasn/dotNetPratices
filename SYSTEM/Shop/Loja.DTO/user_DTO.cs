using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.DTO
{
   public class user_DTO
    { /*Classe Entidade de ORM para armazenar variáveis do Banco */
        public int cod_user { get; set; }
        public string name { get; set; }
        public string login { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public DateTime register { get; set; }
        public string situation { get; set; }
        public int profile { get; set; }

    }
}
