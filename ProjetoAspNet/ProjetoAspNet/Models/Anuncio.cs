using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoAspNet.Models
{
    public class Anuncio
    {
        public int AnuncioID { get; set; }
        public string Produto { get; set; }
        public string Descrição { get; set; }
        public string Tipo { get; set; }
        public ApplicationUser User { get; set; }
    }
}