/*
 * ================================================================
 * Área   : Bancos
 * Autor  : André De Jesús Gonzalez Camey
 * Carné  : 9959-23-3117
 * Fecha  : 24/11/2026
 * ================================================================
 * Propósito :
 *  Repositorio del mantenimiento de Clientes. Contiene la consulta
 *  ODBC que alimenta el reporte; el ingreso, la modificación y la
 *  eliminación los ejecuta el componente Navegador.
 * ================================================================
 */

using System.Data;
using System.Data.Odbc;

namespace CapaModelo_Bancos.Repositorio
{
    public sealed class ClsRepositorioCliente : ClsConexion
    {
        public DataTable BancosMetConsultarClientes()
        {
            const string Sentencia = @"
                SELECT pk_idCliente,
                       nombreCliente,
                       direccionCliente,
                       telefonoCliente,
                       estadoCliente
                FROM tbl_cliente
                ORDER BY pk_idCliente";

            using (OdbcConnection Conexion = BancosMetObtenerConexion())
            using (OdbcDataAdapter Adaptador = new OdbcDataAdapter(Sentencia, Conexion))
            {
                DataTable Clientes = new DataTable("DsClientes");
                Adaptador.Fill(Clientes);
                return Clientes;
            }
        }
    }
}
