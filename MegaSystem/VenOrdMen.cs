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

namespace Ventas2_Orden_Menu
{
    public partial class VenOrdMen : Form
    {
        public VenOrdMen()
        {
            InitializeComponent();
        }
        //para version access 2017+
        public string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\..\Hamburguesas.accdb";
        //para version access 2003
        //public string cadena = @"provider=Microsoft.JET.OLEDB.4.0;Data Source=..\..\..\..\Hamburguesas.mdb";
        public double suma = 0;

        public void añadirproductoalaorden()
        {
            try
            {
                //Consulta para insertar a la orden.
                string consulta = "insert into Orden (Nombre,Precio) values (\""+ textBox1.Text + "\",\"" + textBox2.Text + "\");";
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
                MessageBox.Show("Error al insertar en la base de datos, Matriucla Repetida\n" + ex.Message);
                return;
            }
        }

        public void consultarorden()
        {
            try
            {
                //Consulta para ver todos los registros de la orden.
                string consulta = "select * from Orden";
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

        public void consultarproducto()
        {
            try
            {
                //Consulta para ver los registros de campos nombre, precio y descripcion de la tabla Productos.
                string consulta = "select Nombre, Precio, Descripcion from Productos";
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
                dataGridView2.DataSource = datostabla;
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

        public void eliminaunproducto()
        {
            try
            {
                //Consulta para eliminar algun registro de la orden.
                string consulta = "DELETE from Orden where ID=" + textBox3.Text +";";
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
                MessageBox.Show("Error al elimnar en la base de datos, Matriucla Repetida\n" + ex.Message);
                return;
            }
        }

        public void añadirventa()
        {
            try
            {
                //Consulta para insertar la fecha, el numero de orden y el total en la tabla ventas.
                string consulta = "insert into Ventas (Total,Numerorden,Fecha) values (\"" + textBox4.Text + "\",\"" + textBox5.Text + "\"," + textBox6.Text + ");";
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
                MessageBox.Show("Error al insertar en la base de datos, Matriucla Repetida\n" + ex.Message);
                return;
            }
        }

        public void reiniciarorden()
        {
            //Actualizar orden(eliminados datos viejos y se agregan puros numeros).
            try
            {
                //Consulta para eliminar toda la tabla orden y asi poder actualizar para realizar otras ordenes.
                string consulta = "DELETE from Orden";
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
                MessageBox.Show("Error al elimnar en la base de datos, Matriucla Repetida\n" + ex.Message);
                return;
            }
        }

        public void consultarsuma()
        {
            //Método con el que recorreremos todas las filas de nuestro Datagridview.
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //Aquí seleccionaremos la columna que contiene los datos numericos.
                //En esta parte, las celdas de Precio se van acumulando en el acumulador suma. 
                suma += Convert.ToDouble(row.Cells["Precio"].Value);
            }
            //Asignamos el resultado a el texto de nuestra textBox.
            //convertimos double a String.
            textBox4.Text = Convert.ToString(suma);
        }

        public void limpiaralañadirproducto()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        public void limpiareliminarproducto()
        {
            textBox3.Text = "";
        }

        public void limpiarventa()
        {
            textBox4.Text = "0";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        public void hablitar()
        {
            button3.Enabled = true;
        }

        public void deshabilitar()
        {
            button3.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            añadirventa();
            MessageBox.Show("Venta realizada");
            limpiareliminarproducto();
            limpiarventa();
            reiniciarorden();
            hablitar();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            añadirproductoalaorden();
            consultarorden();
            limpiaralañadirproducto();
            textBox3.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            consultarsuma();
            textBox5.Focus();
            deshabilitar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            eliminaunproducto();
            consultarorden();
            limpiareliminarproducto();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            consultarproducto();
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

        private void button6_Click(object sender, EventArgs e)
        {
            reiniciarorden();
            MessageBox.Show("Venta cancelada");
            this.Hide();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Evento de click en la dataGridView donde pasa registros de la tabla productos a cajas de texto haciendo doble click.
            textBox1.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            textBox2.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                textBox6.Focus();
            }
        }
    }
}
