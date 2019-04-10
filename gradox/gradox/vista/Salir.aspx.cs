using gradox.Controlador;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gradox.vista
{
    public partial class Salir : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                salirx();
            }

        }
        public void salirx()
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