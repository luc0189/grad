using gradox.Controlador;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace gradox
{
    public partial class Login : System.Web.UI.Page
    {
        Ccontrola sb = new Ccontrola();
        string valor1 = "";
        string valor2 = "";
        string valor3 = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {

                if (Session["NOUSER"] != null)
                {
                    txtAlerta.InnerText = Session["NOUSER"].ToString();
                }

            }

        }
        public string getsha(string text)

        {
            SHA1CryptoServiceProvider sp = new SHA1CryptoServiceProvider();
            sp.ComputeHash(ASCIIEncoding.ASCII.GetBytes(text));
            byte[] re = sp.Hash;
            StringBuilder sb = new StringBuilder();
            foreach (byte b in re)
            {
                sb.Append(b.ToString("X2"));
            }

            return sb.ToString();
        }

        protected void Entrar_Click(object sender, EventArgs e)
        {

            try
            {
                string contra = getsha(txtcontraseña.Value);
                try
                {
                    var valida = sb.Cconsusuario(txtususario.Value.ToUpper(), contra, selectbd.Value);
                    if (valida.Rows.Count > 0)
                    {
                        foreach (DataRow row in valida.Rows)
                        {
                            Session.Remove("NOUSER");
                            txtAlerta.InnerText = "";
                            valor1 = Convert.ToString(row[0]);
                            valor2 = Convert.ToString(row[1]);
                            valor3 = Convert.ToString(row[2]);
                            Session["NOMBRE"] = valor1;
                            Session["CC"] = valor2;
                            Session["ROL"] = valor3;
                            Session["BD"] = selectbd.Value;
                            if (valor3.Equals("ADMINISTRADOR"))
                            {
                                Response.Redirect("vista/Menuadmon.aspx");
                            }
                            if (valor3.Equals("USUARIO"))
                            {
                                Response.Redirect("vista/Menuadmon.aspx");
                            }
                            if (valor3.Equals("MESERO"))
                            {
                                Response.Redirect("vista/Atencion_mesas.aspx");
                            }
                            if (valor3.Equals("COCINA"))
                            {
                                Response.Redirect("vista/Cocina.aspx");
                            }


                        }

                    }
                    //else
                    //{
                    //    txtcontraseña.Value = "";
                    //    txtususario.Value = "";
                    //    string script = @"<script type='text/javascript'>
                    //        alert('Error en usuario o contraseña');

                    //    </script>";

                    //    ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
                    //}
                }
                finally
                {
                    var valida = sb.CconsusuarioRoltiempo(txtususario.Value.ToUpper(), contra, selectbd.Value);
                    if (valida.Rows.Count > 0)
                    {
                        EXPCONTROLADA.MessageBox(this, "USUARIO EN HORARIO NO HABILITADO ");
                    }
                }



            }
            catch (Exception ex)
            {
                EXPCONTROLADA.MessageBox(this, "Excepcion Interna: " + ex.Message);

            }







        }



    }
}