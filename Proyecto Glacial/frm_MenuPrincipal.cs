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
        }

        private void btn_Clientes_Click(object sender, EventArgs e)
        {
            Form FormularioClientes = new frm_ClientesMenu();
            FormularioClientes.Show();

        }

        private void btn_Proveedores_Click(object sender, EventArgs e)
        {
            Form frm_Proveedores = new frm_Proveedores();
            frm_Proveedores.Show();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            Form frm_inventario = new Inventario.frm_InventarioMenu();
            frm_inventario.ShowDialog();
        }


        private void frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 20);
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_comprarProductos_Click(object sender, EventArgs e)
        {
            Form frm_compras = new Compras.frm_ComprasMenu();
            frm_compras.ShowDialog();
        }
    }
}
