using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalMariaH.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Column("Id")]
        [Display(Name = "Id do Usuário")]
        public int Id { get; set; }

        [Column("UsuarioNome")]
        [Display(Name = "Nome do Usuário")]
        public string UsuarioNome { get; set; } = string.Empty;

        [Column("UsuarioEmail")]
        [Display(Name = "Email do Usuário:")]
        public string UsuarioEmail { get; set; } = string.Empty;


        [Column("UsuarioSenha")]
        [Display(Name = "Senha do Usuário:")]
        public string UsuarioSenha { get; set; } = string.Empty;
    }
}
