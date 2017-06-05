using AvaliacaoAspNet.Models;
using AvaliacaoAspNet.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AvaliacaoAspNet.Views.Tipos
{
    public partial class CadastroTipo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            Tipo Tipo = new Tipo();
            Tipo.Nome = txtNome.Text;
            Tipo.Descricao = txtDescricao.Text;
            TiposControllers.Adicionar(Tipo);
        }
    }
}