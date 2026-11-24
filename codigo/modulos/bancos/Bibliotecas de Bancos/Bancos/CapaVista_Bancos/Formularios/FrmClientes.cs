/*
 * ================================================================
 * Área   : Bancos
 * Autor  : André De Jesús Gonzalez Camey
 * Carné  : 9959-23-3117
 * Fecha  : 24/11/2026
 * ================================================================
 * Propósito :
 *  Mantenimiento de Clientes (aplicación 8014 del módulo Bancos).
 *  Usa el componente Navegador para ingresar, modificar, eliminar,
 *  imprimir y consultar; la consulta del reporte la pide al Controlador.
 * ================================================================
 */

using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using CapaControlador_Bancos;

namespace CapaVista_Bancos.Formularios
{
    public partial class FrmClientes : Form
    {
        private readonly ClsControladorCliente _Controlador = new ClsControladorCliente();
        private readonly DataTable _Clientes = new DataTable("DsClientes");

        public FrmClientes()
        {
            InitializeComponent();

            BancosNavClientes.NavegadorAccionSolicitada += BancosMetPrepararReporte;

            // 8000 = módulo Bancos, 8014 = aplicación Clientes (debe coincidir con Seguridad)
            BancosNavClientes.NavegadorMetConfigurar(
                "tbl_cliente",
                8000,
                8014,
                new Dictionary<string, object>
                {
                    { "DsClientes", _Clientes }
                });
        }

        private void BancosMetPrepararReporte(string Accion)
        {
            if (Accion != "IMPRIMIR")
                return;

            _Clientes.Clear();
            _Clientes.Merge(_Controlador.BancosMetConsultarClientes());
        }

        private void BancosBtnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
