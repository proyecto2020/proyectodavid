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
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gradosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gruposDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.letrasDataSetGestion = new JardinMisPrimerasLetras.LetrasDataSetGestion();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textGrados = new System.Windows.Forms.TextBox();
            this.gestionTableAdapter = new JardinMisPrimerasLetras.LetrasDataSetGestionTableAdapters.GestionTableAdapter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetGestion)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 42);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(358, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Division Grupo";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(407, 123);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 4;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.gradosDataGridViewTextBoxColumn,
            this.gruposDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.materiaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gestionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(73, 205);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 113);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // gradosDataGridViewTextBoxColumn
            // 
            this.gradosDataGridViewTextBoxColumn.DataPropertyName = "Grados";
            this.gradosDataGridViewTextBoxColumn.HeaderText = "Grados";
            this.gradosDataGridViewTextBoxColumn.Name = "gradosDataGridViewTextBoxColumn";
            // 
            // gruposDataGridViewTextBoxColumn
            // 
            this.gruposDataGridViewTextBoxColumn.DataPropertyName = "Grupos";
            this.gruposDataGridViewTextBoxColumn.HeaderText = "Grupos";
            this.gruposDataGridViewTextBoxColumn.Name = "gruposDataGridViewTextBoxColumn";
            // 
            // areaDataGridViewTextBoxColumn
            // 
            this.areaDataGridViewTextBoxColumn.DataPropertyName = "Area";
            this.areaDataGridViewTextBoxColumn.HeaderText = "Area";
            this.areaDataGridViewTextBoxColumn.Name = "areaDataGridViewTextBoxColumn";
            // 
            // materiaDataGridViewTextBoxColumn
            // 
            this.materiaDataGridViewTextBoxColumn.DataPropertyName = "Materia";
            this.materiaDataGridViewTextBoxColumn.HeaderText = "Materia";
            this.materiaDataGridViewTextBoxColumn.Name = "materiaDataGridViewTextBoxColumn";
            // 
            // gestionBindingSource
            // 
            this.gestionBindingSource.DataMember = "Gestion";
            this.gestionBindingSource.DataSource = this.letrasDataSetGestion;
            // 
            // letrasDataSetGestion
            // 
            this.letrasDataSetGestion.DataSetName = "LetrasDataSetGestion";
            this.letrasDataSetGestion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.gestionBindingSource.DataMember = "Gestion";
            this.gestionBindingSource.DataSource = this.letrasDataSetGestion;
            // 
            // letrasDataSetGestion
            // 
            this.letrasDataSetGestion.DataSetName = "LetrasDataSetGestion";
            this.letrasDataSetGestion.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textGrados
            // 
            this.textGrados.Location = new System.Drawing.Point(86, 65);
            this.textGrados.Name = "textGrados";
            this.textGrados.Size = new System.Drawing.Size(100, 20);
            this.textGrados.TabIndex = 17;
            // 
            // gestionTableAdapter
            // 
            this.gestionTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(211, 63);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(86, 123);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(121, 21);
            this.comboBox3.TabIndex = 23;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Docentes";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(361, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 25;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // IngGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textGrados);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "IngGestion";
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Gestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetGestion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textGrados;
        private LetrasDataSetGestion letrasDataSetGestion;
        private System.Windows.Forms.BindingSource gestionBindingSource;
        private LetrasDataSetGestionTableAdapters.GestionTableAdapter gestionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gruposDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
    }
}