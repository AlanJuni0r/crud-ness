using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUD_NESS_ALAN.Models
{
    [Table("Personagem")]
    public class Personagem
    {
        [Display(Description = "Código")]
        public int Id { get; set; }

        [Display(Description = "Nome do Personagem")]
        public string NomePersonagem { get; set; }

        [Display(Description = "Tipo de Poder")]
        public int Poder { get; set; }
    }
}
