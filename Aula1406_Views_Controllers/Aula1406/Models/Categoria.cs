using System.ComponentModel.DataAnnotations;

namespace Aula1406.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaID { get; set; }
        [Required(ErrorMessage = "Favor preencher o campo Nome!")]
        [StringLength(15, ErrorMessage = "Você excedeu o limite de 15 caractéres!")]
        public string Nome { get; set; }
        [Display(Name = "Descrição"), DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
        [Required]
        public bool Ativo { get; set; }
    }
}