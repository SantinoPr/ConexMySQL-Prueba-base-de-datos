using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ConexMySQL
{
    internal class CConexion
    {
        MySqlConnection conex=new MySqlConnection();
        static string servidor = "localhost";
        static string bd = "Curso";
        static string puerto = "3306";
        static string usuario = "root";
        //static string apellido1= "root";
        static string contrasenia1="Chupaelperro";      
        
        string cadenaconexion = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + usuario + ";" + "Password=" + contrasenia1 + ";" + "database=" + bd + ";";

        //public CConexion(string nombre, string apellido, string contrasenia)
        //{
        //    nombre1 = nombre;
        //    apellido1= apellido;
        //    contrasenia1= contrasenia;  
        //}
        public MySqlConnection EstablecerConex()
        {
            try
            {
                conex.ConnectionString = cadenaconexion;
                conex.Open();
               // MessageBox.Show("Se conecto con exito a la base de datos");
            }
            catch(Exception e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos, Error: " + e.ToString());
            }
            return conex;
        }
        public void CerrarConexion()
        {
            conex.Close();
        }
    }
}
