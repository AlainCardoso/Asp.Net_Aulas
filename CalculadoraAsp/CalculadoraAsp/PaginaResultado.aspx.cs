using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CalculadoraAsp
{
    public partial class PaginaResultado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            int Num1ViewState = Convert.ToInt32(ViewState["Numero1"]);
            int Num1Session = Convert.ToInt32(Session["Numero1Session"]);
            int Num2ViewState = Convert.ToInt32(ViewState["Numero2"]);
            int Num2Session = Convert.ToInt32(Session["Numero2Session"]);

            lblSoma.Text = Num1Session.ToString() + " + " + Num2Session.ToString() + " = " + (Num1Session + Num2Session).ToString();
            lblSubtracao.Text = Num1Session.ToString() + " - " + Num2Session.ToString() + " = " + (Num1Session - Num2Session).ToString();
            lblMultiplicacao.Text = Num1Session.ToString() + " x " + Num2Session.ToString() + " = " + (Num1Session * Num2Session).ToString();
            lblDivisao.Text = Num1Session.ToString() + " / " + Num2Session.ToString() + " = " + (Num1Session / Num2Session).ToString();
        }
    }
}