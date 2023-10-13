using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//importar
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;//importar

namespace Universidad1
{
    class Conexion
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataTable dt;
        public Conexion()
        {
            try
            {
                conexion = new SqlConnection("Data Source=ANONYMOUS1V09\\OTRA;Initial Catalog=Universidad;Integrated Security=True");
                conexion.Open();
                //MessageBox.Show("Conexión Exitosa");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la conexión:" + ex.ToString());
            }
        }
        public void CargarTabla(DataGridView dgv)
        {
            try
            {
                da = new SqlDataAdapter("Select * from Estudiantes1", conexion);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo cargar la tabla de estudiantes:" + ex.ToString());
            }
        }
        public string Registrar(int Id, string Nombre, string Apellidos, string Carrera)
        {
            string resultado = "Registro Exitoso";
            try
            {
                // if (PersonaRegistrada(Id) == "Noencontrado")
                //{​​
                cmd = new SqlCommand("Insert into Estudiantes1(Id,Nombre,Apellidos,Carrera) values (" + Id + ",'" + Nombre + "','" + Apellidos + "','" + Carrera + "')", conexion);
                cmd.ExecuteNonQuery();
                //cmd.Clone();
                // }​​
            }
            catch (Exception ex)
            {
                resultado = "Error en el registro:" + ex.ToString();
            }
            return resultado;
        }
        public string PersonaRegistrada(int id)
        {
            // tipo del metodo
            int contador = 0;
            string res; // este
            try
            {
                cmd = new SqlCommand("Select * from Estudiantes1 where Id =" + id + "", conexion);
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    contador++;
                    //res = "encontrado";
                }
                dr.Close();



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la consulta:" + ex.ToString());
            }
            if (contador > 0)
            {
                res = "encontrado";
            }
            else
            {
                res = "Noencontrado";
            }
            //return contador;
            return res;
        }

        public void LlenarTexbox(int id, TextBox Nombre, TextBox Apellidos, ComboBox Carrera)
        {
            try
            {

                cmd = new SqlCommand("Select * from Estudiantes1 where Id=" + id + "", conexion);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    Nombre.Text = dr["Nombre"].ToString();
                    Apellidos.Text = dr["Apellidos"].ToString();
                    Carrera.Text = dr["Carrera"].ToString();
                }
                dr.Close();
            }
            catch (Exception ex)
            {
            MessageBox.Show("Error al cargar los datos:" + ex.ToString());
            }
        }

        public string Actualizar(int Id, string Nombre, string Apellidos, string Carrera)
        {

            string resultado = "Registro Actualizado";
            try
            {
                cmd = new SqlCommand("Update Estudiantes1 set Nombre='" + Nombre + "',Apellidos ='" + Apellidos + "',Carrera='" + Carrera + "' where Id=" + Id + "", conexion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                resultado = "Error en la actualización:" + ex.ToString();
            }

            return resultado;



        }
        public string Eliminar (int Id)
        {
            string resultado = "Registro eliminado";
            try
            {
                cmd = new SqlCommand("Delete from Estudiantes1 where Id=" + Id + "", conexion);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                resultado = "Error en la eliminacion:" + ex.ToString();
            }
            return resultado;
        }


    }
}
