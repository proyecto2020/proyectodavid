namespace JardinMisPrimerasLetras
{
    partial class Pagos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pagos));
            this.Grupo = new System.Windows.Forms.ComboBox();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gradosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ValorAbono = new System.Windows.Forms.TextBox();
            this.Saldo = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Observaciones = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // Grupo
            // 
            this.Grupo.DataSource = this.gruposBindingSource;
            this.Grupo.DisplayMember = "Descripcion";
            this.Grupo.FormattingEnabled = true;
            this.Grupo.Location = new System.Drawing.Point(861, 233);
            this.Grupo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Grupo.Name = "Grupo";
            this.Grupo.Size = new System.Drawing.Size(375, 45);
            this.Grupo.TabIndex = 0;
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataMember = "Grupos";
            // 
            // gradosBindingSource
            // 
            this.gradosBindingSource.DataMember = "Grados";
            // 
            // ValorAbono
            // 
            this.ValorAbono.Location = new System.Drawing.Point(685, 621);
            this.ValorAbono.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ValorAbono.Name = "ValorAbono";
            this.ValorAbono.Size = new System.Drawing.Size(270, 44);
            this.ValorAbono.TabIndex = 10;
            this.ValorAbono.Text = "$";
            // 
            // Saldo
            // 
            this.Saldo.Location = new System.Drawing.Point(1240, 621);
            this.Saldo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Saldo.Name = "Saldo";
            this.Saldo.Size = new System.Drawing.Size(270, 44);
            this.Saldo.TabIndex = 11;
            this.Saldo.Text = "$";
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(1772, 621);
            this.Total.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(270, 44);
            this.Total.TabIndex = 12;
            this.Total.Text = "$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(722, 550);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 37);
            this.label11.TabIndex = 23;
            this.label11.Text = "Valor Abono";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1260, 550);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 37);
            this.label12.TabIndex = 24;
            this.label12.Text = "Saldo Pendiente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1808, 550);
            this.label13.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 37);
            this.label13.TabIndex = 25;
            this.label13.Text = "Total a Pagar";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // Observaciones
            // 
            this.Observaciones.FormattingEnabled = true;
            this.Observaciones.ItemHeight = 37;
            this.Observaciones.Location = new System.Drawing.Point(1092, 732);
            this.Observaciones.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Size = new System.Drawing.Size(618, 189);
            this.Observaciones.TabIndex = 29;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(823, 153);
            this.label14.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(430, 37);
            this.label14.TabIndex = 31;
            this.label14.Text = "Favor Seleccionar estudiante";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(5605, 3210);
            this.button1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 28);
            this.button1.TabIndex = 38;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1781, 1411);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(827, 636);
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(193, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(420, 312);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 40;
            this.pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(207, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 57);
            this.textBox1.TabIndex = 41;
            this.textBox1.Text = "Modulo de pagos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1270, 984);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(240, 63);
            this.button2.TabIndex = 42;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(2393, 1120);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Observaciones);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Saldo);
            this.Controls.Add(this.ValorAbono);
            this.Controls.Add(this.Grupo);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Grupo;
        private System.Windows.Forms.TextBox ValorAbono;
        private System.Windows.Forms.TextBox Saldo;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox Observaciones;
        private System.Windows.Forms.Label label14;
        //private LetrasDataSetGrupo letrasDataSetGrupo;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        //private LetrasDataSetGrupoTableAdapters.GruposTableAdapter gruposTableAdapter;
        //private LetrasDataSetGrado letrasDataSetGrado;
        private System.Windows.Forms.BindingSource gradosBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button2;
    }
}