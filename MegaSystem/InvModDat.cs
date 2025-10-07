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
    public partial class InvModDat : Form
    {
        public InvModDat()
        {
            InitializeComponent();
        }
        //para version access 2017+
        public string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\..\Hamburguesas.accdb";
        //para version access 2003
        //public string cadena = @"provider=Microsoft.JET.OLEDB.4.0;Data Source=..\..\..\..\Hamburguesas.mdb";

        public void modificarnombreproducto()
        {
            try
            {
                //Modifica informacion del Inventario.
                string consulta = "UPDATE Inventario set Nombreproducto=\"" + textBox2.Text + "\" where Numeroproducto=" + textBox1.Text + ";";
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

        public void modificarprecioproducto()
        {
            try
            {
                //Modifica informacion del Inventario.
                string consulta = "UPDATE Inventario set Precioproducto=\"" + textBox3.Text + "\" where Numeroproducto=" + textBox1.Text + ";";
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

        public void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Modifica informacion del Inventario.
            modificarnombreproducto();
            modificarprecioproducto();
            limpiar();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
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
