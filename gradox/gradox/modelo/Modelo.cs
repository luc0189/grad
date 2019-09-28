using gradox.conexion;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace gradox.modelo
{
    public class Modelo
    {
        Bdconexion con = new Bdconexion();
        Bdconexion dataload = new Bdconexion();
        String sql = String.Empty;
        internal DataTable Mconsusuario(String usua, String PS, String bd)
        {
            try
            {
                List<parametro> Runnombre1 = new List<parametro>();
                Runnombre1.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                Runnombre1.Add(new parametro("P_PS", PS, "VARCHAR2", ParameterDirection.Input));
                Runnombre1.Add(new parametro("P_USUARIO", usua, "VARCHAR2", ParameterDirection.Input));
                return con.ProcedureSelectDB("SISPE.FN_CONL", Runnombre1, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MconsusuarioRoltiempo(String usua, String PS, String bd)
        {
            try
            {
                List<parametro> Runnombre1 = new List<parametro>();
                Runnombre1.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                Runnombre1.Add(new parametro("P_PS", PS, "VARCHAR2", ParameterDirection.Input));
                Runnombre1.Add(new parametro("P_USUARIO", usua, "VARCHAR2", ParameterDirection.Input));
                return con.ProcedureSelectDB("SISPE.FN_ROLTIEMPO", Runnombre1, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable Mlistacategorias(String bd)
        {
            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                return con.ProcedureSelectDB(bd + ".FN_CONCT", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MlistaProductos2(String bd)
        {
            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                return con.ProcedureSelectDB(bd + ".FN_PRODUCTOS", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MlistaUnidadmedida(String bd)
        {
            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                return con.ProcedureSelectDB(bd + ".FN_UNIDADMEDIDA", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MlistaNoUser(String bd)
        {
            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                return con.ProcedureSelectDB(bd + ".FN_CONS_NO_USER", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MlistaMarca(String bd)
        {
            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                return con.ProcedureSelectDB(bd + ".FN_MARCA", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MlistaImpuesto(String bd)
        {
            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                return con.ProcedureSelectDB(bd + ".FN_INPUESTOS", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MlistaRol(String bd)
        {
            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                return con.ProcedureSelectDB(bd + ".FN_ROLES", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable Mlistamesas(String bd)
        {
            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                return con.ProcedureSelectDB(bd + ".FN_CONSULTAMESA", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MlistaPEDIDOMESA(String mesa, String bd)
        {
            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                RunLista.Add(new parametro("V_IDMESA", mesa, "VARCHAR", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".FN_CONSUL_PED_MESA", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MlistaEmpresa(String bd)
        {
            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                return con.ProcedureSelectDB(bd + ".FN_CONEMPRESA", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MlistaPersona(String bd)
        {
            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                return con.ProcedureSelectDB(bd + ".FN_CONSULTA_PERSONA", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MlistaProductos(String bd)
        {
            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                return con.ProcedureSelectDB(bd + ".FN_PRODUCTOS", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MlistaclasificacionDoc(String bd)
        {
            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                return con.ProcedureSelectDB(bd + ".FN_CON_CLASIFICADOC", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MbuscaRol(String rol, String bd)
        {

            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                RunLista.Add(new parametro("V_NOMBRE", rol, "VARCHAR", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".FN_CONSUL_LIKE_ROL", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MbuscaMesalibre(String idmesa, String bd)
        {

            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                RunLista.Add(new parametro("V_IDMESA", idmesa, "VARCHAR", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".FN_CONSULTAMESA_LIKE", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable Mbuscadorarticulo(String articulo, String bd)
        {

            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                RunLista.Add(new parametro("V_NOMBRE", articulo, "VARCHAR", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".FN_CONSUL_LIKE_PRODUC", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable Mbsuma_pedido(String id, String bd)
        {

            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                RunLista.Add(new parametro("V_IDPEDIDO", id, "VARCHAR", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".FN_CON_SUMDETA_PEDIDO", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MBorraitem_det_pedido(String id, String idpedido, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_Id", id, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Id_Pedido", idpedido, "NUMBER", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".PR_BORRA_DETA_PEDIDO", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MListamenus(String categoria, String bd)
        {

            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                RunLista.Add(new parametro("V_NOMBRE", categoria, "VARCHAR", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".FN_CONSUL_MENUPRODUCTOS", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MListaDetallespedido(String pedido, String bd)
        {

            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                RunLista.Add(new parametro("V_IDPEDIDO", pedido, "VARCHAR", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".FN_CON_DETPEDIDO", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MListaIDpedidomesa(String pedido, String bd)
        {

            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                RunLista.Add(new parametro("V_IDMESA", pedido, "NUMBER", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".FN_CON_IDPEDIDO_MESA", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MbuscadorTipodoc(String tipodoc, String bd)
        {

            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                RunLista.Add(new parametro("V_NOMBRE", tipodoc, "VARCHAR", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".FN_CONSUL_LIKE_TIPODOC", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MbuscadorPresentacionParametro(String articulo, String bd)
        {

            try
            {
                List<parametro> RunLista = new List<parametro>();
                RunLista.Add(new parametro("CONSULTA", "", "CURSOR", ParameterDirection.ReturnValue));
                RunLista.Add(new parametro("V_Producto_Id", articulo, "VARCHAR", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".FN_CON_PRESENT_PARAMT", RunLista, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable McreaImpuesto(String nombre, String valor, String estado, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_Nombre", nombre, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Valor", valor, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Estado", estado, "NUMBER", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".PRCREA_IMPUESTO", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable McreaTipoDoc(String codigo, String nombre, String consecut, String creadopor, String clasificacion, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_CODIGO", codigo, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_NOMBRE", nombre, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_CONSECUTIVO", consecut, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_CREADOPOR", creadopor, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_CLASIFICACION", clasificacion, "VARCHAR2", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".PRCREA_TIPODOC", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MDELTipoDoc(String ID, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_ID", ID, "VARCHAR2", ParameterDirection.Input));

                return con.ProcedureSelectDB(bd + ".PRBORRA_TIPODOC", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MCancelapedido(String IDpedido, String idmesa, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_Id_Pedido", IDpedido, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_IDMESA", idmesa, "NUMBER", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".PR_CANCELA_ORDEN", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        internal DataTable Mcreapedidoproducto(String pedidoid, String presentacion,
            String cant, String precio, String descripcion, String impuesto, String valorimp, String pmesa, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_Id_Pedido", pedidoid, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Presentacion_id", presentacion, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_CANT", cant, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_PRECIO", precio, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_DESCRIPCION", descripcion, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_PEDIDO_IMPUESTO", impuesto, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_PEDIDO_VALORIMPUESTO", valorimp, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_MESA", pmesa, "NUMBER", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".PR_CREA_DETALLESPEDIDO", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MActualizaTipoDoc(String codigo, String nombre, String consecut, String creadopor, String clasificacion, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_CODIGO", codigo, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_NOMBRE", nombre, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_CONSECUTIVO", consecut, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_CREADOPOR", creadopor, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_CLASIFICACION", clasificacion, "VARCHAR", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".PRUPDATE_TIPODOC", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable McreaMesa(String nombre, String puestos, String estado, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_Descripcion", nombre, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Puestos", puestos, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Estado", estado, "NUMBER", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".PRMESA_INSERTAR", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable McreaRol(String nombre, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_NOMBRE", nombre, "VARCHAR2", ParameterDirection.Input));

                return con.ProcedureSelectDB(bd + ".PRCREA_ROL", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable McreaCategoria(String nombre, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_NOMBRE", nombre, "VARCHAR2", ParameterDirection.Input));

                return con.ProcedureSelectDB(bd + ".PRCAT", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable Mcreapedido(String Id_Mesa, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_Id_Mesa", Id_Mesa, "NUMBER", ParameterDirection.Input));


                return con.ProcedureSelectDB(bd + ".PR_CREA_PEDIDO_OCUPAMESA", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MupdRol(String ID, String nombre, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_ID", ID, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Nombre", nombre, "VARCHAR2", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".PRUPDATE_ROL", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MupdMesa(String ID, String nombre, String puestos, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_ID", ID, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Nombre", nombre, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Puestos", puestos, "NUMBER", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".PRUPDATE_MESA", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MDELRol(String ID, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_ID", ID, "VARCHAR2", ParameterDirection.Input));

                return con.ProcedureSelectDB(bd + ".PRBORRA_ROL", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable Mcreaentidad(String nit, String nombre, String regimen, String dir,
            String tel, String email, String eslogan, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_Nit", nit, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Nombre", nombre, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Regimen", regimen, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Direccion", dir, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Telefono", tel, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Email", email, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Eslogan", eslogan, "VARCHAR", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".PR_CREA_EMPRESA", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MUpdentidad(String ID, String nit, String nombre, String regimen, String dir,
            String tel, String email, String eslogan, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_ID", ID, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Nit", nit, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Nombre", nombre, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Regimen", regimen, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Direccion", dir, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Telefono", tel, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Email", email, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Eslogan", eslogan, "VARCHAR", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".PRUPDATE_EMPRESA", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable McreaPersona(String nit, String nombre, String apellidos, String dir,
           String tel, String fnacimiento, String email, String tipodoc, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_Numerodoc", nit, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Nombres", nombre, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Apellidos", apellidos, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Direccion", dir, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Telefono", tel, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_FechaNacimiento", fnacimiento, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Email", email, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_TipoDoc", tipodoc, "VARCHAR", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".PR_CREA_PERSONA", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MUPDPersona(String ID, String nit, String nombre, String apellidos, String dir,
           String tel, String fnacimiento, String email, String tipodoc, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_ID", ID, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_NUMERODOC", nit, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_NOMBRES", nombre, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_APELLIDOS", apellidos, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Direccion", dir, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Telefono", tel, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_FNACIMIENTO", fnacimiento, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Email", email, "VARCHAR", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_TIPODOC", tipodoc, "VARCHAR", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".PRUPDATE_PERSONA", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable MDELpersona(String ID, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_ID", ID, "VARCHAR2", ParameterDirection.Input));

                return con.ProcedureSelectDB(bd + ".PRBORRA_PERSONA", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable McreaProducto(String nombre, String Categ, String impuesto, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_Nombre", nombre, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Categoria", Categ, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Impuesto", impuesto, "VARCHAR2", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".PRCPRODUCTO", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        internal DataTable McreaPresentacionProducto(String pnombre, String pdescrip, String pUbicacion,
            String pprecio, String pcantidad, String pestado, String pcomplejidad, String pproductoid,
             String punidadmedida, String pmarca, String bd)
        {
            try
            {
                List<parametro> Runnombre = new List<parametro>();
                Runnombre.Add(new parametro("VALIDAREGISTRO", "", "CURSOR", ParameterDirection.Output));
                Runnombre.Add(new parametro("V_Nombre", pnombre, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Descripcion", pdescrip, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Ubicacion", pUbicacion, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Precio", pprecio, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Cantidad", pcantidad, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Estado", pestado, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Complejidad", pcomplejidad, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Producto_Id", pproductoid, "NUMBER", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_UnidadMedida_Id", punidadmedida, "VARCHAR2", ParameterDirection.Input));
                Runnombre.Add(new parametro("V_Marca_Id", pmarca, "VARCHAR2", ParameterDirection.Input));
                return con.ProcedureSelectDB(bd + ".PRPRESENTACION_INSERTAR", Runnombre, bd);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}