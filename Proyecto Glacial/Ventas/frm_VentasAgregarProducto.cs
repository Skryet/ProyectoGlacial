using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Ventas
{
    public partial class frm_VentasAgregarProducto : Form
    {
        public frm_VentasAgregarProducto()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_VentasAgregarProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.glacial_almacenDataSet.productos);

        }

        private void productosDataGridView_Click(object sender, EventArgs e)
        {
            Program.idProductoVenta = Convert.ToInt32(productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[1].Value);
        }
    }
}
