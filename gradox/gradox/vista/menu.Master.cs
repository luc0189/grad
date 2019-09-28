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
    public partial class menu : System.Web.UI.MasterPage
    {
        Ccontrola sb = new Ccontrola();
        protected void Page_Load(object sender, EventArgs e)
        {
            suma_valores_dp();
            if (!Page.IsPostBack)
            {
                suma_valores_dp();
                if (Session["pid"] == null)
                {
                    EXPCONTROLADA.MessageBox(this.Page, "Seleccione una Mesa a Atender");
                }
                else
                {
                    txtidmesa.InnerText = Session["pid"].ToString();
                }


            }
        }
        public void suma_valores_dp()
        {
            try
            {
                if (Session["pid"] == null)
                {
                    EXPCONTROLADA.MessageBox(this.Page, "Seleccione una Mesa a Atender");
                }
                else
                {
                    try
                    {

                        DataTable res = sb.CSumadetalle_pedido(Session["pid"].ToString(), Session["BD"].ToString());
                        if (res.Rows.Count > 0)
                        {
                            DataRow row = res.Rows[0];
                            txtvalue.InnerText = row["TOTAL"].ToString();
                            txtnumeroitems.InnerText = row["ITEMS"].ToString();
                            txtnumeroitems2.InnerText = row["ITEMS"].ToString();

                        }


                    }
                    catch (Exception exp)
                    {
                        EXPCONTROLADA.MessageBox(this.Page, "Excepcion Interna: " + exp.Message);

                    }
                }
            }
            catch (Exception)
            {
                EXPCONTROLADA.MessageBox(this.Page, "Seleccione una Mesa a Atender");
            }



        }
    }
}