using System.ComponentModel.DataAnnotations;

namespace ProjetoAspNet.Models
{
    public class Anuncio
    {
        public int AnuncioID { get; set; }
        [Required]
        public string Produto { get; set; }
        [Display(Name = "Descrição")]
        public string Descrição { get; set; }
        public string Tipo { get; set; }
        public decimal Valor { get; set; }
        public int UserID { get; set; }
    }
}