﻿using Aula2405_EF_MF.Controllers;
using Aula2405_EF_MF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2405_EF_MF.Views.Categorias
{
    public partial class Adicionar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSalvar_Click(object sender, EventArgs e)
        {
            CategoriasController ctrl = new CategoriasController();
            Categoria categoria = new Categoria();
            categoria.Nome = txtNome.Text;
            categoria.Descricao = txtDescricao.Text;
            categoria.Ativo = true;
            ctrl.Adicionar(categoria);
        }
    }
}