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
        private Objetos.ListaEnlazadaProductos ListaProductos;

        public frm_VentasAgregarProducto()
        {
            InitializeComponent();
        }

        private void LlenarTablaProductos(bool mostrarTodo, string tipoLlenado, string busqueda)
        {
            ListaProductos = new Objetos.ListaEnlazadaProductos();
            //Llenar Lista de Productos
            switch(tipoLlenado)
            {
                case "Todo":
                    LlenarLista.llenarListaAutocompletarCodigo("", ListaProductos, mostrarTodo);
                    break;
                case "Codigo":
                    LlenarLista.llenarListaAutocompletarCodigo(busqueda, ListaProductos, mostrarTodo);
                    break;
                case "Descripcion":
                    LlenarLista.llenarListaAutocompletarDescripcion(busqueda, ListaProductos, mostrarTodo);
                    break;
                case "Linea":
                    LlenarLista.llenarListaAutocompletarNombre(busqueda, ListaProductos, mostrarTodo);
                    break;
            }
            
            Objetos.NodoProducto tmp = ListaProductos.ObtenerLista();
            Objetos.NodoProducto recorrerLista = tmp;
            for (int i = 0; i < ListaProductos.CantidadElementos(); i++)
            {
                productosDataGridView.Rows.Add(recorrerLista.Producto.idLineaProducto, recorrerLista.Producto.Nombre, recorrerLista.Producto.Descripcion, recorrerLista.Producto.Cantidad.ToString(),
                    recorrerLista.Producto.UnidadMedida, recorrerLista.Producto.Precio1.ToString("C"), recorrerLista.Producto.Precio2.ToString("C"), recorrerLista.Producto.Precio3.ToString("C"));
                recorrerLista = recorrerLista.Siguiente;
            }

            if (productosDataGridView.RowCount != 0)
                productosDataGridView.CurrentRow.Selected = false;
        }

        private void frm_VentasAgregarProducto_Load(object sender, EventArgs e)
        {
            LlenarTablaProductos(false, "Todo", "");
        }

        private void productosDataGridView_Click(object sender, EventArgs e)
        {                    
            if (productosDataGridView.RowCount != 0)
                Program.idProductoVenta = productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[1].Value.ToString();
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

        private void rbt_Existencia_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Existencia.Checked == true)
            {
                productosDataGridView.Rows.Clear();
                LlenarTablaProductos(false, "Todo", "");
                productosDataGridView.Refresh();
            }
        }

        private void rbt_Todo_CheckedChanged(object sender, EventArgs e)
        {
            productosDataGridView.Rows.Clear();
            LlenarTablaProductos(true, "Todo", "");
            productosDataGridView.Refresh();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            productosDataGridView.Rows.Clear();
            switch (cbx_Tipo.SelectedItem.ToString())
            {
                case "Código":
                    if (rbt_Existencia.Checked == true)
                        LlenarTablaProductos(false, "Codigo", txt_Buscar.Text);
                    else
                        LlenarTablaProductos(true, "Codigo", txt_Buscar.Text);
                    break;
                case "Descripción":
                    if (rbt_Existencia.Checked == true)
                        LlenarTablaProductos(false, "Descripcion", txt_Buscar.Text);
                    else
                        LlenarTablaProductos(true, "Descripcion", txt_Buscar.Text);
                    break;
                case "Línea":
                    if (rbt_Existencia.Checked == true)
                        LlenarTablaProductos(false, "Linea", txt_Buscar.Text);
                    else
                        LlenarTablaProductos(true, "Linea", txt_Buscar.Text);
                    break;
            }
            productosDataGridView.Refresh();
            txt_Buscar.Text = "";
        }

        private void productosDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int id = ListaProductos.obtenerProducto(productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[0].Value.ToString()).Producto.idProducto;
            Program.idProducto = id;
            Inventario.frm_InventarioVisualizarProducto DetalleProducto = new Inventario.frm_InventarioVisualizarProducto();
            DetalleProducto.ShowDialog();
            Program.idProducto = 0;
        }

        private void btn_MostrarLista_Click(object sender, EventArgs e)
        {
            productosDataGridView.Rows.Clear();
            switch (cbx_Tipo.SelectedItem.ToString())
            {
                case "Código":
                    if (rbt_Existencia.Checked == true)
                        LlenarTablaProductos(false, "Codigo", txt_Buscar.Text);
                    else
                        LlenarTablaProductos(true, "Codigo", txt_Buscar.Text);
                    break;
                case "Descripción":
                    if (rbt_Existencia.Checked == true)
                        LlenarTablaProductos(false, "Descripcion", txt_Buscar.Text);
                    else
                        LlenarTablaProductos(true, "Descripcion", txt_Buscar.Text);
                    break;
                case "Línea":
                    if (rbt_Existencia.Checked == true)
                        LlenarTablaProductos(false, "Linea", txt_Buscar.Text);
                    else
                        LlenarTablaProductos(true, "Linea", txt_Buscar.Text);
                    break;
            }
            productosDataGridView.Refresh();
            txt_Buscar.Text = "";
        }

        private void txt_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                productosDataGridView.Rows.Clear();
                switch (cbx_Tipo.SelectedItem.ToString())
                {
                    case "Código":
                        if (rbt_Existencia.Checked == true)
                            LlenarTablaProductos(false, "Codigo", txt_Buscar.Text);
                        else
                            LlenarTablaProductos(true, "Codigo", txt_Buscar.Text);
                        break;
                    case "Descripción":
                        if (rbt_Existencia.Checked == true)
                            LlenarTablaProductos(false, "Descripcion", txt_Buscar.Text);
                        else
                            LlenarTablaProductos(true, "Descripcion", txt_Buscar.Text);
                        break;
                    case "Línea":
                        if (rbt_Existencia.Checked == true)
                            LlenarTablaProductos(false, "Linea", txt_Buscar.Text);
                        else
                            LlenarTablaProductos(true, "Linea", txt_Buscar.Text);
                        break;
                }
                productosDataGridView.Refresh();
                txt_Buscar.Text = "";
            }
        }
    }
}
