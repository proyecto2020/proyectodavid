﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace JardinMisPrimerasLetras
{
    public partial class Matriculas : Form
    {
        private UsuarioControler.loginControler controlador;
        IngGestion gestion = new IngGestion();
        ModPagos pagos = new ModPagos();
        
        public Matriculas()
        {
            InitializeComponent();
            this.controlador = new UsuarioControler.loginControler();
            List<Seleccionar_Grupo> listarGrupo = this.controlador.ListarGrupos();
            listarGrupo.Insert(0, new Seleccionar_Grupo() { idGrupo = 0, Grupo = "Seleccione" });
            Grupo.DataSource = listarGrupo;
            Grupo.DisplayMember = "Grupo";
            Grupo.ValueMember = "idGrupo";
        }

        private void Matriculas_Load(object sender, EventArgs e)
        {

        }

        private void Nombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void Acudiente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Apellidos_TextChanged(object sender, EventArgs e)
        {

        }

        private void ocupacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Cedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void guardar_Click(object sender, EventArgs e)
        {
            string nombres = Nombres.Text;
            string apellidos = Apellidos.Text;
            string acudiente = Acudiente.Text;
            string direccion = Direccion.Text;
            string email = Correo.Text;
            string cedula = Cedula.Text;
            string telefeno = Telefono.Text;
            string observaciones = textBox1.Text;
            string ocupacionAcudiente = ocupacion.Text;
            string fechaNacimiento = Nacimiento.Text;
            string nombreApellido = String.Concat(nombres + " " + apellidos);

            Alumnos insertarAlumno = new Alumnos();
            insertarAlumno.nombres = nombres;
            insertarAlumno.apellidos = apellidos;
            insertarAlumno.acudiente = acudiente;
            insertarAlumno.direccion = direccion;
            insertarAlumno.correo = email;
            insertarAlumno.identificacion = cedula;
            insertarAlumno.telefono = telefeno;
            insertarAlumno.observacion = observaciones;
            insertarAlumno.ocupacion = ocupacionAcudiente;
            insertarAlumno.fechaNacimiento = fechaNacimiento;
            insertarAlumno.nombreApellido = nombreApellido;

            Respuesta<object> ingreso = this.controlador.insertarAlumno(insertarAlumno);
            MessageBox.Show("Datos guardados correctamente");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.pagos.Show();
        }

        private void Grupo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
