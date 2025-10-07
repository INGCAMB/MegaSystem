using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaSystem
{
    public partial class Menu_Principal_Empleados : Form
    {
        public Menu_Principal_Empleados()
        {
            InitializeComponent();
        }

        //Todos estos pasos son para poder usar los formularios adentro de el menustrip(menu principal de empleados).

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login entrada = new Login();
            this.Hide();
            entrada.Show();
        }

        private void registrarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario3_Registrar_Dato_Precio.InvRegDatPre registrardatoinventario = new Inventario3_Registrar_Dato_Precio.InvRegDatPre();
            registrardatoinventario.MdiParent = this;
            registrardatoinventario.Show();
        }

        private void mostrarInformacionIngresadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario_2_Mostrar_info_Ingr.InvInf mostrarinventario = new Inventario_2_Mostrar_info_Ingr.InvInf();
            mostrarinventario.MdiParent = this;
            mostrarinventario.Show();
        }

        private void eliminarUnDatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario_4_Eliminar_Dato.InvEliDat eliminarinventario = new Inventario_4_Eliminar_Dato.InvEliDat();
            eliminarinventario.MdiParent = this;
            eliminarinventario.Show();
        }

        private void modificarUnDatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InvModDat modificarinventario = new InvModDat();
            modificarinventario.MdiParent = this;
            modificarinventario.Show();
        }

        private void ordenARealizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas2_Orden_Menu.VenOrdMen ordenmenu = new Ventas2_Orden_Menu.VenOrdMen();
            ordenmenu.MdiParent = this;
            ordenmenu.Show();
        }

        private void insertarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdRegCon insertaproducto = new ProdRegCon();
            insertaproducto.MdiParent = this;
            insertaproducto.Show();
        }

        private void modificarOEliminarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PordModEli modificareliminarproducto = new PordModEli();
            modificareliminarproducto.MdiParent = this;
            modificareliminarproducto.Show();
        }
    }
}
