using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;//importar
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;//importar

namespace Universidad1
{
    public partial class Alumnos : Form
    {
        Conexion con = new Conexion();
        public Alumnos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'universidadDataSet.Estudiantes1' table. You can move, or remove it, as needed.
            this.estudiantes1TableAdapter.Fill(this.universidadDataSet.Estudiantes1);
            
            Conexion con = new Conexion();
            con.CargarTabla(dgv_Estudiantes);
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
                int Id = Convert.ToInt32(txtId.Text);
                string Nombre = txtNombre.Text;
                string Apellidos = txtApellidos.Text;
                string Carrera = Convert.ToString(cmbCarrera.Text);
                if (con.PersonaRegistrada(Convert.ToInt32(txtId.Text)) == "Noencontrado")
                {
                MessageBox.Show(con.Registrar(Id, Nombre, Apellidos, Carrera));
                con.CargarTabla(dgv_Estudiantes);
                txtNombre.Text = "";
                txtApellidos.Text = "";
                cmbCarrera.Text = "";
                txtId.Text = "0";
                }
                else
                {
                    MessageBox.Show("Ya existe este ID");
                }
        }

        private void BtnEditar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(con.Actualizar(Convert.ToInt32(txtId.Text), txtNombre.Text, txtApellidos.Text, cmbCarrera.Text));
            con.CargarTabla(dgv_Estudiantes);
            txtNombre.Text = "";
            txtApellidos.Text = "";
            cmbCarrera.Text = "";
            txtId.Text = "0";
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtId.Text);
            if (con.PersonaRegistrada(id) == "Noencontrado")
            {
                txtNombre.Text = "";
                txtApellidos.Text = "";
                cmbCarrera.Text = "";

            }
            else if (con.PersonaRegistrada(Convert.ToInt32(txtId.Text)) == "encontrado")
            {

            con.LlenarTexbox(Convert.ToInt32(txtId.Text), txtNombre, txtApellidos, cmbCarrera);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(con.Eliminar(Convert.ToInt32(txtId.Text)));
            con.CargarTabla(dgv_Estudiantes);
            txtNombre.Text = "";
            txtApellidos.Text = "";
            cmbCarrera.Text = "";
            txtId.Text = "0";
        }
    }
}
