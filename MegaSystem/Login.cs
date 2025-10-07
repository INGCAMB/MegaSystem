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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        //para version access 2017+
        public string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\..\Hamburguesas.accdb";
        //para version access 2003
        //public string cadena = @"PROVIDER=MICROSOFT.JET.OLEDB.4.0; data source=..\..\..\..\Hamburguesas.mdb";
        public void consultarempleados()
        {
            try
            {
                //Consulta la tabla empleados para acceder algun empleado con su puro nombre y contraseña.
                string consulta = "SELECT Nombre, Contraseña FROM Empleados WHERE Nombre='" + textBox1.Text + "' AND Contraseña='" + textBox2.Text + "';";
                //Base de datos a conectar(preparar).
                OleDbConnection conexion = new OleDbConnection(cadena);
                //Consulta,conexion(prepara).
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                //Abre conexion.
                conexion.Open();
                //Aqui contiene los datos.
                OleDbDataReader leer = comando.ExecuteReader();
                //Boolean: Utiliza para contener valores de dos estados como verdadero/falso.
                //HasRows Obtiene un valor que indica si el objeto DataReader contiene una o varias filas.
                Boolean reg = leer.HasRows;
                //Condicion del registro si existe.
                if (reg)
                {
                    //Mensaje mas su nombre, y manda directamente al menu de empleado.
                    MessageBox.Show("Aceptado, bienvenido " + textBox1.Text);
                    MegaSystem.Menu_Principal_Empleados programa = new MegaSystem.Menu_Principal_Empleados();
                    //Cierra el Login de empleados.
                    this.Hide();
                    //Abre el menu.
                    programa.Show();
                }
                //Condicion si el registro no existe.
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrecto");
                    return;
                }
                //Cierra conexion.
                conexion.Close();
            }
            //Guarda el error.
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultarempleados();
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
                consultarempleados();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Sale del programa.
            MessageBox.Show("Cerrar");
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Pase de formulario.
            LoginGerente login = new LoginGerente();
            this.Hide();
            login.Show();
        }
    }
}
