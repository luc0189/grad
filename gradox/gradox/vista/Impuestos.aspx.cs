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
    public partial class Impuestos : System.Web.UI.Page
    {
        Ccontrola sb = new Ccontrola();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
             
                ListaImpuestos();
            }
        }
        public void ListaImpuestos()
        {
            try
            {
                string bd = Session["BD"].ToString();
                DataTable res = sb.ClistaImpuesto(bd);
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
            catch (Exception E)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion Interna: " + E.Message);
            }
        }
        protected void creaImpuesto(object sender, EventArgs e)
        {
            string estado = "";
            try
            {
                if (inputcheck_estado.Checked)
                {
                    estado = "1";
                }

                else
                {
                    estado = "0";
                }

                DataTable res = sb.CcreaImpuesto(txtnombreP.Value.ToUpper(), txtvalor.Value, estado, Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    ListaImpuestos();

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

        protected void btnguardar_ServerClick()
        {
            string estado = "";
            try
            {
                if (inputcheck_estado.Checked)
                {
                    estado = "1";
                }

                else
                {
                    estado = "0";
                }

                DataTable res = sb.CcreaImpuesto(txtnombreP.Value.ToUpper(), txtvalor.Value, estado, Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    ListaImpuestos();

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
    }
}