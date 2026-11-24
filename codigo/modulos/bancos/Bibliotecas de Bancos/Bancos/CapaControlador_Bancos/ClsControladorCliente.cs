/*
 * ================================================================
 * Área   : Bancos
 * Autor  : André De Jesús Gonzalez Camey
 * Carné  : 9959-23-3117
 * Fecha  : 24/11/2026
 * ================================================================
 * Propósito :
 *  Controlador del mantenimiento de Clientes. Recibe las solicitudes
 *  de la vista y las delega al repositorio del Modelo.
 * ================================================================
 */

using System.Data;
using CapaModelo_Bancos.Repositorio;

namespace CapaControlador_Bancos
{
    public sealed class ClsControladorCliente
    {
        private readonly ClsRepositorioCliente _Repositorio = new ClsRepositorioCliente();

        public DataTable BancosMetConsultarClientes()
        {
            return _Repositorio.BancosMetConsultarClientes();
        }
    }
}
