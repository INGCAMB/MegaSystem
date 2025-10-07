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
    public partial class LoginGerente : Form
    {
        public LoginGerente()
        {
            InitializeComponent();
        }
        //para version access 2017+
        public string cadena = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=..\..\..\..\Hamburguesas.accdb";
        //para version access 2003
        //public string cadena = @"PROVIDER=MICROSOFT.JET.OLEDB.4.0; data source=..\..\..\..\Hamburguesas.mdb";
        public void consultargerente()
        {
            try
            {
                //Consulta la tabla Supervisor para acceder al gerente con su puro nombre y contraseña.
                string consulta = "SELECT Nombre, Contraseña FROM Supervisor WHERE Nombre='" + textBox1.Text + "' AND Contraseña='" + textBox2.Text + "';";
                //Base de datos a conectar(preparar).
                OleDbConnection conexion = new OleDbConnection(cadena);
                //Consulta,conexion(prepara).
                OleDbCommand comando = new OleDbCommand(consulta, conexion);
                //Abre conexion.
                conexion.Open();
                //Aqui se tiene los datos.
                OleDbDataReader leer = comando.ExecuteReader();
                //Boolean: Utiliza para contener valores de dos estados como verdadero/falso.
                //HasRows Obtiene un valor que indica si el objeto DataReader contiene una o varias filas.
                Boolean reg = leer.HasRows;
                //Condicion del registro si existe.
                if (reg)
                {
                    //Mensaje mas su nombre, y manda directamente al menu de gerente.
                    MessageBox.Show("Aceptado, bienvenido " + textBox1.Text);
                    MegaSystem.Menu_Principal programa = new MegaSystem.Menu_Principal();
                    //Cierra el Login del gerente.
                    this.Hide();
                    //Abre el menu
                    programa.Show();
                }
                //Condicion si el registro no existe.
                else
                {
                    MessageBox.Show("Usuario i/o Contraseña incorrecto");
                    return;
                }
                conexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error\n" + ex.Message);
                return;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            consultargerente();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Login regresar = new Login();
            this.Hide();
            regresar.Show();
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
                consultargerente();
            }
        }
    }
}
