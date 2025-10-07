using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Empleado_3_Eliminar_Modificar_Dato
{
    public partial class EmpModEli : Form
    {
        public EmpModEli()
        {
            InitializeComponent();
        }

        //para version access 2017+
        public string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\..\Hamburguesas.accdb";
        //para version access 2003
        //public string cadena = @"provider=Microsoft.JET.OLEDB.4.0;Data Source=..\..\..\..\Hamburguesas.mdb";

        public void modificarnombre()
        {
            try
            {
                //Modifica informacion de los empleados.
                string consulta = "UPDATE Empleados set Nombre=\"" + textBox2.Text + "\" where IDempleado=\"" + textBox1.Text + "\"; ";
                //Base de datos a conectar(preparar).
                OleDbConnection conexion = new OleDbConnection(cadena);
                //Consulta,conexion(prepara).
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                //Abre conexion.
                conexion.Open();
                //Ejecutar comando.
                comando.ExecuteNonQuery();
                //Cierra conexion.
                conexion.Close();
            }
            //Guarda el error.
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar en la base de datos, Matriucla Repetida\n" + ex.Message);
                return;
            }
        }

        public void modificaredad()
        {
            try
            {
                //Modifica informacion de los empleados.
                string consulta = "UPDATE Empleados set Edad=\"" + textBox3.Text + "\" where IDempleado=\"" + textBox1.Text + "\"; ";
                //Base de datos a conectar(preparar).
                OleDbConnection conexion = new OleDbConnection(cadena);
                //Consulta,conexion(prepara).
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                //Abre conexion.
                conexion.Open();
                //Ejecutar comando.
                comando.ExecuteNonQuery();
                //Cierra conexion.
                conexion.Close();
                MessageBox.Show("Dato modificado");
            }
            //Guarda el error.
            catch (Exception ex)
            {
                MessageBox.Show("Error al modificar en la base de datos, Matriucla Repetida\n" + ex.Message);
                return;
            }
        }

        public void eliminar()
        {
            try
            {
                //Eliminar informacion del empleado con su puro ID.
                string consulta = "DELETE from Empleados where IDempleado=\"" + textBox1.Text + "\"; ";
                //Base de datos a conectar(preparar).
                OleDbConnection conexion = new OleDbConnection(cadena);
                //Consulta,conexion(prepara).
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                //Abre conexion.
                conexion.Open();
                //Ejecutar comando.
                comando.ExecuteNonQuery();
                //Cierra conexion.
                conexion.Close();
                MessageBox.Show("Dato eliminado");
            }
            //Guarda el error.
            catch (Exception ex)
            {
                MessageBox.Show("Error al elimnar en la base de datos, Matriucla Repetida\n" + ex.Message);
                return;
            }
        }
        public void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eliminar();
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modificarnombre();
            modificaredad();
            limpiar();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox3.Focus();
            }
        }
    }
}
