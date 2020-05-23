namespace JardinMisPrimerasLetras
{
    partial class ReportePagos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.DataSetReporte = new JardinMisPrimerasLetras.DataSetReporte();
            this.PagosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PagosTableAdapter = new JardinMisPrimerasLetras.DataSetReporteTableAdapters.PagosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Pagos";
            reportDataSource1.Value = this.PagosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JardinMisPrimerasLetras.Report4.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // DataSetReporte
            // 
            this.DataSetReporte.DataSetName = "DataSetReporte";
            this.DataSetReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PagosBindingSource
            // 
            this.PagosBindingSource.DataMember = "Pagos";
            this.PagosBindingSource.DataSource = this.DataSetReporte;
            // 
            // PagosTableAdapter
            // 
            this.PagosTableAdapter.ClearBeforeFill = true;
            // 
            // ReportePagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReportePagos";
            this.Text = "ReportePagos";
            this.Load += new System.EventHandler(this.ReportePagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PagosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource PagosBindingSource;
        private DataSetReporte DataSetReporte;
        private DataSetReporteTableAdapters.PagosTableAdapter PagosTableAdapter;
    }
}