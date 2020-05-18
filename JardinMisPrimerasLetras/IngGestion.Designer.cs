using Entidades;
using System.Collections.Generic;

namespace JardinMisPrimerasLetras
{
    partial class IngGestion
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Grupos = new System.Windows.Forms.ComboBox();
            this.area = new System.Windows.Forms.Label();
            this.Materia = new System.Windows.Forms.Label();
            this.comboArea = new System.Windows.Forms.ComboBox();
            this.comboMateria = new System.Windows.Forms.ComboBox();
            this.comboBoxGrado = new System.Windows.Forms.ComboBox();
            this.letrasDataSetGestion = new JardinMisPrimerasLetras.LetrasDataSetGestion();
            this.gestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionTableAdapter = new JardinMisPrimerasLetras.LetrasDataSetGestionTableAdapters.GestionTableAdapter();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetGestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grados";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(256, 198);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridView1.DataSource = this.gestionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(72, 269);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(437, 98);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Grupos
            // 
            this.Grupos.FormattingEnabled = true;
            this.Grupos.Location = new System.Drawing.Point(333, 72);
            this.Grupos.Name = "Grupos";
            this.Grupos.Size = new System.Drawing.Size(121, 21);
            this.Grupos.TabIndex = 22;
            this.Grupos.SelectedIndexChanged += new System.EventHandler(this.Grupos_SelectedIndexChanged);
            // 
            // area
            // 
            this.area.AutoSize = true;
            this.area.Location = new System.Drawing.Point(109, 118);
            this.area.Name = "area";
            this.area.Size = new System.Drawing.Size(29, 13);
            this.area.TabIndex = 23;
            this.area.Text = "Area";
            // 
            // Materia
            // 
            this.Materia.AutoSize = true;
            this.Materia.Location = new System.Drawing.Point(330, 118);
            this.Materia.Name = "Materia";
            this.Materia.Size = new System.Drawing.Size(42, 13);
            this.Materia.TabIndex = 24;
            this.Materia.Text = "Materia";
            // 
            // comboArea
            // 
            this.comboArea.FormattingEnabled = true;
            this.comboArea.Location = new System.Drawing.Point(112, 147);
            this.comboArea.Name = "comboArea";
            this.comboArea.Size = new System.Drawing.Size(121, 21);
            this.comboArea.TabIndex = 25;
            this.comboArea.SelectedIndexChanged += new System.EventHandler(this.comboArea_SelectedIndexChanged);
            // 
            // comboMateria
            // 
            this.comboMateria.FormattingEnabled = true;
            this.comboMateria.Location = new System.Drawing.Point(333, 147);
            this.comboMateria.Name = "comboMateria";
            this.comboMateria.Size = new System.Drawing.Size(121, 21);
            this.comboMateria.TabIndex = 26;
            this.comboMateria.SelectedIndexChanged += new System.EventHandler(this.comboMateria_SelectedIndexChanged);
            // 
            // comboBoxGrado
            // 
            this.comboBoxGrado.FormattingEnabled = true;
            this.comboBoxGrado.Location = new System.Drawing.Point(112, 71);
            this.comboBoxGrado.Name = "comboBoxGrado";
            this.comboBoxGrado.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGrado.TabIndex = 27;
            this.comboBoxGrado.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrado_SelectedIndexChanged);
            // 
            // letrasDataSetGestion
            // 
            this.letrasDataSetGestion.DataSetName = "LetrasDataSetGestion";
            this.letrasDataSetGestion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gestionBindingSource
            // 
            this.gestionBindingSource.DataMember = "Gestion";
            this.gestionBindingSource.DataSource = this.letrasDataSetGestion;
            // 
            // gestionTableAdapter
            // 
            this.gestionTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Grados";
            this.dataGridViewTextBoxColumn5.HeaderText = "Grados";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "GrupoEscolar";
            this.dataGridViewTextBoxColumn6.HeaderText = "GrupoEscolar";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Area";
            this.dataGridViewTextBoxColumn7.HeaderText = "Area";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Materia";
            this.dataGridViewTextBoxColumn8.HeaderText = "Materia";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // IngGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.comboBoxGrado);
            this.Controls.Add(this.comboMateria);
            this.Controls.Add(this.comboArea);
            this.Controls.Add(this.Materia);
            this.Controls.Add(this.area);
            this.Controls.Add(this.Grupos);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "IngGestion";
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Gestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetGestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        //private LetrasDataSetGestionTableAdapters.GestionTableAdapter gestionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gruposDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox Grupos;
        private System.Windows.Forms.Label area;
        private System.Windows.Forms.Label Materia;
        private System.Windows.Forms.ComboBox comboArea;
        private System.Windows.Forms.ComboBox comboMateria;
        private System.Windows.Forms.ComboBox comboBoxGrado;
        //private LetrasDataSetListGestionTableAdapters.GestionTableAdapter gestionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGestionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGradoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGrupoEscolarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAreaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMateriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn grupoEscolarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private LetrasDataSetGestion letrasDataSetGestion;
        private System.Windows.Forms.BindingSource gestionBindingSource;
        private LetrasDataSetGestionTableAdapters.GestionTableAdapter gestionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        //private LetrasDataSetGrupoTableAdapters.GrupoEscolarTableAdapter grupoEscolarTableAdapter;
    }
}