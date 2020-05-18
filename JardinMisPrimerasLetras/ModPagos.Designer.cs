namespace JardinMisPrimerasLetras
{
    partial class ModPagos
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
            this.Estudiante = new System.Windows.Forms.ComboBox();
            this.ValorAbono = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Observaciones = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Estudiante
            // 
            this.Estudiante.FormattingEnabled = true;
            this.Estudiante.Location = new System.Drawing.Point(176, 97);
            this.Estudiante.Name = "Estudiante";
            this.Estudiante.Size = new System.Drawing.Size(215, 21);
            this.Estudiante.TabIndex = 0;
            this.Estudiante.ValueMember = "primerApellido";
            this.Estudiante.SelectedIndexChanged += new System.EventHandler(this.Estudiante_SelectedIndexChanged);
            // 
            // ValorAbono
            // 
            this.ValorAbono.Location = new System.Drawing.Point(187, 232);
            this.ValorAbono.Name = "ValorAbono";
            this.ValorAbono.Size = new System.Drawing.Size(88, 20);
            this.ValorAbono.TabIndex = 10;
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(548, 232);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(88, 20);
            this.Total.TabIndex = 12;
            this.Total.TextChanged += new System.EventHandler(this.Total_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Seleccionar Estudiante";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(201, 199);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 23;
            this.label11.Text = "Valor Abono";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(555, 199);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 25;
            this.label13.Text = "Total a Pagar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1770, 1128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 10);
            this.button1.TabIndex = 38;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1559, 1114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 39;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(45, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 20);
            this.label15.TabIndex = 41;
            this.label15.Text = "Pagos";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(378, 413);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 46;
            this.button3.Text = "Guardar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Observaciones
            // 
            this.Observaciones.Location = new System.Drawing.Point(159, 352);
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Size = new System.Drawing.Size(477, 20);
            this.Observaciones.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Observaciones";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(36, 452);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(104, 50);
            this.button4.TabIndex = 49;
            this.button4.Text = "MATRICULAS";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ModPagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(783, 527);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Observaciones);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.ValorAbono);
            this.Controls.Add(this.Estudiante);
            this.Name = "ModPagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.ModPagos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Estudiante;
        private System.Windows.Forms.TextBox ValorAbono;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Observaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button4;
    }
}