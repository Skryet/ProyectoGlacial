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
        private Ventas.Consultas.generarVenta ventas = new Consultas.generarVenta();

        public frm_VentasAgregarProducto()
        {
            InitializeComponent();
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

        private void cbx_TipoPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_TipoPrecio.Text == "Especial")
            {
                txt_PrecioEspecial.Enabled = true;
                lbl_PrecioEspecial.Enabled = true;
                txt_PrecioEspecial.Visible = true;
                lbl_PrecioEspecial.Visible = true;
            }

            else
            {
                txt_PrecioEspecial.Enabled = false;
                lbl_PrecioEspecial.Enabled = false;
                txt_PrecioEspecial.Visible = false;
                lbl_PrecioEspecial.Visible = false;
            }
        }

        private void bn_Finalizar_Click(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (Program.idProductoVenta != 0)
            {
                Objetos.materialVenta producto = new Objetos.materialVenta();
                producto.idlVenta = Program.idVenta;
                producto.idProducto = Program.idProductoVenta;
                producto.Cantidad = Convert.ToInt32(txt_Cantidad.Text);
                switch (cbx_TipoPrecio.Text)
                {
                    case "Precio 1":
                        producto.precioUnidad = Convert.ToDouble(productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[5].Value);
                        break;
                    case "Precio 2":
                        producto.precioUnidad = Convert.ToDouble(productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[6].Value);
                        break;
                    case "Precio 3":
                        producto.precioUnidad = Convert.ToDouble(productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[6].Value);
                        break;
                    case "Especial":
                        producto.precioUnidad = Convert.ToDouble(txt_PrecioEspecial.Text);
                        break;
                    default:
                        MessageBox.Show("No se ha seleccionado el precio en el que se dara el producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }
                producto.unidadMedida = Convert.ToString(productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[4].Value);
                ventas.agregarProduto(producto);
            }
            else
            {
                DialogResult resultadoDialogo = MessageBox.Show("No se ha seleccionado ningun producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void productosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }
    }
}
