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

namespace Inventario_1_Capturar_Dato
{
    public partial class InvCapDat : Form
    {
        public InvCapDat()
        {
            InitializeComponent();
        }
        //para version access 2007+
        public string cadena = @"provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\..\Hamburguesas.accdb";
        //para version access 2003
        //public string cadena = @"provider=Microsoft.JET.OLEDB.4.0;Data Source=..\..\..\..\Hamburguesas.mdb";

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar==13)
            {
                textBox2.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertarproveedor();
            consultar();
            limpiar();
        }

        public void limpiar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        public void insertarproveedor()
        {
            try
            {
                //Consulta para insertar Proveedores poniendo producto y proveedor.
                string consulta = "insert into Proveedores (Producto,Proveedor) values (\"" + textBox1.Text + "\",\"" + textBox2.Text + "\");";
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
        public void consultar()
        {
            try
            {
                //Consulta para ver todos los registros de Proveedores.
                string consulta = "select * from Proveedores";
                //Base de datos a conectar(preparar).
                OleDbConnection conexion = new OleDbConnection(cadena);
                //Consulta,conexion(prepara).
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                //Adaptador de comando para la consulta.
                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                //Abre conexion.
                conexion.Open();
                //Tabla temporal.
                DataTable datostabla = new DataTable();
                //Adaptador, llena tabla temporal.
                adaptador.Fill(datostabla);
                //Pasa a dataGridView(Muestra).
                dataGridView1.DataSource = datostabla;
                //Cierra conexion.
                conexion.Close();
            }
            //Guarda el error.
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar en la base de datos\n" + ex.Message);
                return;
            }
        }
    }
}
