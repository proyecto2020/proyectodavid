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
            this.Grupo = new System.Windows.Forms.ComboBox();
            this.gruposBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Grado = new System.Windows.Forms.ComboBox();
            this.gradosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Acudiente = new System.Windows.Forms.TextBox();
            this.Nombres = new System.Windows.Forms.TextBox();
            this.Apellidos = new System.Windows.Forms.TextBox();
            this.Cedula = new System.Windows.Forms.TextBox();
            this.Telefono = new System.Windows.Forms.TextBox();
            this.Correo = new System.Windows.Forms.TextBox();
            this.ValorAbono = new System.Windows.Forms.TextBox();
            this.Saldo = new System.Windows.Forms.TextBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.Fecha = new System.Windows.Forms.DateTimePicker();
            this.Observaciones = new System.Windows.Forms.ListBox();
            this.Abono = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.Direccion = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.Label();
            this.Nacimiento = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Grupo
            // 
            this.Grupo.DataSource = this.gruposBindingSource;
            this.Grupo.DisplayMember = "Descripcion";
            this.Grupo.FormattingEnabled = true;
            this.Grupo.Location = new System.Drawing.Point(516, 100);
            this.Grupo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Grupo.Name = "Grupo";
            this.Grupo.Size = new System.Drawing.Size(375, 45);
            this.Grupo.TabIndex = 0;
            // 
            // gruposBindingSource
            // 
            this.gruposBindingSource.DataMember = "Grupos";
            // 
            // Grado
            // 
            this.Grado.DataSource = this.gradosBindingSource;
            this.Grado.DisplayMember = "Nom_Grados";
            this.Grado.FormattingEnabled = true;
            this.Grado.Location = new System.Drawing.Point(1384, 100);
            this.Grado.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Grado.Name = "Grado";
            this.Grado.Size = new System.Drawing.Size(375, 45);
            this.Grado.TabIndex = 1;
            // 
            // gradosBindingSource
            // 
            this.gradosBindingSource.DataMember = "Grados";
            // 
            // Acudiente
            // 
            this.Acudiente.Location = new System.Drawing.Point(184, 515);
            this.Acudiente.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Acudiente.Name = "Acudiente";
            this.Acudiente.Size = new System.Drawing.Size(375, 44);
            this.Acudiente.TabIndex = 2;
            // 
            // Nombres
            // 
            this.Nombres.Location = new System.Drawing.Point(184, 307);
            this.Nombres.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Nombres.Name = "Nombres";
            this.Nombres.Size = new System.Drawing.Size(375, 44);
            this.Nombres.TabIndex = 3;
            // 
            // Apellidos
            // 
            this.Apellidos.Location = new System.Drawing.Point(934, 307);
            this.Apellidos.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Size = new System.Drawing.Size(375, 44);
            this.Apellidos.TabIndex = 4;
            // 
            // Cedula
            // 
            this.Cedula.Location = new System.Drawing.Point(1602, 515);
            this.Cedula.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Cedula.Name = "Cedula";
            this.Cedula.Size = new System.Drawing.Size(375, 44);
            this.Cedula.TabIndex = 5;
            // 
            // Telefono
            // 
            this.Telefono.Location = new System.Drawing.Point(944, 712);
            this.Telefono.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Telefono.Name = "Telefono";
            this.Telefono.Size = new System.Drawing.Size(375, 44);
            this.Telefono.TabIndex = 6;
            // 
            // Correo
            // 
            this.Correo.Location = new System.Drawing.Point(184, 712);
            this.Correo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Correo.Name = "Correo";
            this.Correo.Size = new System.Drawing.Size(375, 44);
            this.Correo.TabIndex = 7;
            // 
            // ValorAbono
            // 
            this.ValorAbono.Location = new System.Drawing.Point(776, 945);
            this.ValorAbono.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ValorAbono.Name = "ValorAbono";
            this.ValorAbono.Size = new System.Drawing.Size(270, 44);
            this.ValorAbono.TabIndex = 10;
            this.ValorAbono.Text = "$";
            // 
            // Saldo
            // 
            this.Saldo.Location = new System.Drawing.Point(1428, 945);
            this.Saldo.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Saldo.Name = "Saldo";
            this.Saldo.Size = new System.Drawing.Size(270, 44);
            this.Saldo.TabIndex = 11;
            this.Saldo.Text = "$";
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(2065, 945);
            this.Total.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(270, 44);
            this.Total.TabIndex = 12;
            this.Total.Text = "$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(507, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 37);
            this.label1.TabIndex = 13;
            this.label1.Text = "Grupo";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1374, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 37);
            this.label2.TabIndex = 14;
            this.label2.Text = "Grado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 447);
            this.label3.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 37);
            this.label3.TabIndex = 15;
            this.label3.Text = "Acudiente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(174, 236);
            this.label4.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 37);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nombres";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(925, 236);
            this.label5.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 37);
            this.label5.TabIndex = 17;
            this.label5.Text = "Apellidos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1593, 447);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 37);
            this.label6.TabIndex = 18;
            this.label6.Text = "CC";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(934, 646);
            this.label7.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 37);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telefono";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(174, 646);
            this.label8.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 37);
            this.label8.TabIndex = 20;
            this.label8.Text = "Correo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1593, 646);
            this.label9.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(234, 37);
            this.label9.TabIndex = 21;
            this.label9.Text = "Fecha de Pago";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(260, 874);
            this.label10.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 37);
            this.label10.TabIndex = 22;
            this.label10.Text = "Abono";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(766, 874);
            this.label11.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 37);
            this.label11.TabIndex = 23;
            this.label11.Text = "Valor Abono";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1419, 885);
            this.label12.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(250, 37);
            this.label12.TabIndex = 24;
            this.label12.Text = "Saldo Pendiente";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2055, 885);
            this.label13.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(211, 37);
            this.label13.TabIndex = 25;
            this.label13.Text = "Total a Pagar";
            // 
            // Fecha
            // 
            this.Fecha.Location = new System.Drawing.Point(1602, 712);
            this.Fecha.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Fecha.Name = "Fecha";
            this.Fecha.Size = new System.Drawing.Size(625, 44);
            this.Fecha.TabIndex = 27;
            // 
            // Observaciones
            // 
            this.Observaciones.FormattingEnabled = true;
            this.Observaciones.ItemHeight = 37;
            this.Observaciones.Location = new System.Drawing.Point(576, 1050);
            this.Observaciones.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Observaciones.Name = "Observaciones";
            this.Observaciones.Size = new System.Drawing.Size(618, 189);
            this.Observaciones.TabIndex = 29;
            // 
            // Abono
            // 
            this.Abono.FormattingEnabled = true;
            this.Abono.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.Abono.Location = new System.Drawing.Point(269, 945);
            this.Abono.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Abono.Name = "Abono";
            this.Abono.Size = new System.Drawing.Size(191, 45);
            this.Abono.TabIndex = 30;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(263, 1050);
            this.label14.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(229, 37);
            this.label14.TabIndex = 31;
            this.label14.Text = "Observaciones";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(925, 447);
            this.label16.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 37);
            this.label16.TabIndex = 34;
            this.label16.Text = "Direccion";
            // 
            // Direccion
            // 
            this.Direccion.Location = new System.Drawing.Point(934, 515);
            this.Direccion.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Direccion.Name = "Direccion";
            this.Direccion.Size = new System.Drawing.Size(375, 44);
            this.Direccion.TabIndex = 35;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(1593, 236);
            this.text.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(320, 37);
            this.text.TabIndex = 36;
            this.text.Text = "Fecha de Nacimiento";
            // 
            // Nacimiento
            // 
            this.Nacimiento.Location = new System.Drawing.Point(1602, 307);
            this.Nacimiento.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Nacimiento.Name = "Nacimiento";
            this.Nacimiento.Size = new System.Drawing.Size(625, 44);
            this.Nacimiento.TabIndex = 37;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1767, 1126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 38;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Pagos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(2533, 1281);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Nacimiento);
            this.Controls.Add(this.text);
            this.Controls.Add(this.Direccion);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Abono);
            this.Controls.Add(this.Observaciones);
            this.Controls.Add(this.Fecha);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.Saldo);
            this.Controls.Add(this.ValorAbono);
            this.Controls.Add(this.Correo);
            this.Controls.Add(this.Telefono);
            this.Controls.Add(this.Cedula);
            this.Controls.Add(this.Apellidos);
            this.Controls.Add(this.Nombres);
            this.Controls.Add(this.Acudiente);
            this.Controls.Add(this.Grado);
            this.Controls.Add(this.Grupo);
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Pagos";
            this.Text = "Pagos";
            this.Load += new System.EventHandler(this.Pagos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gruposBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gradosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Grupo;
        private System.Windows.Forms.ComboBox Grado;
        private System.Windows.Forms.TextBox Acudiente;
        private System.Windows.Forms.TextBox Nombres;
        private System.Windows.Forms.TextBox Apellidos;
        private System.Windows.Forms.TextBox Cedula;
        private System.Windows.Forms.TextBox Telefono;
        private System.Windows.Forms.TextBox Correo;
        private System.Windows.Forms.TextBox ValorAbono;
        private System.Windows.Forms.TextBox Saldo;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker Fecha;
        private System.Windows.Forms.ListBox Observaciones;
        private System.Windows.Forms.ComboBox Abono;
        private System.Windows.Forms.Label label14;
        //private LetrasDataSetGrupo letrasDataSetGrupo;
        private System.Windows.Forms.BindingSource gruposBindingSource;
        //private LetrasDataSetGrupoTableAdapters.GruposTableAdapter gruposTableAdapter;
        //private LetrasDataSetGrado letrasDataSetGrado;
        private System.Windows.Forms.BindingSource gradosBindingSource;
        //private LetrasDataSetGradoTableAdapters.GradosTableAdapter gradosTableAdapter;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox Direccion;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.DateTimePicker Nacimiento;
        private System.Windows.Forms.Button button1;
    }
}