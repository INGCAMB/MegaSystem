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

namespace Inventario_4_Eliminar_Dato
{
    public partial class InvEliDat : Form
    {
        public InvEliDat()
        {
            InitializeComponent();
        }
        //para version access 2017+
        public string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\..\Hamburguesas.accdb";
        //para version access 2003
        //public string cadena = @"provider=Microsoft.JET.OLEDB.4.0;Data Source=..\..\..\..\Hamburguesas.mdb";

        public void eliminarinventario()
        {
            try
            {
                string consulta = "DELETE from Inventario where ID=" + textBox1.Text + ";";
                OleDbConnection conexion = new OleDbConnection(cadena);
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();
                MessageBox.Show("Dato eliminado");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al elimnar en la base de datos, Matriucla Repetida\n" + ex.Message);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eliminarinventario();
        }
    }
}
