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

namespace MegaSystem
{
    public partial class PordModEli : Form
    {
        public PordModEli()
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
                //Modifica informacion de los Productos.
                string consulta = "UPDATE Productos set Nombre=\"" + textBox2.Text + "\" where ID=\"" + textBox1.Text + "\";";
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
        public void modificarprecio()
        {
            try
            {
                //Modifica informacion de los Productos.
                string consulta = "UPDATE Productos set Precio=\"" + textBox3.Text + "\" where ID=\"" + textBox1.Text + "\";";
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
        public void modificardescripcion()
        {
            try
            {
                //Modifica informacion de los Productos.
                string consulta = "UPDATE Productos set Descripcion=\"" + textBox4.Text + "\" where ID=\"" + textBox1.Text + "\";";
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
                //Eliminar informacion del Producto con su puro ID.
                string consulta = "DELETE from Productos where ID=\"" + textBox1.Text + "\";";
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
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eliminar();
            limpiar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            modificarnombre();
            modificarprecio();
            modificardescripcion();
            limpiar();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar==13)
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox4.Focus();
            }
        }
    }
}
