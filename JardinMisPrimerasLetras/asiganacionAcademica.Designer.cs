﻿namespace JardinMisPrimerasLetras
{
    partial class asiganacionAcademica
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
            this.Salon = new System.Windows.Forms.ComboBox();
            this.Hora = new System.Windows.Forms.ComboBox();
            this.Dia = new System.Windows.Forms.ComboBox();
            this.Materia = new System.Windows.Forms.ComboBox();
            this.Grupo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Docente = new System.Windows.Forms.ComboBox();
            this.guardar = new System.Windows.Forms.Button();
            this.Observaciones = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Salon
            // 
            this.Salon.FormattingEnabled = true;
            this.Salon.Location = new System.Drawing.Point(563, 96);
            this.Salon.Margin = new System.Windows.Forms.Padding(1);
            this.Salon.Name = "Salon";
            this.Salon.Size = new System.Drawing.Size(105, 21);
            this.Salon.TabIndex = 2;
            this.Salon.SelectedIndexChanged += new System.EventHandler(this.Salon_SelectedIndexChanged);
            // 
            // Hora
            // 
            this.Hora.FormattingEnabled = true;
            this.Hora.Location = new System.Drawing.Point(296, 170);
            this.Hora.Margin = new System.Windows.Forms.Padding(1);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(105, 21);
            this.Hora.TabIndex = 3;
            // 
            // Dia
            // 
            this.Dia.FormattingEnabled = true;
            this.Dia.Location = new System.Drawing.Point(39, 170);
            this.Dia.Margin = new System.Windows.Forms.Padding(1);
            this.Dia.Name = "Dia";
            this.Dia.Size = new System.Drawing.Size(105, 21);
            this.Dia.TabIndex = 4;
            // 
            // Materia
            // 
            this.Materia.FormattingEnabled = true;
            this.Materia.Location = new System.Drawing.Point(296, 96);
            this.Materia.Margin = new System.Windows.Forms.Padding(1);
            this.Materia.Name = "Materia";
            this.Materia.Size = new System.Drawing.Size(105, 21);
            this.Materia.TabIndex = 5;
            this.Materia.SelectedIndexChanged += new System.EventHandler(this.Materia_SelectedIndexChanged);
            // 
            // Grupo
            // 
            this.Grupo.FormattingEnabled = true;
            this.Grupo.Location = new System.Drawing.Point(39, 96);
            this.Grupo.Margin = new System.Windows.Forms.Padding(1);
            this.Grupo.Name = "Grupo";
            this.Grupo.Size = new System.Drawing.Size(105, 21);
            this.Grupo.TabIndex = 6;
            this.Grupo.SelectedIndexChanged += new System.EventHandler(this.Grupo_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 147);
            this.label2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Seleccionar Dia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(561, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Seleccionar Salon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(293, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Seleccionar Materia";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 72);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Seleccionar Grupo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(293, 147);
            this.label6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Seleccionar Hora";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(556, 147);
            this.label7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Seleccionar Docente";
            // 
            // Docente
            // 
            this.Docente.FormattingEnabled = true;
            this.Docente.Location = new System.Drawing.Point(558, 170);
            this.Docente.Margin = new System.Windows.Forms.Padding(1);
            this.Docente.Name = "Docente";
            this.Docente.Size = new System.Drawing.Size(105, 21);
            this.Docente.TabIndex = 12;
            this.Docente.SelectedIndexChanged += new System.EventHandler(this.Docente_SelectedIndexChanged);
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(349, 340);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 61;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // Observaciones
            // 
            this.Observaciones.Location = new System.Drawing.Point(135, 297);
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Size = new System.Drawing.Size(477, 20);
            this.Observaciones.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(132, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 63;
            this.label8.Text = "Observaciones";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(39, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 42);
            this.button1.TabIndex = 64;
            this.button1.Text = "Administrar Usuarios";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // asiganacionAcademica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(759, 415);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Observaciones);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Docente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Grupo);
            this.Controls.Add(this.Materia);
            this.Controls.Add(this.Dia);
            this.Controls.Add(this.Hora);
            this.Controls.Add(this.Salon);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "asiganacionAcademica";
            this.Text = "Asiganacion Academica";
            this.Load += new System.EventHandler(this.asiganacionAcademica_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Salon;
        private System.Windows.Forms.ComboBox Hora;
        private System.Windows.Forms.ComboBox Dia;
        private System.Windows.Forms.ComboBox Materia;
        private System.Windows.Forms.ComboBox Grupo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Docente;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.TextBox Observaciones;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
    }
}