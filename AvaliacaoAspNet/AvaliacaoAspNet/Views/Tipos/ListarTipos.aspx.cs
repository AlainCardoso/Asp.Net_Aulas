using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AvaliacaoAspNet.Controllers;

namespace AvaliacaoAspNet.Views.Tipos
{
    public partial class ListarTipos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvwListarTipos.DataSource = TiposControllers.ListarTipos();
            gvwListarTipos.DataBind();
        }
    }
}