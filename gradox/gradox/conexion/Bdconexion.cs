using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OracleClient;
using System.Linq;
using System.Web;

namespace gradox.conexion
{
    public class Bdconexion
    {
        public String Conection_DB()
        {
            return ConfigurationManager.ConnectionStrings["BD"].ConnectionString;
        }
        public DataTable ProcedureSelectDB(string procedimiento, List<parametro> parametros, string BD)
        {
            OracleConnection DbConn = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=dedicated)(SERVICE_NAME=XE)));User ID='" + BD + "';Password=Team0103; Unicode=true");

            DataTable datos = new DataTable();

            try
            {
                #region Define Procedimiento
                OracleDataReader cursor;
                DbConn.Open();
                OracleCommand DbCommand = new OracleCommand(procedimiento, DbConn);
                DbCommand.CommandType = System.Data.CommandType.StoredProcedure;
                #endregion Define Procedimiento

                #region Parametros
                foreach (parametro p in parametros)
                {
                    DbCommand.Parameters.Add(new OracleParameter(p.Nombre, p.Tipo));
                    DbCommand.Parameters[p.Nombre].Direction = p.Direccion;
                    if (p.Direccion == ParameterDirection.Input)
                        DbCommand.Parameters[p.Nombre].Value = p.Valor;
                }
                #endregion
                cursor = DbCommand.ExecuteReader();
                datos.Load(cursor);
            }
            catch (Exception ex)
            {
                throw ex;

            }
            finally
            {
                if (DbConn != null)
                    if (DbConn.State == ConnectionState.Open)
                        DbConn.Close();
            }
            return datos;
        }
        public DataSet oraconsulta(String SQL, String BD)
        {
            //NO OLVIDE QUE SI NO FUNCIONA EN OTRO SERVIDOR ES PORQUE LE HACE FALTA EL ODA
            //OracleConnection conexion = new OracleConnection(this.cadenaConexionOra());
            //base de datos remota y tambien copiar al webconfig OJO"
            OracleConnection conexion = new OracleConnection("Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=dedicated)(SERVICE_NAME=XE)));User ID='" + BD + "';Password=Team0103; Unicode=true");
            OracleCommand comando = new OracleCommand(SQL, conexion);
            OracleDataAdapter datos = new OracleDataAdapter(comando);
            DataSet tabla = new DataSet();
            //Excepciones (bloques: try - catch - finally)
            try // Se ejecuta hasta que termine o se genere una excepcion
            {
                conexion.Open();
                datos.Fill(tabla);
            }
            catch (Exception problema) // atrapa la excepcion que hereden de System.Exception
            {
                throw problema;
                //new Exception(problema.Message);
                //return problema;
            }
            finally  // se ejecuta si se produce o no una excepcion 
            {
                conexion.Close();
                comando.Dispose();
            }
            return tabla;
        }
    }
}