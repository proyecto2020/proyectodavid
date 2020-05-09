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
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Observaciones = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Grupo
            // 
            this.Grupo.DataSource = this.gruposBindingSource;
            this.Grupo.DisplayMember = "Descripcion";
            this.Grupo.FormattingEnabled = true;
            this.Grupo.Location = new System.Drawing.Point(558, 277);
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
            this.ValorAbono.Location = new System.Drawing.Point(591, 660);
            this.ValorAbono.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ValorAbono.Name = "ValorAbono";
            this.ValorAbono.Size = new System.Drawing.Size(270, 44);
            this.ValorAbono.TabIndex = 10;
            this.ValorAbono.Text = "$";
            // 
            // Saldo
            // 
            this.Saldo.Location = new System.Drawing.Point(1157, 660);
            this.Saldo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Saldo.Name = "Saldo";
            this.Saldo.Size = new System.Drawing.Size(270, 44);
            this.Saldo.TabIndex = 11;
            this.Saldo.Text = "$";
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(1734, 660);
            this.Total.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(270, 44);
            this.Total.TabIndex = 12;
            this.Total.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(551, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(343, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccionar Estudiante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(637, 567);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 37);
            this.label11.TabIndex = 23;
            this.label11.Text = "Valor Abono";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1162, 567);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 37);
            this.label12.TabIndex = 24;
            this.label12.Text = "Saldo Pendiente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1756, 567);
            this.label13.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 37);
            this.label13.TabIndex = 25;
            this.label13.Text = "Total a Pagar";
            // 
            // Observaciones
            // 
            this.Observaciones.FormattingEnabled = true;
            this.Observaciones.ItemHeight = 37;
            this.Observaciones.Location = new System.Drawing.Point(1004, 876);
            this.Observaciones.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Size = new System.Drawing.Size(618, 189);
            this.Observaciones.TabIndex = 29;
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(4937, 3171);
            this.button2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(238, 65);
            this.button2.TabIndex = 39;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(144, 26);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 55);
            this.label15.TabIndex = 41;
            this.label15.Text = "Pagos";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(82, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(289, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(2758, 1298);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Observaciones);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Grupo;
        private System.Windows.Forms.TextBox ValorAbono;
        private System.Windows.Forms.TextBox Saldo;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ListBox Observaciones;
        //private LetrasDataSetGrupo letrasDataSetGrupo;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        //private LetrasDataSetGrupoTableAdapters.GruposTableAdapter gruposTableAdapter;
        //private LetrasDataSetGrado letrasDataSetGrado;
        private System.Windows.Forms.BindingSource gradosBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}