namespace JardinMisPrimerasLetras
{
    partial class Reporte_Docente
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
            this.Usu_AsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSetReporte = new JardinMisPrimerasLetras.DataSetReporte();
            this.Usu_AsigTableAdapter = new JardinMisPrimerasLetras.DataSetReporteTableAdapters.Usu_AsigTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Usu_AsigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Usu_Asi";
            reportDataSource1.Value = this.Usu_AsigBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JardinMisPrimerasLetras.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load_1);
            // 
            // Usu_AsigBindingSource
            // 
            this.Usu_AsigBindingSource.DataMember = "Usu_Asig";
            this.Usu_AsigBindingSource.DataSource = this.DataSetReporte;
            // 
            // DataSetReporte
            // 
            this.DataSetReporte.DataSetName = "DataSetReporte";
            this.DataSetReporte.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Usu_AsigTableAdapter
            // 
            this.Usu_AsigTableAdapter.ClearBeforeFill = true;
            // 
            // Reporte_Alumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Reporte_Alumno";
            this.Text = "Reporte Docente";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Usu_AsigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporte)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Usu_AsigBindingSource;
        private DataSetReporte DataSetReporte;
        private DataSetReporteTableAdapters.Usu_AsigTableAdapter Usu_AsigTableAdapter;
    }
}