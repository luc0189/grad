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
    public partial class Empresa : System.Web.UI.Page
    {
        Ccontrola sb = new Ccontrola();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                entidad();
            }

        }
        public void entidad()
        {
            try
            {
                DataTable res = sb.ClistaEmpresa(Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    DataRow[] result = res.Select();

                    foreach (DataRow row in result)
                    {
                        txtnit.Value = row[0].ToString();
                        txtnombre.Value = row[1].ToString();
                        selectRegimen.Value = row[2].ToString();
                        txtdireccion.Value = row[3].ToString();
                        txteslogan.Value = row[4].ToString();
                        txttelefono.Value = row[5].ToString();
                        txtemail.Value = row[6].ToString();
                        txtid.InnerText = row[7].ToString();
                    }


                }
                else
                {
                    EXPCONTROLADA.MessageBox(this, "No se encontro ninguna empresa Asociada");
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

                DataTable res = sb.Ccreaentidad(txtnit.Value, txtnombre.Value.ToUpper(),
                    selectRegimen.Value, txtdireccion.Value.ToUpper(), txttelefono.Value,
                    txtemail.Value, txteslogan.Value.ToUpper(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {

                    EXPCONTROLADA.MessageBox(this, "Empresa Registrada");
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

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable res = sb.CUdpentidad(txtid.InnerText, txtnit.Value, txtnombre.Value.ToUpper(),
                 selectRegimen.Value, txtdireccion.Value.ToUpper(), txttelefono.Value,
                 txtemail.Value, txteslogan.Value.ToUpper(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    entidad();
                    EXPCONTROLADA.MessageBox(this, "Informacion Actualizada");
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