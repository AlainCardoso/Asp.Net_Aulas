using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraAsp
{
    public partial class PaginaSoma : System.Web.UI.Page
    {
        public int Num1
        {
            get
            {
                return Convert.ToInt32(ViewState["Numero1"]);
            }
            set
            {
                ViewState["Numero1"] = value;
            }
        }

        public int Num2
        {
            get
            {
                return Convert.ToInt32(ViewState["Numero2"]);
            }
            set
            {
                ViewState["Numero2"] = value;
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Num1 = 0;
                Num2 = 0;
            }
        }

        protected void btnSoma_Click(object sender, EventArgs e)
        {
            Num1 = int.Parse(txtNumero1.Text);
            Num2 = int.Parse(txtNumero2.Text);
            lblSoma.Text = "A soma é: " + (Num1+Num2).ToString();
        }

        protected void btnResultado_Click(object sender, EventArgs e)
        {
            Session.Add("Numero1Session", txtNumero1.Text);
            Session.Add("Numero2Session", txtNumero2.Text);
            Response.Redirect("~/PaginaResultado");
        }
    }
}