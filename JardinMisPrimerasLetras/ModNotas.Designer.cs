namespace JardinMisPrimerasLetras
{
    partial class Modulo_Notas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Modulo_Notas));
            this.label1 = new System.Windows.Forms.Label();
            this.Estudiante = new System.Windows.Forms.ComboBox();
            this.Materia = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Calificacion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.Periodo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 141);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Seleccionar Estudiante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Estudiante
            // 
            this.Estudiante.FormattingEnabled = true;
            this.Estudiante.Location = new System.Drawing.Point(18, 174);
            this.Estudiante.Margin = new System.Windows.Forms.Padding(1);
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.Size = new System.Drawing.Size(120, 21);
            this.Estudiante.TabIndex = 2;
            this.Estudiante.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Materia
            // 
            this.Materia.FormattingEnabled = true;
            this.Materia.Location = new System.Drawing.Point(168, 174);
            this.Materia.Margin = new System.Windows.Forms.Padding(1);
            this.Materia.Name = "Materia";
            this.Materia.Size = new System.Drawing.Size(120, 21);
            this.Materia.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 141);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "seleccionar Materia";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(225, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Calificacion
            // 
            this.Calificacion.Location = new System.Drawing.Point(473, 174);
            this.Calificacion.Margin = new System.Windows.Forms.Padding(1);
            this.Calificacion.Name = "Calificacion";
            this.Calificacion.Size = new System.Drawing.Size(93, 20);
            this.Calificacion.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 141);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Calificacion Obtenida";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(277, 242);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(75, 23);
            this.Guardar.TabIndex = 23;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Periodo
            // 
            this.Periodo.FormattingEnabled = true;
            this.Periodo.Location = new System.Drawing.Point(321, 174);
            this.Periodo.Margin = new System.Windows.Forms.Padding(1);
            this.Periodo.Name = "Periodo";
            this.Periodo.Size = new System.Drawing.Size(120, 21);
            this.Periodo.TabIndex = 27;
            this.Periodo.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Seleccionar Periodo";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Modulo_Notas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(635, 460);
            this.Controls.Add(this.Periodo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Calificacion);
            this.Controls.Add(this.Materia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Estudiante);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Modulo_Notas";
            this.Text = "Modulo_Notas";
            this.Load += new System.EventHandler(this.Modulo_Notas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Estudiante;
        private System.Windows.Forms.ComboBox Materia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Calificacion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.ComboBox Periodo;
        private System.Windows.Forms.Label label4;
    }
}