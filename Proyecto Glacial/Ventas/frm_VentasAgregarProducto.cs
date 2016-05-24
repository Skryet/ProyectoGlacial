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
        private Consultas.GenerarAutocompletado LlenarLista = new Consultas.GenerarAutocompletado();
        private Objetos.ListaEnlazadaProductos ListaProductos = new Objetos.ListaEnlazadaProductos();

        public frm_VentasAgregarProducto()
        {
            InitializeComponent();
        }

        private void frm_VentasAgregarProducto_Load(object sender, EventArgs e)
        {
            //Llenar Lista de Productos
            LlenarLista.llenarListaAutocompletarCodigo("", ListaProductos);
            Objetos.NodoProducto tmp = ListaProductos.ObtenerLista();
            Objetos.NodoProducto recorrerLista = tmp;
            for (int i = 0; i < ListaProductos.CantidadElementos(); i++)
            {
                productosDataGridView.Rows.Add(recorrerLista.Producto.idLineaProducto, recorrerLista.Producto.Nombre, recorrerLista.Producto.Descripcion, recorrerLista.Producto.Cantidad.ToString(),
                    recorrerLista.Producto.UnidadMedida, recorrerLista.Producto.Precio1.ToString(), recorrerLista.Producto.Precio2.ToString(), recorrerLista.Producto.Precio3.ToString());
                recorrerLista = recorrerLista.Siguiente;
            }

            if (productosDataGridView.RowCount != 0)
                productosDataGridView.CurrentRow.Selected = false;
        }

        private void productosDataGridView_Click(object sender, EventArgs e)
        {                    
            if (productosDataGridView.RowCount != 0)
                Program.idProductoVenta = productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[1].Value.ToString();
        }       

        private void cbx_TipoPrecio_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        
        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string idLineaProducto = productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[0].Value.ToString();
            Objetos.NodoProducto Producto = ListaProductos.obtenerProducto(idLineaProducto);

            //Comprobar que sobre pase la existencia
            Objetos.NodoProducto verificarExistencia = Program.listaProductosVenta.obtenerProducto(idLineaProducto);
            if (verificarExistencia != null)
            {
                int cantidad = verificarExistencia.Producto.Cantidad + 1;
                if (cantidad <= ListaProductos.obtenerProducto(idLineaProducto).Producto.Cantidad)
                    Program.listaProductosVenta.AgregarCantidad(cantidad, idLineaProducto);
                else
                    MessageBox.Show("No se puede agregar la cantidad que necesita por que se excede la existencia del almacén.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Producto.Producto.Cantidad = 1;
                Program.listaProductosVenta.Insertar(Producto);
            }
            Program.manipularDatos.MostrarDatos_DataGridView();
            Program.manipularDatos.generarTotalVenta();            
            this.Close();
        }

        private void frm_VentasAgregarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.idProductoVenta = "";
        }

        private void productosDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idLineaProducto = productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[0].Value.ToString();
            Objetos.NodoProducto Producto = ListaProductos.obtenerProducto(idLineaProducto);

            //Comprobar que sobre pase la existencia
            Objetos.NodoProducto verificarExistencia = Program.listaProductosVenta.obtenerProducto(idLineaProducto);
            if (verificarExistencia != null)
            {
                int cantidad = verificarExistencia.Producto.Cantidad + 1;
                if (cantidad <= ListaProductos.obtenerProducto(idLineaProducto).Producto.Cantidad)
                    Program.listaProductosVenta.AgregarCantidad(cantidad, idLineaProducto);
                else
                    MessageBox.Show("No se puede agregar la cantidad que necesita por que se excede la existencia del almacén.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Producto.Producto.Cantidad = 1;
                Program.listaProductosVenta.Insertar(Producto);
            }
            Program.manipularDatos.MostrarDatos_DataGridView();
            Program.manipularDatos.generarTotalVenta();
            this.Close();
        }
    }
}
