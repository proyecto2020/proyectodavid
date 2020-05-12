namespace JardinMisPrimerasLetras
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
            this.jardinDataSet1 = new JardinMisPrimerasLetras.jardinDataSet();
            this.labelCorreo = new System.Windows.Forms.Label();
            this.textBoxCorreo = new System.Windows.Forms.TextBox();
            this.TipoPerfil = new System.Windows.Forms.ComboBox();
            this.perfilesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.perfilesDataSet = new JardinMisPrimerasLetras.PerfilesDataSet();
            this.perfilesTableAdapter = new JardinMisPrimerasLetras.PerfilesDataSetTableAdapters.PerfilesTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.perfilUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaCreacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.letrasDataSetUsu = new JardinMisPrimerasLetras.LetrasDataSetUsu();
            this.usuarioTableAdapter = new JardinMisPrimerasLetras.LetrasDataSetUsuTableAdapters.UsuarioTableAdapter();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jardinDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetUsu)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(124, 87);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(168, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelTipoPerfil
            // 
            this.labelTipoPerfil.AutoSize = true;
            this.labelTipoPerfil.BackColor = System.Drawing.Color.Transparent;
            this.labelTipoPerfil.Location = new System.Drawing.Point(35, 48);
            this.labelTipoPerfil.Name = "labelTipoPerfil";
            this.labelTipoPerfil.Size = new System.Drawing.Size(68, 13);
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
            this.labelPrimerNombre.Location = new System.Drawing.Point(30, 94);
            this.labelPrimerNombre.Name = "labelPrimerNombre";
            this.labelPrimerNombre.Size = new System.Drawing.Size(74, 13);
            this.labelPrimerNombre.TabIndex = 5;
            this.labelPrimerNombre.Text = "Primer nombre";
            // 
            // labelCedula
            // 
            this.labelCedula.AutoSize = true;
            this.labelCedula.BackColor = System.Drawing.Color.Transparent;
            this.labelCedula.Location = new System.Drawing.Point(61, 160);
            this.labelCedula.Name = "labelCedula";
            this.labelCedula.Size = new System.Drawing.Size(40, 13);
            this.labelCedula.TabIndex = 6;
            this.labelCedula.Text = "Cedula";
            // 
            // textBoxCedula
            // 
            this.textBoxCedula.Location = new System.Drawing.Point(124, 153);
            this.textBoxCedula.Name = "textBoxCedula";
            this.textBoxCedula.Size = new System.Drawing.Size(168, 20);
            this.textBoxCedula.TabIndex = 7;
            this.textBoxCedula.TextChanged += new System.EventHandler(this.textBoxCedula_TextChanged);
            // 
            // labelPrimerApellido
            // 
            this.labelPrimerApellido.AutoSize = true;
            this.labelPrimerApellido.BackColor = System.Drawing.Color.Transparent;
            this.labelPrimerApellido.Location = new System.Drawing.Point(329, 90);
            this.labelPrimerApellido.Name = "labelPrimerApellido";
            this.labelPrimerApellido.Size = new System.Drawing.Size(75, 13);
            this.labelPrimerApellido.TabIndex = 10;
            this.labelPrimerApellido.Text = "Primer apellido";
            // 
            // labelSegundoNombre
            // 
            this.labelSegundoNombre.AutoSize = true;
            this.labelSegundoNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelSegundoNombre.Location = new System.Drawing.Point(16, 125);
            this.labelSegundoNombre.Name = "labelSegundoNombre";
            this.labelSegundoNombre.Size = new System.Drawing.Size(88, 13);
            this.labelSegundoNombre.TabIndex = 11;
            this.labelSegundoNombre.Text = "Segundo nombre";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(124, 122);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(168, 20);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(433, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(168, 20);
            this.textBox3.TabIndex = 13;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // labelSendoApellido
            // 
            this.labelSendoApellido.AutoSize = true;
            this.labelSendoApellido.BackColor = System.Drawing.Color.Transparent;
            this.labelSendoApellido.Location = new System.Drawing.Point(315, 129);
            this.labelSendoApellido.Name = "labelSendoApellido";
            this.labelSendoApellido.Size = new System.Drawing.Size(89, 13);
            this.labelSendoApellido.TabIndex = 14;
            this.labelSendoApellido.Text = "Segundo apellido";
            // 
            // textBoxSegundoApellido
            // 
            this.textBoxSegundoApellido.Location = new System.Drawing.Point(433, 125);
            this.textBoxSegundoApellido.Name = "textBoxSegundoApellido";
            this.textBoxSegundoApellido.Size = new System.Drawing.Size(168, 20);
            this.textBoxSegundoApellido.TabIndex = 15;
            this.textBoxSegundoApellido.TextChanged += new System.EventHandler(this.textBoxSegundoApellido_TextChanged);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(251, 236);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 18;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(332, 236);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 20;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonEditar_Click);
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
            this.labelCorreo.Location = new System.Drawing.Point(343, 160);
            this.labelCorreo.Name = "labelCorreo";
            this.labelCorreo.Size = new System.Drawing.Size(38, 13);
            this.labelCorreo.TabIndex = 23;
            this.labelCorreo.Text = "Correo";
            // 
            // textBoxCorreo
            // 
            this.textBoxCorreo.Location = new System.Drawing.Point(433, 157);
            this.textBoxCorreo.Name = "textBoxCorreo";
            this.textBoxCorreo.Size = new System.Drawing.Size(168, 20);
            this.textBoxCorreo.TabIndex = 24;
            this.textBoxCorreo.TextChanged += new System.EventHandler(this.textBoxCorreo_TextChanged);
            // 
            // TipoPerfil
            // 
            this.TipoPerfil.DataSource = this.perfilesBindingSource1;
            this.TipoPerfil.DisplayMember = "descripcion";
            this.TipoPerfil.FormattingEnabled = true;
            this.TipoPerfil.Location = new System.Drawing.Point(124, 45);
            this.TipoPerfil.Name = "TipoPerfil";
            this.TipoPerfil.Size = new System.Drawing.Size(168, 21);
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
            // perfilesTableAdapter
            // 
            this.perfilesTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 50);
            this.button1.TabIndex = 29;
            this.button1.Text = "GESTION";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(38, 388);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 50);
            this.button2.TabIndex = 30;
            this.button2.Text = "MATRICULAS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.usuarioCreacionDataGridViewTextBoxColumn,
            this.perfilUsuarioDataGridViewTextBoxColumn,
            this.fechaCreacionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.usuarioBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(64, 265);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(602, 86);
            this.dataGridView2.TabIndex = 31;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "primerNombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "primerNombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "primerApellido";
            this.dataGridViewTextBoxColumn4.HeaderText = "primerApellido";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "correo";
            this.dataGridViewTextBoxColumn6.HeaderText = "correo";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // usuarioCreacionDataGridViewTextBoxColumn
            // 
            this.usuarioCreacionDataGridViewTextBoxColumn.DataPropertyName = "usuarioCreacion";
            this.usuarioCreacionDataGridViewTextBoxColumn.HeaderText = "usuarioCreacion";
            this.usuarioCreacionDataGridViewTextBoxColumn.Name = "usuarioCreacionDataGridViewTextBoxColumn";
            this.usuarioCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // perfilUsuarioDataGridViewTextBoxColumn
            // 
            this.perfilUsuarioDataGridViewTextBoxColumn.DataPropertyName = "perfilUsuario";
            this.perfilUsuarioDataGridViewTextBoxColumn.HeaderText = "perfilUsuario";
            this.perfilUsuarioDataGridViewTextBoxColumn.Name = "perfilUsuarioDataGridViewTextBoxColumn";
            this.perfilUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaCreacionDataGridViewTextBoxColumn
            // 
            this.fechaCreacionDataGridViewTextBoxColumn.DataPropertyName = "fechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.HeaderText = "fechaCreacion";
            this.fechaCreacionDataGridViewTextBoxColumn.Name = "fechaCreacionDataGridViewTextBoxColumn";
            this.fechaCreacionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.letrasDataSetUsu;
            // 
            // letrasDataSetUsu
            // 
            this.letrasDataSetUsu.DataSetName = "LetrasDataSetUsu";
            this.letrasDataSetUsu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(306, 388);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 50);
            this.button3.TabIndex = 32;
            this.button3.Text = "PAGOS";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(433, 388);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 50);
            this.button4.TabIndex = 33;
            this.button4.Text = "ASIGNACIÓN";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // AdministradorUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(772, 468);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.TipoPerfil);
            this.Controls.Add(this.textBoxCorreo);
            this.Controls.Add(this.labelCorreo);
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
            this.Name = "AdministradorUsuarios";
            this.Text = "AdministradorUsuarios";
            this.Load += new System.EventHandler(this.AdministradorUsuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jardinDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.perfilesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetUsu)).EndInit();
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
        private System.Windows.Forms.Label labelCorreo;
        private System.Windows.Forms.TextBox textBoxCorreo;
        private jardinDataSet jardinDataSet;
        private System.Windows.Forms.BindingSource perfilesBindingSource;
        private jardinDataSet jardinDataSet1;
        private System.Windows.Forms.ComboBox TipoPerfil;
        private PerfilesDataSet perfilesDataSet;
        private System.Windows.Forms.BindingSource perfilesBindingSource1;
        private PerfilesDataSetTableAdapters.PerfilesTableAdapter perfilesTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn identificacacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoNombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoApellidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn correoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private LetrasDataSetUsu letrasDataSetUsu;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private LetrasDataSetUsuTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn perfilUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaCreacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}