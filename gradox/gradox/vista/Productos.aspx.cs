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
    public partial class Productos : System.Web.UI.Page
    {
        Ccontrola sb = new Ccontrola();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                mostrarcategorias();
                mostrarUnidadMedida();
                mostrarMarca();
                mostrarimpuesto();
            }
        }
        public void mostrarcategorias()
        {
            try
            {
                string bd = Session["BD"].ToString();
                DataTable res = sb.Clistacategorias(bd);
                DataRow[] result = res.Select();
                selectCategoria.Items.Clear();
                foreach (DataRow row in result)
                {
                    selectCategoria.Items.Add(row[0].ToString());

                }


                this.selectCategoria.DataBind();
            }
            catch (Exception E)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion Interna: " + E.Message);
            }
        }
        public void mostrarUnidadMedida()
        {
            try
            {
                string bd = Session["BD"].ToString();
                DataTable res = sb.ClistaUnidadmedida(bd);
                DataRow[] result = res.Select();
                selectUnidadM.Items.Clear();
                foreach (DataRow row in result)
                {
                    selectUnidadM.Items.Add(row[0].ToString());

                }


                this.selectUnidadM.DataBind();
            }
            catch (Exception E)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion Interna: " + E.Message);
            }
        }
        public void mostrarMarca()
        {
            try
            {
                string bd = Session["BD"].ToString();
                DataTable res = sb.ClistaMarca(bd);
                DataRow[] result = res.Select();
                selectMarca.Items.Clear();
                foreach (DataRow row in result)
                {
                    selectMarca.Items.Add(row[0].ToString());

                }


                this.selectMarca.DataBind();
            }
            catch (Exception E)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion Interna: " + E.Message);
            }
        }
        public void mostrarimpuesto()
        {
            try
            {
                string bd = Session["BD"].ToString();
                DataTable res = sb.ClistaImpuesto(bd);
                DataRow[] result = res.Select();
                selectImpuesto.Items.Clear();
                foreach (DataRow row in result)
                {
                    selectImpuesto.Items.Add(row[0].ToString());

                }


                this.selectImpuesto.DataBind();
            }
            catch (Exception E)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion Interna: " + E.Message);
            }
        }
        protected void listaproductos(object sender, EventArgs e)
        {
            try
            {

                DataTable res = sb.ClistaProductos(Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridViewexportar.DataSource = res;
                    GridViewexportar.DataBind();


                }
                else
                {

                    GridViewexportar.DataSource = null;
                    GridViewexportar.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        protected void creaProducto(object sender, EventArgs e)
        {
            try
            {

                DataTable res = sb.CcreaProduct(txtnombreproducto.Value.ToUpper(), selectCategoria.Value, selectImpuesto.Value, Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    DataRow[] result = res.Select();

                    foreach (DataRow row in result)
                    {
                        TxtIdproducto.InnerText = row[0].ToString();

                    }

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
        protected void Buscaproducto(object sender, EventArgs e)
        {
            try
            {

                DataTable res = sb.CBuscaArticulo(txtbuscador.Value.ToUpper(), Session["BD"].ToString());
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
        protected void BuscaPresentacion(object sender, EventArgs e)
        {
            buscapresentacionparametro();
        }
        protected void creaPresentacionProducto(object sender, EventArgs e)
        {
            try
            {

                DataTable res = sb.CcreaPresentProduct(txtnombreP.Value.ToUpper(), txtdescripcionp.Value.ToUpper()
                    , txtubicacion.Value.ToUpper(), txtprecio.Value, txtcant.Value, Selectestado.Value,
                    selectcomplejidad.Value, TxtIdproducto.InnerText, selectUnidadM.Value, selectMarca.Value, Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridViewPresentaciones.DataSource = res;
                    GridViewPresentaciones.DataBind();

                    EXPCONTROLADA.MessageBox(this, "Registro de Presentacion Guardado");
                }
                else
                {
                    EXPCONTROLADA.MessageBox(this, "Algo salio mal en los datos suministrados");
                    GridViewPresentaciones.DataSource = null;
                    GridViewPresentaciones.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        public void buscapresentacionparametro()
        {
            try
            {
                DataTable res = sb.CBuscaPresentacionParametro(TxtIdproducto.InnerText, Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    GridViewPresentaciones.DataSource = res;
                    GridViewPresentaciones.DataBind();

                }
                else
                {
                    GridViewPresentaciones.DataSource = null;
                    GridViewPresentaciones.DataBind();
                }

            }
            catch (Exception exp)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion interna: " + exp.Message);
            }
        }
        protected void GridViewbuscador_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = GridViewbuscador.SelectedRow;
            TxtIdproducto.InnerText = gr.Cells[1].Text;
            txtnombreproducto.Value = Page.Server.HtmlDecode(gr.Cells[2].Text);

            selectCategoria.Value = Page.Server.HtmlDecode(gr.Cells[3].Text);
            selectImpuesto.Value = Page.Server.HtmlDecode(gr.Cells[4].Text);
            buscapresentacionparametro();
        }
    }
}