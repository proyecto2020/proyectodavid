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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.letrasDataSetMateria = new JardinMisPrimerasLetras.LetrasDataSetMateria();
            this.comboBoxArea = new System.Windows.Forms.ComboBox();
            this.areaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.letrasDataSetArea = new JardinMisPrimerasLetras.LetrasDataSetArea();
            this.comboBoxGrados = new System.Windows.Forms.ComboBox();
            this.gradosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.letrasDataSetGrados = new JardinMisPrimerasLetras.LetrasDataSetGrados();
            this.label6 = new System.Windows.Forms.Label();
            this.Salones = new System.Windows.Forms.ComboBox();
            this.salonesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.letrasDataSetSalones = new JardinMisPrimerasLetras.LetrasDataSetSalones();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.gradosTableAdapter = new JardinMisPrimerasLetras.LetrasDataSetGradosTableAdapters.GradosTableAdapter();
            this.salonesTableAdapter = new JardinMisPrimerasLetras.LetrasDataSetSalonesTableAdapters.SalonesTableAdapter();
            this.Grupos = new System.Windows.Forms.ComboBox();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.letrasDataSetGrupos = new JardinMisPrimerasLetras.LetrasDataSetGrupos();
            this.gruposTableAdapter = new JardinMisPrimerasLetras.LetrasDataSetGruposTableAdapters.GruposTableAdapter();
            this.areaTableAdapter = new JardinMisPrimerasLetras.LetrasDataSetAreaTableAdapters.AreaTableAdapter();
            this.materiaTableAdapter = new JardinMisPrimerasLetras.LetrasDataSetMateriaTableAdapters.MateriaTableAdapter();
            this.MDocente = new System.Windows.Forms.ComboBox();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.letrasDataSetDocente = new JardinMisPrimerasLetras.LetrasDataSetDocente();
            this.usuarioTableAdapter = new JardinMisPrimerasLetras.LetrasDataSetDocenteTableAdapters.UsuarioTableAdapter();
            this.docenteToolStrip = new System.Windows.Forms.ToolStrip();
            this.docenteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.letrasDataSetGestion = new JardinMisPrimerasLetras.LetrasDataSetGestion();
            this.gestionBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gestionTableAdapter = new JardinMisPrimerasLetras.LetrasDataSetGestionTableAdapters.GestionTableAdapter();
            this.gruposDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.areaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.docenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salonesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetMateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetGrados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetSalones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetGrupos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetDocente)).BeginInit();
            this.docenteToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetGestion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Grupos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(215, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Grados";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Area";
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(240, 176);
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
            this.gruposDataGridViewTextBoxColumn,
            this.areaDataGridViewTextBoxColumn,
            this.docenteDataGridViewTextBoxColumn,
            this.gradosDataGridViewTextBoxColumn,
            this.materiaDataGridViewTextBoxColumn,
            this.salonesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gestionBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 113);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Docente";
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.DataSource = this.materiaBindingSource;
            this.comboBoxMateria.DisplayMember = "Nombre_Materia";
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Location = new System.Drawing.Point(218, 131);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMateria.TabIndex = 9;
            this.comboBoxMateria.SelectedIndexChanged += new System.EventHandler(this.comboBoxMateria_SelectedIndexChanged);
            // 
            // materiaBindingSource
            // 
            this.materiaBindingSource.DataMember = "Materia";
            this.materiaBindingSource.DataSource = this.letrasDataSetMateria;
            // 
            // letrasDataSetMateria
            // 
            this.letrasDataSetMateria.DataSetName = "LetrasDataSetMateria";
            this.letrasDataSetMateria.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxArea
            // 
            this.comboBoxArea.DataSource = this.areaBindingSource;
            this.comboBoxArea.DisplayMember = "Nombre_Area";
            this.comboBoxArea.FormattingEnabled = true;
            this.comboBoxArea.Location = new System.Drawing.Point(218, 69);
            this.comboBoxArea.Name = "comboBoxArea";
            this.comboBoxArea.Size = new System.Drawing.Size(121, 21);
            this.comboBoxArea.TabIndex = 10;
            this.comboBoxArea.SelectedIndexChanged += new System.EventHandler(this.comboBoxArea_SelectedIndexChanged);
            // 
            // areaBindingSource
            // 
            this.areaBindingSource.DataMember = "Area";
            this.areaBindingSource.DataSource = this.letrasDataSetArea;
            // 
            // letrasDataSetArea
            // 
            this.letrasDataSetArea.DataSetName = "LetrasDataSetArea";
            this.letrasDataSetArea.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comboBoxGrados
            // 
            this.comboBoxGrados.DataSource = this.gradosBindingSource;
            this.comboBoxGrados.DisplayMember = "Nom_Grados";
            this.comboBoxGrados.FormattingEnabled = true;
            this.comboBoxGrados.Location = new System.Drawing.Point(29, 131);
            this.comboBoxGrados.Name = "comboBoxGrados";
            this.comboBoxGrados.Size = new System.Drawing.Size(121, 21);
            this.comboBoxGrados.TabIndex = 11;
            this.comboBoxGrados.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrados_SelectedIndexChanged);
            // 
            // gradosBindingSource
            // 
            this.gradosBindingSource.DataMember = "Grados";
            this.gradosBindingSource.DataSource = this.letrasDataSetGrados;
            // 
            // letrasDataSetGrados
            // 
            this.letrasDataSetGrados.DataSetName = "LetrasDataSetGrados";
            this.letrasDataSetGrados.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(372, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Salones";
            // 
            // Salones
            // 
            this.Salones.DataSource = this.salonesBindingSource;
            this.Salones.DisplayMember = "Cod_Salones";
            this.Salones.FormattingEnabled = true;
            this.Salones.Location = new System.Drawing.Point(375, 132);
            this.Salones.Name = "Salones";
            this.Salones.Size = new System.Drawing.Size(121, 21);
            this.Salones.TabIndex = 14;
            // 
            // salonesBindingSource
            // 
            this.salonesBindingSource.DataMember = "Salones";
            this.salonesBindingSource.DataSource = this.letrasDataSetSalones;
            // 
            // letrasDataSetSalones
            // 
            this.letrasDataSetSalones.DataSetName = "LetrasDataSetSalones";
            this.letrasDataSetSalones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 61);
            this.button1.TabIndex = 15;
            this.button1.Text = "PAGOS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 351);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 61);
            this.button2.TabIndex = 16;
            this.button2.Text = "ADM USUARIOS";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // gradosTableAdapter
            // 
            this.gradosTableAdapter.ClearBeforeFill = true;
            // 
            // salonesTableAdapter
            // 
            this.salonesTableAdapter.ClearBeforeFill = true;
            // 
            // Grupos
            // 
            this.Grupos.DataSource = this.gruposBindingSource;
            this.Grupos.DisplayMember = "Descripcion";
            this.Grupos.FormattingEnabled = true;
            this.Grupos.Location = new System.Drawing.Point(29, 69);
            this.Grupos.Name = "Grupos";
            this.Grupos.Size = new System.Drawing.Size(121, 21);
            this.Grupos.TabIndex = 17;
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataMember = "Grupos";
            this.gruposBindingSource.DataSource = this.letrasDataSetGrupos;
            // 
            // letrasDataSetGrupos
            // 
            this.letrasDataSetGrupos.DataSetName = "LetrasDataSetGrupos";
            this.letrasDataSetGrupos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gruposTableAdapter
            // 
            this.gruposTableAdapter.ClearBeforeFill = true;
            // 
            // areaTableAdapter
            // 
            this.areaTableAdapter.ClearBeforeFill = true;
            // 
            // materiaTableAdapter
            // 
            this.materiaTableAdapter.ClearBeforeFill = true;
            // 
            // MDocente
            // 
            this.MDocente.DataSource = this.usuarioBindingSource;
            this.MDocente.DisplayMember = "nombreApellido";
            this.MDocente.FormattingEnabled = true;
            this.MDocente.Location = new System.Drawing.Point(375, 69);
            this.MDocente.Name = "MDocente";
            this.MDocente.Size = new System.Drawing.Size(121, 21);
            this.MDocente.TabIndex = 18;
            this.MDocente.SelectedIndexChanged += new System.EventHandler(this.MDocente_SelectedIndexChanged);
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "Usuario";
            this.usuarioBindingSource.DataSource = this.letrasDataSetDocente;
            // 
            // letrasDataSetDocente
            // 
            this.letrasDataSetDocente.DataSetName = "LetrasDataSetDocente";
            this.letrasDataSetDocente.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // docenteToolStrip
            // 
            this.docenteToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.docenteToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.docenteToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.docenteToolStripButton});
            this.docenteToolStrip.Location = new System.Drawing.Point(0, 0);
            this.docenteToolStrip.Name = "docenteToolStrip";
            this.docenteToolStrip.Size = new System.Drawing.Size(58, 25);
            this.docenteToolStrip.TabIndex = 19;
            this.docenteToolStrip.Text = "docenteToolStrip";
            // 
            // docenteToolStripButton
            // 
            this.docenteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.docenteToolStripButton.Name = "docenteToolStripButton";
            this.docenteToolStripButton.Size = new System.Drawing.Size(55, 22);
            this.docenteToolStripButton.Text = "Docente";
            this.docenteToolStripButton.Click += new System.EventHandler(this.docenteToolStripButton_Click_2);
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
            // docenteDataGridViewTextBoxColumn
            // 
            this.docenteDataGridViewTextBoxColumn.DataPropertyName = "Docente";
            this.docenteDataGridViewTextBoxColumn.HeaderText = "Docente";
            this.docenteDataGridViewTextBoxColumn.Name = "docenteDataGridViewTextBoxColumn";
            // 
            // gradosDataGridViewTextBoxColumn
            // 
            this.gradosDataGridViewTextBoxColumn.DataPropertyName = "Grados";
            this.gradosDataGridViewTextBoxColumn.HeaderText = "Grados";
            this.gradosDataGridViewTextBoxColumn.Name = "gradosDataGridViewTextBoxColumn";
            // 
            // materiaDataGridViewTextBoxColumn
            // 
            this.materiaDataGridViewTextBoxColumn.DataPropertyName = "Materia";
            this.materiaDataGridViewTextBoxColumn.HeaderText = "Materia";
            this.materiaDataGridViewTextBoxColumn.Name = "materiaDataGridViewTextBoxColumn";
            // 
            // salonesDataGridViewTextBoxColumn
            // 
            this.salonesDataGridViewTextBoxColumn.DataPropertyName = "Salones";
            this.salonesDataGridViewTextBoxColumn.HeaderText = "Salones";
            this.salonesDataGridViewTextBoxColumn.Name = "salonesDataGridViewTextBoxColumn";
            // 
            // IngGestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(576, 450);
            this.Controls.Add(this.docenteToolStrip);
            this.Controls.Add(this.MDocente);
            this.Controls.Add(this.Grupos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Salones);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBoxGrados);
            this.Controls.Add(this.comboBoxArea);
            this.Controls.Add(this.comboBoxMateria);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IngGestion";
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.Gestion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetMateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.areaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetGrados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salonesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetSalones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetGrupos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetDocente)).EndInit();
            this.docenteToolStrip.ResumeLayout(false);
            this.docenteToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.letrasDataSetGestion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestionBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private System.Windows.Forms.ComboBox comboBoxArea;
        private System.Windows.Forms.ComboBox comboBoxGrados;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox Salones;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private LetrasDataSetGrados letrasDataSetGrados;
        private System.Windows.Forms.BindingSource gradosBindingSource;
        private LetrasDataSetGradosTableAdapters.GradosTableAdapter gradosTableAdapter;
        private LetrasDataSetSalones letrasDataSetSalones;
        private System.Windows.Forms.BindingSource salonesBindingSource;
        private LetrasDataSetSalonesTableAdapters.SalonesTableAdapter salonesTableAdapter;
        private System.Windows.Forms.ComboBox Grupos;
        private LetrasDataSetGrupos letrasDataSetGrupos;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        private LetrasDataSetGruposTableAdapters.GruposTableAdapter gruposTableAdapter;
        private LetrasDataSetArea letrasDataSetArea;
        private System.Windows.Forms.BindingSource areaBindingSource;
        private LetrasDataSetAreaTableAdapters.AreaTableAdapter areaTableAdapter;
        private LetrasDataSetMateria letrasDataSetMateria;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private LetrasDataSetMateriaTableAdapters.MateriaTableAdapter materiaTableAdapter;
        private System.Windows.Forms.ComboBox MDocente;
        private LetrasDataSetDocente letrasDataSetDocente;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private LetrasDataSetDocenteTableAdapters.UsuarioTableAdapter usuarioTableAdapter;
        private System.Windows.Forms.ToolStrip docenteToolStrip;
        private System.Windows.Forms.ToolStripButton docenteToolStripButton;
        private LetrasDataSetGestion letrasDataSetGestion;
        private System.Windows.Forms.BindingSource gestionBindingSource;
        private LetrasDataSetGestionTableAdapters.GestionTableAdapter gestionTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn gruposDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn areaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn docenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn materiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salonesDataGridViewTextBoxColumn;
    }
}