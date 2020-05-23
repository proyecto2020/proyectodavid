namespace JardinMisPrimerasLetras
{
    partial class ReporteAlumno
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
            this.Usu_AsigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Usu_AsigTableAdapter = new JardinMisPrimerasLetras.DataSetReporteTableAdapters.Usu_AsigTableAdapter();
            this.Alum_NotaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Alum_NotaTableAdapter = new JardinMisPrimerasLetras.DataSetReporteTableAdapters.Alum_NotaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usu_AsigBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alum_NotaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Alumnos";
            reportDataSource1.Value = this.Alum_NotaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "JardinMisPrimerasLetras.Report2.rdlc";
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
            // Usu_AsigBindingSource
            // 
            this.Usu_AsigBindingSource.DataMember = "Usu_Asig";
            this.Usu_AsigBindingSource.DataSource = this.DataSetReporte;
            // 
            // Usu_AsigTableAdapter
            // 
            this.Usu_AsigTableAdapter.ClearBeforeFill = true;
            // 
            // Alum_NotaBindingSource
            // 
            this.Alum_NotaBindingSource.DataMember = "Alum_Nota";
            this.Alum_NotaBindingSource.DataSource = this.DataSetReporte;
            // 
            // Alum_NotaTableAdapter
            // 
            this.Alum_NotaTableAdapter.ClearBeforeFill = true;
            // 
            // ReporteAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ReporteAlumno";
            this.Text = "ReporteAlumno";
            this.Load += new System.EventHandler(this.ReporteAlumno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataSetReporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Usu_AsigBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Alum_NotaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource Usu_AsigBindingSource;
        private DataSetReporte DataSetReporte;
        private DataSetReporteTableAdapters.Usu_AsigTableAdapter Usu_AsigTableAdapter;
        private System.Windows.Forms.BindingSource Alum_NotaBindingSource;
        private DataSetReporteTableAdapters.Alum_NotaTableAdapter Alum_NotaTableAdapter;
    }
}