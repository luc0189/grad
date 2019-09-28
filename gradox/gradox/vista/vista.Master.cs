using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gradox.vista
{
    public partial class vista : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Session["NOMBRE"] == null || Session["ROL"] == null)
                {
                    Session["NOUSER"] = "Ingrese Usuario y Contraseña";
                    Response.Redirect("../Login.aspx");
                }
                else
                {
                    Txtnombre.InnerText = Session["NOMBRE"].ToString();
                    txtrol.InnerText = Session["ROL"].ToString();
                }

            }
        }
        protected void BtnSalir_ServerClick(object sender, EventArgs e)
        {
            Session.Remove("USUARIO");
            Session.Remove("perfil");
            Session.Remove("NOMBRE");
            Session.Remove("CC");
            Session.Remove("ROL");
            Session.Remove("BD");

            Response.Redirect("../Login.aspx");
        }
    }
}