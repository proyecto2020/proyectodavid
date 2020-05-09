﻿namespace JardinMisPrimerasLetras
{
    partial class AdministradorUsuarios
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelTipoPerfil = new System.Windows.Forms.Label();
            this.perfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPrimerNombre = new System.Windows.Forms.Label();
            this.labelCedula = new System.Windows.Forms.Label();
            this.textBoxCedula = new System.Windows.Forms.TextBox();
            this.labelPrimerApellido = new System.Windows.Forms.Label();
            this.labelSegundoNombre = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.labelSendoApellido = new System.Windows.Forms.Label();
            this.textBoxSegundoApellido = new System.Windows.Forms.TextBox();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.primerNombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoApellidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.correoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Perfil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jardinDataSet1 = new JardinMisPrimerasLetras.jardinDataSet();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.TipoPerfil = new System.Windows.Forms.ComboBox();
            this.perfilesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.perfilesDataSet = new JardinMisPrimerasLetras.PerfilesDataSet();
            this.usuarioTableAdapter = new JardinMisPrimerasLetras.jardinDataSetTableAdapters.UsuarioTableAdapter();
            this.perfilesTableAdapter = new JardinMisPrimerasLetras.PerfilesDataSetTableAdapters.PerfilesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jardinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(393, 248);
            this.textBox1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(523, 44);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelTipoPerfil
            // 
            this.labelTipoPerfil.AutoSize = true;
            this.labelTipoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.labelTipoPerfil.Location = new System.Drawing.Point(111, 137);
            this.labelTipoPerfil.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelTipoPerfil.Name = "labelTipoPerfil";
            this.labelTipoPerfil.Size = new System.Drawing.Size(202, 37);
            this.labelTipoPerfil.TabIndex = 1;
            this.labelTipoPerfil.Text = "Tipo de perfil";
            // 
            // perfilesBindingSource
            // 
            this.perfilesBindingSource.DataMember = "Perfiles";
            // 
            // labelPrimerNombre
            // 
            this.labelPrimerNombre.AutoSize = true;
            this.labelPrimerNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelPrimerNombre.Location = new System.Drawing.Point(95, 268);
            this.labelPrimerNombre.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelPrimerNombre.Name = "labelPrimerNombre";
            this.labelPrimerNombre.Size = new System.Drawing.Size(229, 37);
            this.labelPrimerNombre.TabIndex = 5;
            this.labelPrimerNombre.Text = "Primer nombre";
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.BackColor = System.Drawing.Color.Transparent;
            this.labelCedula.Location = new System.Drawing.Point(193, 455);
            this.labelCedula.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(118, 37);
            this.labelCedula.TabIndex = 6;
            this.labelCedula.Text = "Cedula";
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(393, 435);
            this.textBoxCedula.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(523, 44);
            this.textBoxCedula.TabIndex = 7;
            this.textBoxCedula.TextChanged += new System.EventHandler(this.textBoxCedula_TextChanged);
            // 
            // labelPrimerApellido
            // 
            this.labelPrimerApellido.AutoSize = true;
            this.labelPrimerApellido.BackColor = System.Drawing.Color.Transparent;
            this.labelPrimerApellido.Location = new System.Drawing.Point(1042, 256);
            this.labelPrimerApellido.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelPrimerApellido.Name = "labelPrimerApellido";
            this.labelPrimerApellido.Size = new System.Drawing.Size(230, 37);
            this.labelPrimerApellido.TabIndex = 10;
            this.labelPrimerApellido.Text = "Primer apellido";
            // 
            // labelSegundoNombre
            // 
            this.labelSegundoNombre.AutoSize = true;
            this.labelSegundoNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelSegundoNombre.Location = new System.Drawing.Point(51, 356);
            this.labelSegundoNombre.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelSegundoNombre.Name = "labelSegundoNombre";
            this.labelSegundoNombre.Size = new System.Drawing.Size(263, 37);
            this.labelSegundoNombre.TabIndex = 11;
            this.labelSegundoNombre.Text = "Segundo nombre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(393, 347);
            this.textBox2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(523, 44);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(1371, 248);
            this.textBox3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(523, 44);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelSendoApellido
            // 
            this.labelSendoApellido.AutoSize = true;
            this.labelSendoApellido.BackColor = System.Drawing.Color.Transparent;
            this.labelSendoApellido.Location = new System.Drawing.Point(998, 367);
            this.labelSendoApellido.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelSendoApellido.Name = "labelSendoApellido";
            this.labelSendoApellido.Size = new System.Drawing.Size(264, 37);
            this.labelSendoApellido.TabIndex = 14;
            this.labelSendoApellido.Text = "Segundo apellido";
            // 
            // textBoxSegundoApellido
            // 
            this.textBoxSegundoApellido.Location = new System.Drawing.Point(1371, 356);
            this.textBoxSegundoApellido.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxSegundoApellido.Name = "textBoxSegundoApellido";
            this.textBoxSegundoApellido.Size = new System.Drawing.Size(523, 44);
            this.textBoxSegundoApellido.TabIndex = 15;
            this.textBoxSegundoApellido.TextChanged += new System.EventHandler(this.textBoxSegundoApellido_TextChanged);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(795, 672);
            this.buttonGuardar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(238, 65);
            this.buttonGuardar.TabIndex = 18;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(1051, 672);
            this.buttonEditar.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(238, 65);
            this.buttonEditar.TabIndex = 20;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.primerNombreDataGridViewTextBoxColumn,
            this.primerApellidoDataGridViewTextBoxColumn,
            this.segundoApellidoDataGridViewTextBoxColumn,
            this.correoDataGridViewTextBoxColumn,
            this.Perfil});
            this.dataGridView1.DataSource = this.usuarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(285, 797);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 123;
            this.dataGridView1.Size = new System.Drawing.Size(1403, 188);
            this.dataGridView1.TabIndex = 22;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // primerNombreDataGridViewTextBoxColumn
            // 
            this.primerNombreDataGridViewTextBoxColumn.DataPropertyName = "primerNombre";
            this.primerNombreDataGridViewTextBoxColumn.HeaderText = "primerNombre";
            this.primerNombreDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.primerNombreDataGridViewTextBoxColumn.Name = "primerNombreDataGridViewTextBoxColumn";
            this.primerNombreDataGridViewTextBoxColumn.Width = 300;
            // 
            // primerApellidoDataGridViewTextBoxColumn
            // 
            this.primerApellidoDataGridViewTextBoxColumn.DataPropertyName = "primerApellido";
            this.primerApellidoDataGridViewTextBoxColumn.HeaderText = "primerApellido";
            this.primerApellidoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.primerApellidoDataGridViewTextBoxColumn.Name = "primerApellidoDataGridViewTextBoxColumn";
            this.primerApellidoDataGridViewTextBoxColumn.Width = 300;
            // 
            // segundoApellidoDataGridViewTextBoxColumn
            // 
            this.segundoApellidoDataGridViewTextBoxColumn.DataPropertyName = "segundoApellido";
            this.segundoApellidoDataGridViewTextBoxColumn.HeaderText = "segundoApellido";
            this.segundoApellidoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.segundoApellidoDataGridViewTextBoxColumn.Name = "segundoApellidoDataGridViewTextBoxColumn";
            this.segundoApellidoDataGridViewTextBoxColumn.Width = 300;
            // 
            // correoDataGridViewTextBoxColumn
            // 
            this.correoDataGridViewTextBoxColumn.DataPropertyName = "correo";
            this.correoDataGridViewTextBoxColumn.HeaderText = "correo";
            this.correoDataGridViewTextBoxColumn.MinimumWidth = 15;
            this.correoDataGridViewTextBoxColumn.Name = "correoDataGridViewTextBoxColumn";
            this.correoDataGridViewTextBoxColumn.Width = 300;
            // 
            // Perfil
            // 
            this.Perfil.DataPropertyName = "identificacacion";
            this.Perfil.HeaderText = "Perfil";
            this.Perfil.MinimumWidth = 15;
            this.Perfil.Name = "Perfil";
            this.Perfil.Width = 300;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.jardinDataSet1;
            // 
            // jardinDataSet1
            // 
            this.jardinDataSet1.DataSetName = "jardinDataSet";
            this.jardinDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // labelCorreo
            // 
            this.labelCorreo.AutoSize = true;
            this.labelCorreo.BackColor = System.Drawing.Color.Transparent;
            this.labelCorreo.Location = new System.Drawing.Point(1086, 455);
            this.labelCorreo.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(115, 37);
            this.labelCorreo.TabIndex = 23;
            this.labelCorreo.Text = "Correo";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(1371, 447);
            this.textBoxCorreo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(523, 44);
            this.textBoxCorreo.TabIndex = 24;
            this.textBoxCorreo.TextChanged += new System.EventHandler(this.textBoxCorreo_TextChanged);
            // 
            // TipoPerfil
            // 
            this.TipoPerfil.DataSource = this.perfilesBindingSource1;
            this.TipoPerfil.DisplayMember = "descripcion";
            this.TipoPerfil.FormattingEnabled = true;
            this.TipoPerfil.Location = new System.Drawing.Point(393, 128);
            this.TipoPerfil.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.TipoPerfil.Name = "TipoPerfil";
            this.TipoPerfil.Size = new System.Drawing.Size(523, 45);
            this.TipoPerfil.TabIndex = 25;
            this.TipoPerfil.SelectedIndexChanged += new System.EventHandler(this.TipoPerfil_SelectedIndexChanged);
            // 
            // perfilesBindingSource1
            // 
            this.perfilesBindingSource1.DataMember = "Perfiles";
            this.perfilesBindingSource1.DataSource = this.perfilesDataSet;
            // 
            // perfilesDataSet
            // 
            this.perfilesDataSet.DataSetName = "PerfilesDataSet";
            this.perfilesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // perfilesTableAdapter
            // 
            this.perfilesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1675, 1104);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(228, 142);
            this.button1.TabIndex = 29;
            this.button1.Text = "GESTION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdministradorUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1998, 1281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TipoPerfil);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.labelCorreo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.textBoxSegundoApellido);
            this.Controls.Add(this.labelSendoApellido);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.labelSegundoNombre);
            this.Controls.Add(this.labelPrimerApellido);
            this.Controls.Add(this.textBoxCedula);
            this.Controls.Add(this.labelCedula);
            this.Controls.Add(this.labelPrimerNombre);
            this.Controls.Add(this.labelTipoPerfil);
            this.Controls.Add(this.textBox1);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "AdministradorUsuarios";
            this.Text = "AdministradorUsuarios";
            this.Load += new System.EventHandler(this.AdministradorUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jardinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelTipoPerfil;
        private System.Windows.Forms.Label labelPrimerNombre;
        private System.Windows.Forms.Label labelCedula;
        private System.Windows.Forms.TextBox textBoxCedula;
        private System.Windows.Forms.Label labelPrimerApellido;
        private System.Windows.Forms.Label labelSegundoNombre;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label labelSendoApellido;
        private System.Windows.Forms.TextBox textBoxSegundoApellido;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private jardinDataSet jardinDataSet;
        private System.Windows.Forms.BindingSource perfilesBindingSource;
        private jardinDataSet jardinDataSet1;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private jardinDataSetTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.ComboBox TipoPerfil;
        private PerfilesDataSet perfilesDataSet;
        private System.Windows.Forms.BindingSource perfilesBindingSource1;
        private PerfilesDataSetTableAdapters.PerfilesTableAdapter perfilesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Perfil;
    }
}