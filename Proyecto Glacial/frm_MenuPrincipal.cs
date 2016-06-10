using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial
{
    public partial class frm_MenuPrincipal : Form
    {
        public frm_MenuPrincipal()
        {
            InitializeComponent();
            this.CenterToScreen();
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            Form FormularioClientes = new frm_ClientesMenu();
            FormularioClientes.ShowDialog();
            this.Show();
        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            Form frm_Proveedores = new frm_Proveedores();
            frm_Proveedores.ShowDialog();
            this.Show();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            Form frm_inventario = new Inventario.frm_InventarioMenu();
            frm_inventario.ShowDialog();
            this.Show();
        }


        private void frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_comprarProductos_Click(object sender, EventArgs e)
        {
            Form frm_compras = new Compras.frm_ComprasMenu();
            frm_compras.ShowDialog();
            this.Show();
        }       

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            Program.listaProductosVenta = new Ventas.Objetos.ListaEnlazadaProductos();
            Form frm_Ventas = new Ventas.frm_Ventas();
            frm_Ventas.ShowDialog();
            this.Show();
        }
    }
}
