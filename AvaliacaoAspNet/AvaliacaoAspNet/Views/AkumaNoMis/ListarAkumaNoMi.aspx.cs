using AvaliacaoAspNet.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AvaliacaoAspNet.Views.AkumaNoMi
{
    public partial class ListarAkumaNoMi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvwAkumaNoMi.DataSource = AkumaNoMisController.ListarConsumidos();
            gvwAkumaNoMi.DataBind();
        }
    }
}