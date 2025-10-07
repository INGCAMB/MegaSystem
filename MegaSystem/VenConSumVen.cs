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

namespace Ventas5_Consultar_Suma_Ventas
{
    public partial class VenConSumVen : Form
    {
        public VenConSumVen()
        {
            InitializeComponent();
        }
        //para version access 2017+
        public string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\..\Hamburguesas.accdb";
        //para version access 2003
        //public string cadena = @"provider=Microsoft.JET.OLEDB.4.0;Data Source=..\..\..\..\Hamburguesas.mdb";

        public void consultarsumaventas()
        {
            try
            {
                //Se ultiliza una consulta agrupada(suma).
                //Consulta la suma de ventas diarias con la condicion de que solo se sumen las de una fecha en especifico de la tabla Ventas .
                //As SumaDeVentas: Nombre de la tabla temporal.
                string consulta = "SELECT Sum(Total)AS SumaDeVentas FROM Ventas where Fecha=\"" + textBox1.Text + "\";";
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

        public void limpiar()
        {
            textBox1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultarsumaventas();
            limpiar();
        }
    }
}
