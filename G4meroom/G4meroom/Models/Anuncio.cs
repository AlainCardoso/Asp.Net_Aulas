using System.ComponentModel.DataAnnotations;

namespace G4meroom.Models
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
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string UserID { get; set; }
    }
}