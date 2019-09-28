using gradox.Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gradox.vista
{
    public partial class Mesas : System.Web.UI.Page
    {
        Ccontrola sb = new Ccontrola();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                listamesas();
            }
        }
        public void listamesas()
        {
            try
            {
                DataTable res = sb.ClistaMesa(Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridViewMesas.DataSource = res;
                    GridViewMesas.DataBind();
                }
                else
                {
                    GridViewMesas.DataSource = null;
                    GridViewMesas.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        protected void guardar_ServerClick(object sender, EventArgs e)
        {
            try
            {

                DataTable res = sb.CcreaMesa(txtdescripcion.Value.ToUpper(), txtnumeropuestos.Value, "1", Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    listamesas();
                    EXPCONTROLADA.MessageBox(this, "Registro Guardado");
                }
                else
                {
                    EXPCONTROLADA.MessageBox(this, "Algo salio mal en los datos suministrados");
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }

        }

        protected void GridViewMesas_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = GridViewMesas.SelectedRow;

            txtdescripcion.Value = Page.Server.HtmlDecode(gr.Cells[2].Text);
            txtnumeropuestos.Value = Page.Server.HtmlDecode(gr.Cells[3].Text);

        }

        protected void Modificar_ServerClick(object sender, EventArgs e)
        {

        }
    }
}