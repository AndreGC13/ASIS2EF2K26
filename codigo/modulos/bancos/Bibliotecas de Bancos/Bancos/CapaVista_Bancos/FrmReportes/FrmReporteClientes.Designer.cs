/*
 * ================================================================
 * Área   : Bancos
 * Autor  : André De Jesús Gonzalez Camey
 * Carné  : 9959-23-3117
 * Fecha  : 24/11/2026
 * ================================================================
 * Propósito :
 *  Define el visor del reporte de clientes y las propiedades
 *  de la ventana que lo contiene.
 * ================================================================
 */
namespace CapaVista_Bancos.FrmReportes
{
    partial class FrmReporteClientes
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmReporteClientes));
            this.BancosRvReporte = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // BancosRvReporte
            // 
            this.BancosRvReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BancosRvReporte.Location = new System.Drawing.Point(0, 0);
            this.BancosRvReporte.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BancosRvReporte.Name = "BancosRvReporte";
            this.BancosRvReporte.ServerReport.BearerToken = null;
            this.BancosRvReporte.Size = new System.Drawing.Size(1100, 640);
            this.BancosRvReporte.TabIndex = 0;
            // 
            // FrmReporteClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 640);
            this.Controls.Add(this.BancosRvReporte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "FrmReporteClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "8014 – Reporte de Clientes";
            this.Load += new System.EventHandler(this.FrmReporteClientes_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer BancosRvReporte;
    }
}
