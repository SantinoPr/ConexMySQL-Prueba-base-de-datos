using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConexMySQL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Alumno alumnos=new Alumno();
            alumnos.MostrarAlumnos(dataGridView1);
        }
        CConexion conexion;
        Alumno alumnos;
        private void button1_Click(object sender, EventArgs e)
        {
            alumnos=new Alumno();
            alumnos.GuardarAlumnos(txtNombre.Text.ToString(), txtApellido.Text.ToString());
            alumnos.MostrarAlumnos(dataGridView1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Alumno alumnos = new Alumno();
            alumnos.SeleccionarAlumnos(dataGridView1, txtid, txtNombre, txtApellido);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            alumnos = new Alumno();
            alumnos.ModificarAlumnos(txtid, txtNombre, txtApellido);
            alumnos.MostrarAlumnos(dataGridView1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            alumnos = new Alumno();
            alumnos.EliminarAlumnos(txtid);
            alumnos.MostrarAlumnos(dataGridView1);
        }
    }
}
