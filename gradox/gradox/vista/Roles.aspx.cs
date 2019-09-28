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
    public partial class Roles : System.Web.UI.Page
    {
        Ccontrola sb = new Ccontrola();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

            }
        }
        public void buscaRol()
        {
            try
            {
                DataTable res = sb.CBuscaRol(txtbuscador.Value.ToString().ToUpper(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridViewbuscador.DataSource = res;
                    GridViewbuscador.DataBind();
                }
                else
                {
                    GridViewbuscador.DataSource = null;
                    GridViewbuscador.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        public void listausuarios()
        {

        }
        protected void btnGuarda_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable res = sb.CcreaRol(txtnombre.Value.ToUpper(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {

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

        protected void btnbuscarp_Click(object sender, EventArgs e)
        {
            buscaRol();
        }

        protected void GridViewbuscador_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = GridViewbuscador.SelectedRow;
            TxtIdproducto.InnerText = gr.Cells[1].Text;
            txtnombre.Value = Page.Server.HtmlDecode(gr.Cells[2].Text);

        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable res = sb.CupdRol(TxtIdproducto.InnerText, txtnombre.Value.ToUpper(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {

                    EXPCONTROLADA.MessageBox(this, "Registro Modificado");
                    buscaRol();
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

        protected void btnElimina_Click(object sender, EventArgs e)
        {
            try
            {

                DataTable res = sb.CDELRol(TxtIdproducto.InnerText, Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {

                    EXPCONTROLADA.MessageBox(this, "Registro Borrado");
                    buscaRol();
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
    }
}