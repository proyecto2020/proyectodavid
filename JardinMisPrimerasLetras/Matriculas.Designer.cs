using System.Windows.Forms;

namespace JardinMisPrimerasLetras
{
    partial class Matriculas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Matriculas));
            this.Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.text = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Correo = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Cedula = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Nombres = new System.Windows.Forms.TextBox();
            this.Acudiente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ocupacion = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Nacimiento
            // 
            this.Nacimiento.Location = new System.Drawing.Point(532, 111);
            this.Nacimiento.Name = "Nacimiento";
            this.Nacimiento.Size = new System.Drawing.Size(200, 20);
            this.Nacimiento.TabIndex = 53;
            this.Nacimiento.ValueChanged += new System.EventHandler(this.Nacimiento_ValueChanged);
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(529, 86);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(108, 13);
            this.text.TabIndex = 52;
            this.text.Text = "Fecha de Nacimiento";
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(321, 184);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(121, 20);
            this.Direccion.TabIndex = 51;
            this.Direccion.TextChanged += new System.EventHandler(this.Direccion_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(318, 160);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 13);
            this.label16.TabIndex = 50;
            this.label16.Text = "Direccion";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(81, 230);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Correo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(321, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 48;
            this.label7.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(529, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "CC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(318, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 46;
            this.label5.Text = "Apellidos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Nombres";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 44;
            this.label3.Text = "Acudiente";
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(84, 253);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(121, 20);
            this.Correo.TabIndex = 43;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(324, 253);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(121, 20);
            this.Telefono.TabIndex = 42;
            this.Telefono.TextChanged += new System.EventHandler(this.Telefono_TextChanged);
            // 
            // Cedula
            // 
            this.Cedula.Location = new System.Drawing.Point(532, 184);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(121, 20);
            this.Cedula.TabIndex = 41;
            this.Cedula.TextChanged += new System.EventHandler(this.Cedula_TextChanged);
            // 
            // Apellidos
            // 
            this.Apellidos.Location = new System.Drawing.Point(321, 111);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(121, 20);
            this.Apellidos.TabIndex = 40;
            this.Apellidos.TextChanged += new System.EventHandler(this.Apellidos_TextChanged);
            // 
            // Nombres
            // 
            this.Nombres.Location = new System.Drawing.Point(84, 111);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(121, 20);
            this.Nombres.TabIndex = 39;
            this.Nombres.TextChanged += new System.EventHandler(this.Nombres_TextChanged);
            // 
            // Acudiente
            // 
            this.Acudiente.Location = new System.Drawing.Point(84, 184);
            this.Acudiente.Name = "Acudiente";
            this.Acudiente.Size = new System.Drawing.Size(121, 20);
            this.Acudiente.TabIndex = 38;
            this.Acudiente.TextChanged += new System.EventHandler(this.Acudiente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(529, 230);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "Ocupaciòn";
            // 
            // ocupacion
            // 
            this.ocupacion.Location = new System.Drawing.Point(532, 253);
            this.ocupacion.Name = "ocupacion";
            this.ocupacion.Size = new System.Drawing.Size(121, 20);
            this.ocupacion.TabIndex = 57;
            this.ocupacion.TextChanged += new System.EventHandler(this.ocupacion_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(239, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Observaciones";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(242, 332);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(411, 20);
            this.textBox1.TabIndex = 59;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(354, 388);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 60;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 61;
            this.pictureBox1.TabStop = false;
            // 
            // Matriculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(839, 420);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ocupacion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Nacimiento);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Cedula);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.Acudiente);
            this.Name = "Matriculas";
            this.Text = "Matriculas";
            this.Load += new System.EventHandler(this.Matriculas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker Nacimiento;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox Cedula;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.TextBox Nombres;
        private System.Windows.Forms.TextBox Acudiente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ocupacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}