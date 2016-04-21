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
            if (productosDataGridView.RowCount != 0)
                productosDataGridView.CurrentRow.Selected = false;
        }

        private void productosDataGridView_Click(object sender, EventArgs e)
        {
            if (productosDataGridView.RowCount != 0)
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
            Program.idProductoVenta = 0;
            this.Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {                              
            if (Program.idProductoVenta != 0)
            {
                Objetos.materialVenta producto = new Objetos.materialVenta();
                producto.idVenta = Program.idVenta;
                producto.idProducto = Program.idProductoVenta;
                producto.Cantidad = Convert.ToInt32(txt_Cantidad.Text);
                if (txt_Cantidad.Text != "0")
                {
                    int existencia = Convert.ToInt32(productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[4].Value);
                    if (Convert.ToInt32(txt_Cantidad.Text) > existencia)
                    {
                        MessageBox.Show("No puedes ingresar una cantidad mayor a la que hay en existencia.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txt_Cantidad.Text = "0";
                    }
                    else
                    {
                        int descontarExistencia = existencia - Convert.ToInt32(txt_Cantidad.Text);
                        switch (cbx_TipoPrecio.Text)
                        {
                            case "Precio 1":
                                producto.precioUnidad = Convert.ToDouble(productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[6].Value);
                                producto.unidadMedida = Convert.ToString(productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[5].Value);
                                producto.Total = producto.obtenerTotal();
                                ventas.agregarProduto(producto);
                                ventas.descontarProductos(descontarExistencia, Program.idProductoVenta);
                                Program.idProductoVenta = 0;
                                break;
                            case "Precio 2":
                                producto.precioUnidad = Convert.ToDouble(productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[7].Value);
                                producto.unidadMedida = Convert.ToString(productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[5].Value);
                                producto.Total = producto.obtenerTotal();
                                ventas.agregarProduto(producto);
                                ventas.descontarProductos(descontarExistencia, Program.idProductoVenta);
                                Program.idProductoVenta = 0;
                                break;
                            case "Precio 3":
                                producto.precioUnidad = Convert.ToDouble(productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[8].Value);
                                producto.unidadMedida = Convert.ToString(productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[5].Value);
                                producto.Total = producto.obtenerTotal();
                                ventas.agregarProduto(producto);
                                ventas.descontarProductos(descontarExistencia, Program.idProductoVenta);
                                Program.idProductoVenta = 0;
                                break;
                            case "Especial":
                                producto.precioUnidad = Convert.ToDouble(txt_PrecioEspecial.Text);
                                producto.unidadMedida = Convert.ToString(productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[4].Value);
                                producto.Total = producto.obtenerTotal();
                                ventas.agregarProduto(producto);
                                ventas.descontarProductos(descontarExistencia, Program.idProductoVenta);
                                Program.idProductoVenta = 0;
                                break;
                            default:
                                MessageBox.Show("No se ha seleccionado el precio en el que se dara el producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                                break;
                        }
                    }
                }
                else
                    MessageBox.Show("La cantidad del producto no puede ser 0", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                DialogResult resultadoDialogo = MessageBox.Show("No se ha seleccionado ningun producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void frm_VentasAgregarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.idProductoVenta = 0;
        }        
    }
}
