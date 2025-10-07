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

namespace Ventas1_Mostras_ventas_Diarias
{
    public partial class VenConDia : Form
    {
        public VenConDia()
        {
            InitializeComponent();
        }
        //para version access 2017+
        public string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\..\Hamburguesas.accdb";
        //para version access 2003
        //public string cadena = @"provider=Microsoft.JET.OLEDB.4.0;Data Source=..\..\..\..\Hamburguesas.mdb";

        public void consultarventas()
        {
            try
            {
                string consulta = "select * from Ventas";
                OleDbConnection conexion = new OleDbConnection(cadena);
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                OleDbDataAdapter adaptador = new OleDbDataAdapter(comando);
                conexion.Open();
                DataTable datostabla = new DataTable();
                adaptador.Fill(datostabla);
                dataGridView1.DataSource = datostabla;
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar en la base de datos\n" + ex.Message);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultarventas();
        }
    }
}
