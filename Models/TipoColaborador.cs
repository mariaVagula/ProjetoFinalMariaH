using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalMariaH.Models
{
    [Table("TipoColaborador")]
    public class TipoColaborador
    {
        [Column("Id")]
        [Display(Name = "Id do tipo do Colaborador")]
        public int Id { get; set; }

        [Column("TipoColaboradorNome")]
        [Display(Name = "Nome do Tipo do Colaborador")]
        public string TipoColaboradorNome { get; set; } = string.Empty;
    }
}
