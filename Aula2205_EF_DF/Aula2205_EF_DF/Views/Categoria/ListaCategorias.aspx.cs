using Aula2205_EF_DF.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Aula2205_EF_DF.Views.Categoria
{
    public partial class ListaCategorias : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Contexto (Referência para o banco)
            strConnLojaEntities contexto = new strConnLojaEntities();
            gvwCategorias.DataSource = contexto.Categoria.ToList();
            gvwCategorias.DataBind();
        }
    }
}