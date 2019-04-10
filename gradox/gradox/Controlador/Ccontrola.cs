using gradox.modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace gradox.Controlador
{
    public class Ccontrola
    {
        Modelo sb = new Modelo();
        internal DataTable Cconsusuario(string usua, string PS, string bd)
        {
            try
            {
                return sb.Mconsusuario(usua, PS, bd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable CconsusuarioRoltiempo(string usua, string PS, string bd)
        {
            try
            {
                return sb.MconsusuarioRoltiempo(usua, PS, bd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable Clistacategorias(string pbd)
        {
            try
            {
                return sb.Mlistacategorias(pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable Clistaproductos(string pbd)//para modificar
        {
            try
            {
                return sb.MlistaProductos2(pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable ClistaUnidadmedida(string pbd)
        {
            try
            {
                return sb.MlistaUnidadmedida(pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable ClistaMarca(string pbd)
        {
            try
            {
                return sb.MlistaMarca(pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable ClistaImpuesto(string pbd)
        {
            try
            {
                return sb.MlistaImpuesto(pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable CListaaRol(string pbd)
        {

            try
            {
                return sb.MlistaRol(pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable CBuscaRol(string pRol, string pbd)
        {
            string rol = "%" + pRol + "%";
            try
            {
                return sb.MbuscaRol(rol, pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable ClistaMesa(string pbd)
        {
            try
            {
                return sb.Mlistamesas(pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable ClistaEmpresa(string pbd)
        {
            try
            {
                return sb.MlistaEmpresa(pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable ClistaPersona(string pbd)
        {
            try
            {
                return sb.MlistaPersona(pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable ClistaProductos(string pbd)
        {
            try
            {
                return sb.MlistaProductos(pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable ClistaClasif_doc(string pbd)
        {
            try
            {
                return sb.MlistaclasificacionDoc(pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable CBuscaArticulo(string particulo, string pbd)
        {
            string articulo = "%" + particulo + "%";
            try
            {
                return sb.Mbuscadorarticulo(articulo, pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable CSumadetalle_pedido(string pid, string pbd)
        {

            try
            {
                return sb.Mbsuma_pedido(pid, pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable CBorra_item_dp(string pid, string pidpedido, string pbd)
        {

            try
            {
                return sb.MBorraitem_det_pedido(pid, pidpedido, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable CBuscaTipodoc(string ptipodoc, string pbd)
        {
            string tipodoc = "%" + ptipodoc + "%";
            try
            {
                return sb.MbuscadorTipodoc(tipodoc, pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable CBuscaMesalibre(string pidmesa, string pbd)
        {
            //string tipodoc = "%" + ptipodoc + "%";
            try
            {
                return sb.MbuscaMesalibre(pidmesa, pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable Cpedirmesa(string pidmesa, string pbd)
        {

            try
            {
                return sb.MlistaPEDIDOMESA(pidmesa, pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable Cpedido(string pidmesa, string pbd)
        {

            try
            {
                return sb.Mcreapedido(pidmesa, pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable CBuscaPresentacionParametro(string particulo, string pbd)
        {

            try
            {
                return sb.MbuscadorPresentacionParametro(particulo, pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable CListamenus(string pcategoria, string pbd)
        {

            try
            {
                return sb.MListamenus(pcategoria, pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }

        internal DataTable CListaIdpedio(string pidMESA, string pbd)
        {

            try
            {
                return sb.MListaIDpedidomesa(pidMESA, pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable CListaDetallespedido(string pidpedido, string pbd)
        {

            try
            {
                return sb.MListaDetallespedido(pidpedido, pbd);
            }
            catch (Exception e)

            {
                throw e;
            }
        }
        internal DataTable CcreaImpuesto(string pnombre, string pvalor, string pestado, string pbd)
        {

            try
            {
                return sb.McreaImpuesto(pnombre, pvalor, pestado, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable CupdRol(string pid, string pnombre, string pbd)
        {

            try
            {
                return sb.MupdRol(pid, pnombre, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable CupdMesa(string pid, string pnombre, string ppuestos, string pbd)
        {

            try
            {
                return sb.MupdMesa(pid, pnombre, ppuestos, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable CDELRol(string pid, string pbd)
        {

            try
            {
                return sb.MDELRol(pid, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable CcreaRol(string pnombre, string pbd)
        {

            try
            {
                return sb.McreaRol(pnombre, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable CcreaCatego(string pnombre, string pbd)
        {

            try
            {
                return sb.McreaCategoria(pnombre, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable CcreaMesa(string pnombre, string ppuestos, string pestado, string pbd)
        {

            try
            {
                return sb.McreaMesa(pnombre, ppuestos, pestado, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable Ccreatipodoc(string pcodigo, string pnombre, string pconsecutivo, string pcreadopor, string pclasificacion, string pbd)
        {

            try
            {
                return sb.McreaTipoDoc(pcodigo, pnombre, pconsecutivo, pcreadopor, pclasificacion, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable Ccreapedidproducto(string ppedido, string presentacion, string pcantidad, string pprecio,
            string pdescripcion, string pimpuesto, string pvalorimp, string Mesa, string pbd)
        {

            try
            {
                return sb.Mcreapedidoproducto(ppedido, presentacion, pcantidad, pprecio
                    , pdescripcion, pimpuesto, pvalorimp, Mesa, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable CUpdatetipodoc(string pcodigo, string pnombre, string pconsecutivo, string pcreadopor, string pclasificacion, string pbd)
        {

            try
            {
                return sb.MActualizaTipoDoc(pcodigo, pnombre, pconsecutivo, pcreadopor, pclasificacion, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable CDELtipodoc(string pid, string pbd)
        {

            try
            {
                return sb.MDELTipoDoc(pid, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable cCancelaOrden(string pidpedido, string pidmesa, string pbd)
        {
            try
            {
                return sb.MCancelapedido(pidpedido, pidmesa, pbd);
            }
            catch (Exception e)
            {

                throw e;
            }
        }
        internal DataTable Ccreaentidad(string pnit, string pnombre, string pregimen, string Pdir,
            string ptel, string pemail, string peslogan, string pbd)
        {

            try
            {
                return sb.Mcreaentidad(pnit, pnombre, pregimen, Pdir, ptel, pemail, peslogan, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable CUdpentidad(string pid, string pnit, string pnombre, string pregimen, string Pdir,
           string ptel, string pemail, string peslogan, string pbd)
        {

            try
            {
                return sb.MUpdentidad(pid, pnit, pnombre, pregimen, Pdir, ptel, pemail, peslogan, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable CcreaPersona(string pnit, string pnombre, string papellidos, string Pdir,
           string ptel, string pfnacimiento, string pemail, string ptipodoc, string pbd)
        {

            try
            {
                return sb.McreaPersona(pnit, pnombre, papellidos, Pdir, ptel, pfnacimiento, pemail, ptipodoc, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable CUpdPersona(string pid, string pnit, string pnombre, string papellidos, string Pdir,
          string ptel, string pfnacimiento, string pemail, string ptipodoc, string pbd)
        {

            try
            {
                return sb.MUPDPersona(pid, pnit, pnombre, papellidos, Pdir, ptel, pfnacimiento, pemail, ptipodoc, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable CDELpersona(string pid, string pbd)
        {

            try
            {
                return sb.MDELpersona(pid, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable CcreaProduct(string pnombre, string pCateg, string pimpuesto, string pbd)
        {
            try
            {
                return sb.McreaProducto(pnombre, pCateg, pimpuesto, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        internal DataTable CcreaPresentProduct(string pnombre, string descrip, string pUbicacion,
            string precio, string estado, string complejidad, string idproducto,
            string unidadMedida, string Marca, string pbd)
        {
            try
            {
                return sb.McreaPresentacionProducto(pnombre, descrip, pUbicacion, precio
                    , estado, complejidad, idproducto, unidadMedida, Marca, pbd);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}