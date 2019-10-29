using System.ComponentModel.DataAnnotations;

namespace Exemplo_02.Models
{
    public class UsuarioModel
    {
        [Key]
        public int usr_id { get; set; }

        public string nome { get; set; }

        public string email { get; set; }

        public string senha { get; set; }
    }
}