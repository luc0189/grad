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
    public partial class Appmesas : System.Web.UI.Page
    {
        Ccontrola sb = new Ccontrola();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                BindProductRepeater();

            }


        }

        private void BindProductRepeater()
        {
            try
            {
                DataTable res = sb.ClistaMesa(Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    RepeateMesas.DataSource = res;
                    RepeateMesas.DataBind();

                }
            }
            catch (Exception ex)
            {

                EXPCONTROLADA.MessageBox(this, "error:" + ex.Message);
            }
        }



        public void ir(Object sender, EventArgs e)
        {
            string nombre = "";

            nombre = ((System.Web.UI.WebControls.LinkButton)sender).Text;
            string string2 = nombre.Substring(0, 1);
            Session["idmesa"] = string2;
            try
            {
                DataTable resp = sb.CBuscaMesalibre(string2, Session["BD"].ToString());
                if (resp.Rows.Count > 0)
                {
                    DataRow row = resp.Rows[0];
                    Session["Estado"] = row["ESTADO"].ToString();

                }
                if (Session["Estado"].ToString().Equals("LIBRE"))
                {
                    DataTable res = sb.Cpedido(string2, Session["BD"].ToString());
                    if (res.Rows.Count > 0)
                    {
                        DataRow row = res.Rows[0];
                        Session["pidpedido"] = row["ID"].ToString();

                    }

                }
                else
                {
                    DataTable resnocrea = sb.CListaIdpedio(string2, Session["BD"].ToString());
                    if (resnocrea.Rows.Count > 0)
                    {
                        DataRow row = resnocrea.Rows[0];
                        Session["pidpedido"] = row["ID"].ToString();

                    }

                }



            }
            catch (Exception exp)
            {

                EXPCONTROLADA.MessageBox(this, exp.Message);
            }
            Response.Redirect("WebForm1.aspx");

        }
        public string traenumeropedido(string mesa)
        {
            string numero = "";
            DataTable res = sb.Cpedido(mesa, Session["BD"].ToString());
            if (res.Rows.Count > 0)
            {
                DataRow row = res.Rows[0];
                Session["pidpedido"] = row["ID"].ToString();
                numero = row["ID"].ToString();

            }
            else
            {
                numero = "nada";
            }
            return numero;
        }
    }
}