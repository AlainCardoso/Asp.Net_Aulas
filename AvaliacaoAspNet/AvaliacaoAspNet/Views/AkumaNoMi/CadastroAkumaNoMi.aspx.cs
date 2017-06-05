using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AvaliacaoAspNet.Models;
using AvaliacaoAspNet.Controllers;

namespace AvaliacaoAspNet.Views
{
    public partial class CadastroAkumaNoMi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            AkumaNoMi Ak = new AkumaNoMi();
            Tipo Tipo = new Tipo();
            Ak.Nome = txtNome.Text;
            Ak.Descricao = txtDescricao.Text;
            Ak.Habilidades = txtHabilidade.Text;
            if (rbtSim.Checked == true)
                Ak.Consumido = true;
            else
                Ak.Consumido = false;
            Tipo.Nome = ddlTipo.SelectedItem.Text;
            Ak.Tipo = TiposControllers.BuscarPorNome(Tipo);
            AkumaNoMisController.Adicionar(Ak);
        }

        protected void ddlTipo_Load(object sender, EventArgs e)
        {
            foreach(Tipo x in TiposControllers.ListarTipos())
            {
                ddlTipo.Items.Add(x.Nome);
            }
        }
    }
}