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
    public partial class Personas : System.Web.UI.Page
    {
        Ccontrola sb = new Ccontrola();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                listapersonas();
            }
        }
        public void listapersonas()
        {
            try
            {
                DataTable res = sb.ClistaPersona(Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridViewNovedades.DataSource = res;
                    GridViewNovedades.DataBind();
                }
                else
                {
                    GridViewNovedades.DataSource = null;
                    GridViewNovedades.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        protected void btnguardar_ServerClick(object sender, EventArgs e)
        {
            try
            {

                DataTable res = sb.CcreaPersona(txtcc.Value, txtnombres.Value.ToUpper()
                    , txtapellidos.Value.ToUpper(), txtdireccion.Value.ToUpper()
                    , txttelefono.Value, txtfnacimiento.Value, txtemail.Value.ToLower(), selectTipodoc.Value, Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    limpiaitems();
                    listapersonas();
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
                listapersonas();
                limpiaitems();
            }
        }
        public void limpiaitems()
        {
            txtid.InnerText = "";
            txtcc.Value = "";
            txtnombres.Value = "";
            txtapellidos.Value = "";
            txtdireccion.Value = "";
            txttelefono.Value = "";
            txtfnacimiento.Value = "";
            txtemail.Value = "";

        }
        protected void GridViewNovedades_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = GridViewNovedades.SelectedRow;
            txtid.InnerText = gr.Cells[1].Text;
            txtcc.Value = Page.Server.HtmlDecode(gr.Cells[2].Text);
            txtnombres.Value = Page.Server.HtmlDecode(gr.Cells[3].Text);
            txtapellidos.Value = Page.Server.HtmlDecode(gr.Cells[4].Text);
            txtdireccion.Value = Page.Server.HtmlDecode(gr.Cells[5].Text);
            txttelefono.Value = Page.Server.HtmlDecode(gr.Cells[6].Text);
            txtfnacimiento.Value = Page.Server.HtmlDecode(gr.Cells[7].Text);
            txtemail.Value = Page.Server.HtmlDecode(gr.Cells[8].Text);
            selectTipodoc.Value = Page.Server.HtmlDecode(gr.Cells[9].Text);
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable res = sb.CUpdPersona(txtid.InnerText, txtcc.Value, txtnombres.Value.ToUpper()
                    , txtapellidos.Value.ToUpper(), txtdireccion.Value.ToUpper()
                    , txttelefono.Value, txtfnacimiento.Value, txtemail.Value.ToLower(), selectTipodoc.Value, Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    limpiaitems();
                    listapersonas();
                    EXPCONTROLADA.MessageBox(this, "Registro Actualizado");
                }
                else
                {
                    EXPCONTROLADA.MessageBox(this, "Algo salio mal en los datos suministrados");
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
                listapersonas();
                limpiaitems();
            }
        }
        protected void btnborra_Click(object sender, EventArgs e)
        {
            if (txtid.InnerText.Equals(""))
            {
                EXPCONTROLADA.MessageBox(this, "Seleccione un Registro de la Tabla");
            }
            else
            {
                try
                {

                    DataTable res = sb.CDELpersona(txtid.InnerText, Session["BD"].ToString());
                    if (res.Rows.Count > 0)
                    {
                        limpiaitems();
                        listapersonas();
                        EXPCONTROLADA.MessageBox(this, "Registro Borrado");
                    }


                }
                catch (Exception)
                {
                    EXPCONTROLADA.MessageBox(this, "Algo salio mal en los datos suministrados");


                }
            }


        }
    }
}