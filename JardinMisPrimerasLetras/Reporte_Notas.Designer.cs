namespace JardinMisPrimerasLetras
{
    partial class Reporte_Notas
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
            this.NotasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NotasTableAdapter = new JardinMisPrimerasLetras.DataSetReporteTableAdapters.NotasTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Notas";
            reportDataSource1.Value = this.NotasBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JardinMisPrimerasLetras.Report3.rdlc";
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
            // NotasBindingSource
            // 
            this.NotasBindingSource.DataMember = "Notas";
            this.NotasBindingSource.DataSource = this.DataSetReporte;
            // 
            // NotasTableAdapter
            // 
            this.NotasTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Notas";
            this.Text = "Reporte_Notas";
            this.Load += new System.EventHandler(this.Reporte_Notas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NotasBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NotasBindingSource;
        private DataSetReporte DataSetReporte;
        private DataSetReporteTableAdapters.NotasTableAdapter NotasTableAdapter;
    }
}