/*
 * ================================================================
 * Área   : Bancos
 * Autor  : André De Jesús Gonzalez Camey
 * Carné  : 9959-23-3117
 * Fecha  : 24/11/2026
 * ================================================================
 * Propósito :
 *  Muestra en un visor el reporte con el listado de clientes
 *  registrados en el mantenimiento Clientes.
 * ================================================================
 */
using System;
using System.Data;
using System.Windows.Forms;
using CapaControlador_Bancos;
using Microsoft.Reporting.WinForms;

namespace CapaVista_Bancos.FrmReportes
{
    public partial class FrmReporteClientes : Form
    {
        private readonly ClsControladorCliente _Controlador = new ClsControladorCliente();

        public FrmReporteClientes()
        {
            InitializeComponent();
        }

        private void FrmReporteClientes_Load(object sender, EventArgs e)
        {
            try
            {
                DataTable Clientes = _Controlador.BancosMetConsultarClientes();

                ReportDataSource DatosReporte = new ReportDataSource("DsClientes", Clientes);
                BancosRvReporte.LocalReport.ReportEmbeddedResource = "CapaVista_Bancos.Reporte.RpReporteClientes.rdlc";
                BancosRvReporte.LocalReport.DataSources.Clear();
                BancosRvReporte.LocalReport.DataSources.Add(DatosReporte);
                BancosRvReporte.RefreshReport();
            }
            catch (Exception Error)
            {
                MessageBox.Show(Error.Message, "No fue posible generar el reporte", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}
