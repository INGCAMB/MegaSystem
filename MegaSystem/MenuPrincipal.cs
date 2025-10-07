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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        //Todos estos pasos son para poder usar los formularios adentro de el menustrip(menu principal de gerente).

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados1_Registrar_Emp.EmpReg registrar = new Empleados1_Registrar_Emp.EmpReg();
            registrar.MdiParent = this;
            registrar.Show();
        }

        private void informacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleados_2_Informacion_Emp.EmpInf informacion = new Empleados_2_Informacion_Emp.EmpInf();
            informacion.MdiParent = this;
            informacion.Show();
        }

        private void eliminarOModificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Empleado_3_Eliminar_Modificar_Dato.EmpModEli ModEliEmpleado = new Empleado_3_Eliminar_Modificar_Dato.EmpModEli();
            ModEliEmpleado.MdiParent = this;
            ModEliEmpleado.Show();
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Login entrada = new Login();
            this.Hide();
            entrada.Show();
        }

        private void mostrarInformacionIngresadaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario_2_Mostrar_info_Ingr.InvInf mostrarinventario = new Inventario_2_Mostrar_info_Ingr.InvInf();
            mostrarinventario.MdiParent = this;
            mostrarinventario.Show();
        }

        private void ingresarUnDatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario3_Registrar_Dato_Precio.InvRegDatPre registrardatoinventario = new Inventario3_Registrar_Dato_Precio.InvRegDatPre();
            registrardatoinventario.MdiParent = this;
            registrardatoinventario.Show();
        }

        private void eliminarUnaDatoToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void mostrarVentasDiariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas1_Mostras_ventas_Diarias.VenConDia consultarventasdiarias = new Ventas1_Mostras_ventas_Diarias.VenConDia();
            consultarventasdiarias.MdiParent = this;
            consultarventasdiarias.Show();
        }

        private void consultarSumaDeVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas5_Consultar_Suma_Ventas.VenConSumVen consultarsumaventas = new Ventas5_Consultar_Suma_Ventas.VenConSumVen();
            consultarsumaventas.MdiParent = this;
            consultarsumaventas.Show();
        }

        private void ordenAlRealizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ventas2_Orden_Menu.VenOrdMen ordenmenu = new Ventas2_Orden_Menu.VenOrdMen();
            ordenmenu.MdiParent = this;
            ordenmenu.Show();
        }

        private void insertarUnProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inventario_1_Capturar_Dato.InvCapDat insertarproveedor = new Inventario_1_Capturar_Dato.InvCapDat();
            insertarproveedor.MdiParent = this;
            insertarproveedor.Show();
        }

        private void modificarOEliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProvModElim modificaeliminaproveedor = new ProvModElim();
            modificaeliminaproveedor.MdiParent = this;
            modificaeliminaproveedor.Show();
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

        private void consultarProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProvInf consultaproveedores = new ProvInf();
            consultaproveedores.MdiParent = this;
            consultaproveedores.Show();
        }
    }
}
