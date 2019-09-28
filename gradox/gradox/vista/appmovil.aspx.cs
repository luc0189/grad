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
    public partial class appmovil : System.Web.UI.Page
    {
        Ccontrola sb = new Ccontrola();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                listaentradas();
                listares();
                listaCerdo();
                listapastas();
                listacremas();
                listapescados();
                listamariscos();
                listaPostres();
                listaPollos();
                listabebidas();
                listaDetallespedido();
                suma_valores_dp();
            }
        }
        public void listaentradas()
        {
            try
            {

                DataTable res = sb.CListamenus("ENTRADAS", Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridViewentradas.DataSource = res;
                    GridViewentradas.DataBind();


                }
                else
                {

                    GridViewentradas.DataSource = null;
                    GridViewentradas.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        public void listares()
        {
            try
            {

                DataTable res = sb.CListamenus("RES", Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridViewRes.DataSource = res;
                    GridViewRes.DataBind();


                }
                else
                {

                    GridViewRes.DataSource = null;
                    GridViewRes.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        public void listaCerdo()
        {
            try
            {

                DataTable res = sb.CListamenus("CERDO", Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridViewCerdo.DataSource = res;
                    GridViewCerdo.DataBind();


                }
                else
                {

                    GridViewCerdo.DataSource = null;
                    GridViewCerdo.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        public void listapastas()
        {
            try
            {

                DataTable res = sb.CListamenus("PASTAS", Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridViewPastas.DataSource = res;
                    GridViewPastas.DataBind();


                }
                else
                {

                    GridViewPastas.DataSource = null;
                    GridViewPastas.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        public void listacremas()
        {
            try
            {

                DataTable res = sb.CListamenus("CREMAS", Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridViewCremas.DataSource = res;
                    GridViewCremas.DataBind();


                }
                else
                {

                    GridViewCremas.DataSource = null;
                    GridViewCremas.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        public void listapescados()
        {
            try
            {

                DataTable res = sb.CListamenus("PESCADOS", Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridViewPescados.DataSource = res;
                    GridViewPescados.DataBind();
                }
                else
                {
                    GridViewPescados.DataSource = null;
                    GridViewPescados.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        public void listamariscos()
        {
            try
            {

                DataTable res = sb.CListamenus("MARISCOS", Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridViewMariscos.DataSource = res;
                    GridViewMariscos.DataBind();


                }
                else
                {

                    GridViewMariscos.DataSource = null;
                    GridViewMariscos.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        public void listaPostres()
        {
            try
            {

                DataTable res = sb.CListamenus("POSTRES Y ENSALADAS", Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridViewPostres.DataSource = res;
                    GridViewPostres.DataBind();


                }
                else
                {

                    GridViewPostres.DataSource = null;
                    GridViewPostres.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        public void listaPollos()
        {
            try
            {

                DataTable res = sb.CListamenus("POLLO", Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridViewPollo.DataSource = res;
                    GridViewPollo.DataBind();


                }
                else
                {

                    GridViewPollo.DataSource = null;
                    GridViewPollo.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        public void listabebidas()
        {
            try
            {

                DataTable res = sb.CListamenus("BEBIDAS", Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridViewBebidas.DataSource = res;
                    GridViewBebidas.DataBind();


                }
                else
                {

                    GridViewBebidas.DataSource = null;
                    GridViewBebidas.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        protected void borraitems(object sender, EventArgs e)
        {
            GridViewRow gro = GridVieworden.SelectedRow;

            string id = gro.Cells[1].Text;
            try
            {
                DataTable res = sb.CBorra_item_dp(id, Session["pid"].ToString(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridVieworden.DataSource = res;
                    GridVieworden.DataBind();
                    suma_valores_dp();
                    EXPCONTROLADA.MessageBox(this, "registro Borrado");
                    Response.Redirect("WebForm1.aspx");
                }
                else
                {
                    GridVieworden.DataSource = null;
                    GridVieworden.DataBind();
                    suma_valores_dp();
                    EXPCONTROLADA.MessageBox(this, "Pedido sin Items");
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        public void suma_valores_dp()
        {
            try
            {

                DataTable res = sb.CSumadetalle_pedido(Session["pid"].ToString(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    DataRow row = res.Rows[0];
                    txtitems.InnerText = row["ITEMS"].ToString();
                    txtsubtotal.Value = row["SUBTOTAL"].ToString();
                    txtiva.Value = row["IMPUESTO"].ToString();
                    txttotal.Value = row["TOTAL"].ToString();


                }
                else
                {

                    GridViewBebidas.DataSource = null;
                    GridViewBebidas.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        public void listaDetallespedido()
        {
            string data = Session["pid"].ToString();
            try
            {

                DataTable res = sb.CListaDetallespedido(data, Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridVieworden.DataSource = res;
                    GridVieworden.DataBind();


                }
                else
                {

                    GridVieworden.DataSource = null;
                    GridVieworden.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        protected void insertacarne(object sender, EventArgs e)
        {
            GridViewRow gr = GridViewRes.SelectedRow;

            string presentacion = gr.Cells[2].Text;
            string descripcion = Page.Server.HtmlDecode(gr.Cells[3].Text);
            string valor = gr.Cells[4].Text;
            string impuesto = gr.Cells[5].Text;
            string vlimpuesto = gr.Cells[6].Text;

            try
            {
                DataTable res = sb.Ccreapedidproducto(Session["pid"].ToString(), presentacion, "1", valor, descripcion,
                    impuesto, vlimpuesto, Session["pid"].ToString(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridVieworden.DataSource = res;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "registrado");
                    Response.Redirect("WebForm1.aspx");
                }
                else
                {
                    GridVieworden.DataSource = null;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "Pedido sin Items");
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
            suma_valores_dp();
        }
        protected void insertacerdo(object sender, EventArgs e)
        {
            GridViewRow gr = GridViewCerdo.SelectedRow;

            string presentacion = gr.Cells[2].Text;
            string descripcion = Page.Server.HtmlDecode(gr.Cells[3].Text);
            string valor = gr.Cells[4].Text;
            string impuesto = gr.Cells[5].Text;
            string vlimpuesto = gr.Cells[6].Text;

            try
            {
                DataTable res = sb.Ccreapedidproducto(Session["pid"].ToString(), presentacion, "1", valor, descripcion,
                    impuesto, vlimpuesto, Session["pid"].ToString(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridVieworden.DataSource = res;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "registrado");
                    Response.Redirect("WebForm1.aspx");
                }
                else
                {
                    GridVieworden.DataSource = null;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "Pedido sin Items");
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
            suma_valores_dp();
        }
        protected void insertapastas(object sender, EventArgs e)
        {
            GridViewRow gr = GridViewPastas.SelectedRow;

            string presentacion = gr.Cells[2].Text;
            string descripcion = Page.Server.HtmlDecode(gr.Cells[3].Text);
            string valor = gr.Cells[4].Text;
            string impuesto = gr.Cells[5].Text;
            string vlimpuesto = gr.Cells[6].Text;

            try
            {
                DataTable res = sb.Ccreapedidproducto(Session["pid"].ToString(), presentacion, "1", valor, descripcion,
                    impuesto, vlimpuesto, Session["pid"].ToString(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridVieworden.DataSource = res;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "registrado");
                    Response.Redirect("WebForm1.aspx");
                }
                else
                {
                    GridVieworden.DataSource = null;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "Pedido sin Items");
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
            suma_valores_dp();
        }
        protected void insertacremas(object sender, EventArgs e)
        {
            GridViewRow gr = GridViewCremas.SelectedRow;

            string presentacion = gr.Cells[2].Text;
            string descripcion = Page.Server.HtmlDecode(gr.Cells[3].Text);
            string valor = gr.Cells[4].Text;
            string impuesto = gr.Cells[5].Text;
            string vlimpuesto = gr.Cells[6].Text;

            try
            {
                DataTable res = sb.Ccreapedidproducto(Session["pid"].ToString(), presentacion, "1", valor, descripcion,
                    impuesto, vlimpuesto, Session["pid"].ToString(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridVieworden.DataSource = res;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "registrado");
                    Response.Redirect("WebForm1.aspx");
                }
                else
                {
                    GridVieworden.DataSource = null;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "Pedido sin Items");
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
            suma_valores_dp();
        }
        protected void insertapescados(object sender, EventArgs e)
        {
            GridViewRow gr = GridViewPescados.SelectedRow;

            string presentacion = gr.Cells[2].Text;
            string descripcion = Page.Server.HtmlDecode(gr.Cells[3].Text);
            string valor = gr.Cells[4].Text;
            string impuesto = gr.Cells[5].Text;
            string vlimpuesto = gr.Cells[6].Text;

            try
            {
                DataTable res = sb.Ccreapedidproducto(Session["pid"].ToString(), presentacion, "1", valor, descripcion,
                    impuesto, vlimpuesto, Session["pid"].ToString(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridVieworden.DataSource = res;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "registrado");
                    Response.Redirect("WebForm1.aspx");
                }
                else
                {
                    GridVieworden.DataSource = null;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "Pedido sin Items");
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
            suma_valores_dp();
        }
        protected void insertamariscos(object sender, EventArgs e)
        {
            GridViewRow gr = GridViewMariscos.SelectedRow;
            string presentacion = gr.Cells[2].Text;
            string descripcion = Page.Server.HtmlDecode(gr.Cells[3].Text);
            string valor = gr.Cells[4].Text;
            string impuesto = gr.Cells[5].Text;
            string vlimpuesto = gr.Cells[6].Text;

            try
            {
                DataTable res = sb.Ccreapedidproducto(Session["pid"].ToString(), presentacion, "1", valor, descripcion,
                    impuesto, vlimpuesto, Session["pid"].ToString(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridVieworden.DataSource = res;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "registrado");
                    Response.Redirect("WebForm1.aspx");
                }
                else
                {
                    GridVieworden.DataSource = null;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "Pedido sin Items");
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
            suma_valores_dp();
        }
        protected void insertapostres(object sender, EventArgs e)
        {
            GridViewRow gr = GridViewPostres.SelectedRow;

            string presentacion = gr.Cells[2].Text;
            string descripcion = Page.Server.HtmlDecode(gr.Cells[3].Text);
            string valor = gr.Cells[4].Text;
            string impuesto = gr.Cells[5].Text;
            string vlimpuesto = gr.Cells[6].Text;

            try
            {
                DataTable res = sb.Ccreapedidproducto(Session["pid"].ToString(), presentacion, "1", valor, descripcion,
                    impuesto, vlimpuesto, Session["pid"].ToString(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridVieworden.DataSource = res;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "registrado");
                    Response.Redirect("WebForm1.aspx");
                }
                else
                {
                    GridVieworden.DataSource = null;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "Pedido sin Items");
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
            suma_valores_dp();
        }
        protected void insertapollo(object sender, EventArgs e)
        {
            GridViewRow gr = GridViewPollo.SelectedRow;

            string presentacion = gr.Cells[2].Text;
            string descripcion = Page.Server.HtmlDecode(gr.Cells[3].Text);
            string valor = gr.Cells[4].Text;
            string impuesto = gr.Cells[5].Text;
            string vlimpuesto = gr.Cells[6].Text;

            try
            {
                DataTable res = sb.Ccreapedidproducto(Session["pid"].ToString(), presentacion, "1", valor, descripcion,
                    impuesto, vlimpuesto, Session["pid"].ToString(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridVieworden.DataSource = res;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "registrado");
                    Response.Redirect("WebForm1.aspx");
                }
                else
                {
                    GridVieworden.DataSource = null;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "Pedido sin Items");
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
            suma_valores_dp();
        }
        protected void insertabebidas(object sender, EventArgs e)
        {
            GridViewRow gr = GridViewBebidas.SelectedRow;

            string presentacion = gr.Cells[2].Text;
            string descripcion = Page.Server.HtmlDecode(gr.Cells[3].Text);
            string valor = gr.Cells[4].Text;
            string impuesto = gr.Cells[5].Text;
            string vlimpuesto = gr.Cells[6].Text;

            try
            {
                DataTable res = sb.Ccreapedidproducto(Session["pid"].ToString(), presentacion, "1", valor, descripcion,
                    impuesto, vlimpuesto, Session["pid"].ToString(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridVieworden.DataSource = res;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "registrado");
                    Response.Redirect("WebForm1.aspx");
                }
                else
                {
                    GridVieworden.DataSource = null;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "Pedido sin Items");
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
            suma_valores_dp();
        }
        protected void insertainfopedido(object sender, EventArgs e)
        {
            GridViewRow gr = GridViewentradas.SelectedRow;

            string presentacion = gr.Cells[2].Text;
            string descripcion = Page.Server.HtmlDecode(gr.Cells[3].Text);
            string valor = gr.Cells[4].Text;
            string impuesto = gr.Cells[5].Text;
            string vlimpuesto = gr.Cells[6].Text;

            try
            {
                DataTable res = sb.Ccreapedidproducto(Session["pid"].ToString(), presentacion, "1", valor, descripcion,
                    impuesto, vlimpuesto, Session["pid"].ToString(), Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridVieworden.DataSource = res;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "registrado");
                    Response.Redirect("WebForm1.aspx");
                }
                else
                {
                    GridVieworden.DataSource = null;
                    GridVieworden.DataBind();
                    EXPCONTROLADA.MessageBox(this, "Pedido sin Items");
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
            suma_valores_dp();
        }
    }
}