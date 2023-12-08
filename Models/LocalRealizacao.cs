using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml.Linq;

namespace ProjetoFinalMariaH.Models
{

    [Table("LocalRealizacao")]

    public class LocalRealizacao
    {
        [Column("Id")]
        [Display(Name = "Id do Local da Realização")]
        public int Id { get; set; }

        [Column("LocalNome")]
        [Display(Name = "Nome do Local da Realização")]
        public string LocalNome { get; set; } = string.Empty;

        [ForeignKey("CidadeId")]
        [Display(Name = "Nome da Cidade")]
        public int CidadeId { get; set; }

        public Cidade? Cidade { get; set; }
    }
}
