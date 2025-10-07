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

namespace Inventario3_Registrar_Dato_Precio
{
    public partial class InvRegDatPre : Form
    {
        public InvRegDatPre()
        {
            InitializeComponent();
        }
        //para version access 2007+
        public string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\..\Hamburguesas.accdb";
        //para version access 2003
        //public string cadena = @"provider=Microsoft.JET.OLEDB.4.0;Data Source=..\..\..\..\Hamburguesas.mdb";

        public void insertarinventario()
        {
            try
            {
                //Consulta para insertar en la tabla inventario.
                string consulta = "insert into Inventario (Numeroproducto,Nombreproducto,Precioproducto) values (" + textBox1.Text + " ,\"" + textBox2.Text + "\",\"" + textBox3.Text + "\");";
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

                MessageBox.Show("Insertado");
            }
            //Guarda el error.
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar en la base de datos, Matriucla Repetida\n" + ex.Message);
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
            insertarinventario();
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
