namespace JardinMisPrimerasLetras
{
    partial class asiganacionAcademica
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
            this.Estudiante = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Salon = new System.Windows.Forms.ComboBox();
            this.salonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.letrasDataSetSalon = new JardinMisPrimerasLetras.LetrasDataSetSalon();
            this.Hora = new System.Windows.Forms.ComboBox();
            this.horaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.letrasDataSetHora = new JardinMisPrimerasLetras.LetrasDataSetHora();
            this.Dia = new System.Windows.Forms.ComboBox();
            this.diaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.letrasDataSetDia = new JardinMisPrimerasLetras.LetrasDataSetDia();
            this.Materia = new System.Windows.Forms.ComboBox();
            this.Grupo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Docente = new System.Windows.Forms.ComboBox();
            this.guardar = new System.Windows.Forms.Button();
            this.Observaciones = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.salonTableAdapter = new JardinMisPrimerasLetras.LetrasDataSetSalonTableAdapters.SalonTableAdapter();
            this.diaTableAdapter = new JardinMisPrimerasLetras.LetrasDataSetDiaTableAdapters.DiaTableAdapter();
            this.horaTableAdapter = new JardinMisPrimerasLetras.LetrasDataSetHoraTableAdapters.HoraTableAdapter();
            this.letrasDataSetDoc = new JardinMisPrimerasLetras.LetrasDataSetDoc();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new JardinMisPrimerasLetras.LetrasDataSetDocTableAdapters.UsuarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.salonBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetSalon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetHora)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetDia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetDoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Estudiante
            // 
            this.Estudiante.FormattingEnabled = true;
            this.Estudiante.Location = new System.Drawing.Point(42, 55);
            this.Estudiante.Margin = new System.Windows.Forms.Padding(1);
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.Size = new System.Drawing.Size(208, 21);
            this.Estudiante.TabIndex = 0;
            this.Estudiante.SelectedIndexChanged += new System.EventHandler(this.Estudiante_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar Estudiante";
            // 
            // Salon
            // 
            this.Salon.DataSource = this.salonBindingSource;
            this.Salon.DisplayMember = "descripcion";
            this.Salon.FormattingEnabled = true;
            this.Salon.Location = new System.Drawing.Point(566, 137);
            this.Salon.Margin = new System.Windows.Forms.Padding(1);
            this.Salon.Name = "Salon";
            this.Salon.Size = new System.Drawing.Size(105, 21);
            this.Salon.TabIndex = 2;
            // 
            // salonBindingSource
            // 
            this.salonBindingSource.DataMember = "Salon";
            this.salonBindingSource.DataSource = this.letrasDataSetSalon;
            // 
            // letrasDataSetSalon
            // 
            this.letrasDataSetSalon.DataSetName = "LetrasDataSetSalon";
            this.letrasDataSetSalon.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Hora
            // 
            this.Hora.DataSource = this.horaBindingSource;
            this.Hora.DisplayMember = "descripcion";
            this.Hora.FormattingEnabled = true;
            this.Hora.Location = new System.Drawing.Point(299, 211);
            this.Hora.Margin = new System.Windows.Forms.Padding(1);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(105, 21);
            this.Hora.TabIndex = 3;
            // 
            // horaBindingSource
            // 
            this.horaBindingSource.DataMember = "Hora";
            this.horaBindingSource.DataSource = this.letrasDataSetHora;
            // 
            // letrasDataSetHora
            // 
            this.letrasDataSetHora.DataSetName = "LetrasDataSetHora";
            this.letrasDataSetHora.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Dia
            // 
            this.Dia.DataSource = this.diaBindingSource;
            this.Dia.DisplayMember = "descripcion";
            this.Dia.FormattingEnabled = true;
            this.Dia.Location = new System.Drawing.Point(42, 211);
            this.Dia.Margin = new System.Windows.Forms.Padding(1);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(105, 21);
            this.Dia.TabIndex = 4;
            // 
            // diaBindingSource
            // 
            this.diaBindingSource.DataMember = "Dia";
            this.diaBindingSource.DataSource = this.letrasDataSetDia;
            // 
            // letrasDataSetDia
            // 
            this.letrasDataSetDia.DataSetName = "LetrasDataSetDia";
            this.letrasDataSetDia.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Materia
            // 
            this.Materia.FormattingEnabled = true;
            this.Materia.Location = new System.Drawing.Point(299, 137);
            this.Materia.Margin = new System.Windows.Forms.Padding(1);
            this.Materia.Name = "Materia";
            this.Materia.Size = new System.Drawing.Size(105, 21);
            this.Materia.TabIndex = 5;
            this.Materia.SelectedIndexChanged += new System.EventHandler(this.Materia_SelectedIndexChanged);
            // 
            // Grupo
            // 
            this.Grupo.FormattingEnabled = true;
            this.Grupo.Location = new System.Drawing.Point(42, 137);
            this.Grupo.Margin = new System.Windows.Forms.Padding(1);
            this.Grupo.Name = "Grupo";
            this.Grupo.Size = new System.Drawing.Size(105, 21);
            this.Grupo.TabIndex = 6;
            this.Grupo.SelectedIndexChanged += new System.EventHandler(this.Grupo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccionar Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(564, 113);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccionar Salon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 113);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seleccionar Materia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 113);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Seleccionar Grupo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 188);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Seleccionar Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(559, 188);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Seleccionar Docente";
            // 
            // Docente
            // 
            this.Docente.DataSource = this.usuarioBindingSource;
            this.Docente.DisplayMember = "primerNombre";
            this.Docente.FormattingEnabled = true;
            this.Docente.Location = new System.Drawing.Point(561, 211);
            this.Docente.Margin = new System.Windows.Forms.Padding(1);
            this.Docente.Name = "Docente";
            this.Docente.Size = new System.Drawing.Size(105, 21);
            this.Docente.TabIndex = 12;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(349, 340);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 61;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // Observaciones
            // 
            this.Observaciones.Location = new System.Drawing.Point(135, 297);
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Size = new System.Drawing.Size(477, 20);
            this.Observaciones.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Observaciones";
            // 
            // salonTableAdapter
            // 
            this.salonTableAdapter.ClearBeforeFill = true;
            // 
            // diaTableAdapter
            // 
            this.diaTableAdapter.ClearBeforeFill = true;
            // 
            // horaTableAdapter
            // 
            this.horaTableAdapter.ClearBeforeFill = true;
            // 
            // letrasDataSetDoc
            // 
            this.letrasDataSetDoc.DataSetName = "LetrasDataSetDoc";
            this.letrasDataSetDoc.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.letrasDataSetDoc;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // asiganacionAcademica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(759, 375);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Observaciones);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Docente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grupo);
            this.Controls.Add(this.Materia);
            this.Controls.Add(this.Dia);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.Salon);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Estudiante);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "asiganacionAcademica";
            this.Text = "Asiganacion Academica";
            this.Load += new System.EventHandler(this.asiganacionAcademica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.salonBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetSalon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetHora)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetDia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetDoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Estudiante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Salon;
        private System.Windows.Forms.ComboBox Hora;
        private System.Windows.Forms.ComboBox Dia;
        private System.Windows.Forms.ComboBox Materia;
        private System.Windows.Forms.ComboBox Grupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Docente;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.TextBox Observaciones;
        private System.Windows.Forms.Label label8;
        private LetrasDataSetSalon letrasDataSetSalon;
        private System.Windows.Forms.BindingSource salonBindingSource;
        private LetrasDataSetSalonTableAdapters.SalonTableAdapter salonTableAdapter;
        private LetrasDataSetDia letrasDataSetDia;
        private System.Windows.Forms.BindingSource diaBindingSource;
        private LetrasDataSetDiaTableAdapters.DiaTableAdapter diaTableAdapter;
        private LetrasDataSetHora letrasDataSetHora;
        private System.Windows.Forms.BindingSource horaBindingSource;
        private LetrasDataSetHoraTableAdapters.HoraTableAdapter horaTableAdapter;
        private LetrasDataSetDoc letrasDataSetDoc;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private LetrasDataSetDocTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
    }
}