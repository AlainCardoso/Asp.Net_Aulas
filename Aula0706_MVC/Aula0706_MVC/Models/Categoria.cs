﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Aula0706_MVC.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        [Required]
        public string Nome { get; set; }
        [Display (Name = "Descrição"), DataType(DataType.MultilineText)]
        public string Descricao { get; set; }
        public bool Ativo { get; set; }
    }
}