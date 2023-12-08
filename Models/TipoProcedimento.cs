using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace ProjetoFinalMariaH.Models
{
    [Table("TipoProcedimento")]
    public class TipoProcedimento
    {
        [Column("Id")]
        [Display(Name = "Id do Tipo do Procedimento")]
        public int Id { get; set; }

        [Column("TipoProcedimentoNome")]
        [Display(Name = "Nome do Tipo do Procedimento")]
        public string TipoProcedimentoNome { get; set; } = string.Empty;
    }
}
