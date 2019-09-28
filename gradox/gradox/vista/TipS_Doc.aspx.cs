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
    public partial class TipS_Doc : System.Web.UI.Page
    {
        Ccontrola sb = new Ccontrola();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                mostrarclasificacion();
            }
        }
        public void limpiar()
        {
            txtcodigodocu.Value = "";
            txtNombreDocu.Value = "";
            txtconsecutivo.Value = "";
        }
        public void mostrarclasificacion()
        {
            try
            {
                string bd = Session["BD"].ToString();
                DataTable res = sb.ClistaClasif_doc(bd);
                DataRow[] result = res.Select();
                selecttipodoc.Items.Clear();
                foreach (DataRow row in result)
                {
                    selecttipodoc.Items.Add(row[0].ToString());

                }


                this.selecttipodoc.DataBind();
            }
            catch (Exception E)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion Interna: " + E.Message);
            }
        }
        public void listartiposdoc()
        {
            try
            {

                DataTable res = sb.CBuscaTipodoc(txtbuscador.Value.ToUpper(), Session["BD"].ToString());
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
        protected void BuscaTipodoc(object sender, EventArgs e)
        {
            listartiposdoc();
        }

        protected void GridViewbuscador_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridViewRow gr = GridViewbuscador.SelectedRow;
            txtcodigodocu.Disabled = true;
            txtcodigodocu.Value = gr.Cells[1].Text;
            txtNombreDocu.Value = Page.Server.HtmlDecode(gr.Cells[2].Text);

            txtconsecutivo.Value = gr.Cells[3].Text;
            selecttipodoc.Value = Page.Server.HtmlDecode(gr.Cells[4].Text);

        }
        protected void creatipodoc(object sender, EventArgs e)
        {
            try
            {

                DataTable res = sb.Ccreatipodoc(txtcodigodocu.Value.ToUpper(),
                    txtNombreDocu.Value.ToUpper(), txtconsecutivo.Value, Session["NOMBRE"].ToString(), selecttipodoc.Value, Session["BD"].ToString());
                if (res.Rows.Count > 0)
                {
                    listartiposdoc();
                    EXPCONTROLADA.MessageBox(this, "Registro Guardado");
                    limpiar();
                }

            }
            catch (Exception)
            {
                EXPCONTROLADA.MessageBox(this, "Algo salio mal en los datos suministrados");
                limpiar();
            }
        }
        protected void updatetipodoc(object sender, EventArgs e)
        {
            try
            {
                DataTable res = sb.CUpdatetipodoc(txtcodigodocu.Value.ToUpper(),
                    txtNombreDocu.Value.ToUpper(), txtconsecutivo.Value, Session["NOMBRE"].ToString(), selecttipodoc.Value, Session["BD"].ToString()); ;
                if (res.Rows.Count > 0)
                {
                    listartiposdoc();
                    EXPCONTROLADA.MessageBox(this, "Registro Actualizado");
                    limpiar();
                }

            }
            catch (Exception)
            {
                EXPCONTROLADA.MessageBox(this, "Algo salio mal en los datos suministrados");
            }
        }

        protected void btnelimina_Click(object sender, EventArgs e)
        {
            if (txtcodigodocu.Value.Equals(""))
            {
                EXPCONTROLADA.MessageBox(this, "Seleccione un Registro de la Tabla");
            }
            else
            {
                try
                {

                    DataTable res = sb.CDELtipodoc(txtcodigodocu.Value.ToUpper(), Session["BD"].ToString());
                    if (res.Rows.Count > 0)
                    {
                        listartiposdoc();
                        EXPCONTROLADA.MessageBox(this, "Registro Borrado");
                        limpiar();
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