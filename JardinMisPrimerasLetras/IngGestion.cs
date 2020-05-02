﻿using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UsuarioControler;

namespace JardinMisPrimerasLetras
{
    public partial class IngGestion : Form
    {
        private loginControler controlador;
        Pagos pagos = new Pagos();

        public IngGestion()
        {
            InitializeComponent();
            this.controlador = new UsuarioControler.loginControler();

            //List<Grupo> response = this.controlador.ObtenerGestion;
            //response.Insert(0, new Gestion() { area = "", grados = "Seleccione" });
            //Grados.DataSource = response;
            //Grados.DisplayMember = "grupo";
            //Grados.ValueMember = "id_grupo";


            //List<Usuario> responseGeation = this.controlador.ObtenerDocentes();
            //comboBox3.DataSource = responseGeation;
            //comboBox3.DisplayMember = "primerNombre";
            //comboBox3.ValueMember = "identificacacion";


        }

        private void comboBoxGrupos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxGrados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxMateria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDocente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            string grados = Grados.Text;
            string grupos = Grupos.Text;
            string areas = comboArea.Text;
            string materias = comboMateria.Text;

            Gestion insertarGestion = new Gestion();
            insertarGestion.grados = grados;
            insertarGestion.grupo = grupos;
            insertarGestion.area = areas;
            insertarGestion.materia = materias;
            

            Respuesta<object> ingreso = this.controlador.insertarGestion(insertarGestion);
            MessageBox.Show("Datos guardados correctamente");

            //if (textBox1.Text != "A" || textBox1.Text != "B")
            //{
            //    MessageBox.Show("La Division del Grupo debe ser A o B!");
            //}
            //MessageBox.Show("Datos guardados correctamente");

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Gestion_Load(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void docenteToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void docenteToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void MDocente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void docenteToolStripButton_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.pagos.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

