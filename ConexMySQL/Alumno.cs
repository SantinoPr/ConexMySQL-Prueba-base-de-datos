using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace ConexMySQL
{
    internal class Alumno
    {
        public void MostrarAlumnos(DataGridView tablaAlumnos)
        {
            try
            {
                CConexion conex=new CConexion();
                string query= "select * from alumnos";
                tablaAlumnos.DataSource= null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query,conex.EstablecerConex());
                DataTable table=new DataTable();    
                adapter.Fill(table);
                tablaAlumnos.DataSource=table;
                conex.CerrarConexion();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("No es posible mostrar los datos, Error: "+ex.ToString());
            }
        }
        public void GuardarAlumnos(string nombre, string apellido)
        {
            try
            {
                CConexion conex = new CConexion();
                string query = "insert into alumnos(nombre,apellido)" + "values('" + nombre + "','" + apellido + "');";
                MySqlCommand myComand=new MySqlCommand(query,conex.EstablecerConex());
                MySqlDataReader reader=myComand.ExecuteReader();
                MessageBox.Show("Se guardo los registros con exito");
                while (reader.Read())
                {

                }
                conex.CerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("No es posible mostrar los datos, Error: " + ex.ToString());
            }
        }
        public void SeleccionarAlumnos(DataGridView tablaAlumnos,TextBox id,TextBox nombre, TextBox apellido)
        {
            try
            {
                id.Text = tablaAlumnos.CurrentRow.Cells[0].Value.ToString();
                nombre.Text=tablaAlumnos.CurrentRow.Cells[1].Value.ToString();
                apellido.Text=tablaAlumnos.CurrentRow.Cells[2].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puedo seleecion los datos, Error: " + ex.ToString());
            }
        }
        public void ModificarAlumnos(TextBox id, TextBox nombre, TextBox apellido)
        {
            try
            {
                CConexion conex = new CConexion();
                string query = "UPDATE Alumnos SET Nombre='" 
                    + nombre.Text+"',Apellido='"+apellido.Text+"'WHERE ID='"+id.Text+"';";
                MySqlCommand myComand = new MySqlCommand(query, conex.EstablecerConex());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se modifico los registros con exito");
                while (reader.Read())
                {

                }
                conex.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se actualizaron los registros de la base de datos, Error: " + ex.ToString());
            }
        }
        public void EliminarAlumnos(TextBox id)
        {
            try
            {
                CConexion conex = new CConexion();
                string query = "delete from Alumnos where id='" + id.Text + "';";                  
                MySqlCommand myComand = new MySqlCommand(query, conex.EstablecerConex());
                MySqlDataReader reader = myComand.ExecuteReader();
                MessageBox.Show("Se elimino el registro con exito");
                while (reader.Read())
                {

                }
                conex.CerrarConexion();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se elimnaron los registros de la base de datos, Error: " + ex.ToString());
            }
        }
    }
}
