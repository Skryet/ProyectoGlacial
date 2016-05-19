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
    public partial class frm_AutocompletadoProductos : Form
    {
        private Point posicion;
        public frm_AutocompletadoProductos(Point localizacion)
        {
            InitializeComponent();
            posicion = localizacion;
        }
        
        private void frm_AutocompletadoProductos_Load(object sender, EventArgs e)
        {
            Objetos.NodoProducto tmp = Program.listaProductosAutocompletar.ObtenerLista();
            Objetos.NodoProducto recorrerLista = tmp;
            for (int i = 0; i < Program.listaProductosAutocompletar.CantidadElementos(); i++)
            {
                productosDataGridView.Rows.Add(recorrerLista.Producto.idLineaProducto, recorrerLista.Producto.Nombre, recorrerLista.Producto.Descripcion, recorrerLista.Producto.Cantidad.ToString(),
                    recorrerLista.Producto.UnidadMedida, recorrerLista.Producto.Precio1.ToString(), recorrerLista.Producto.Precio2.ToString(), recorrerLista.Producto.Precio3.ToString());
                recorrerLista = recorrerLista.Siguiente;
            }
            posicion.Y += 140;
            this.Location = posicion;
        }

        private void dgv_Productos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            { }
            if ((int)e.KeyChar == (int)Keys.Escape)
            { this.Close(); }
        }

        private void dgv_Productos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string idLineaProducto = productosDataGridView.Rows[productosDataGridView.CurrentCellAddress.Y].Cells[0].Value.ToString();
            Objetos.NodoProducto Producto = Program.listaProductosAutocompletar.obtenerProducto(idLineaProducto);

            //Comprobar que sobre pase la existencia
            Objetos.NodoProducto verificarExistencia = Program.listaProductosVenta.obtenerProducto(idLineaProducto);
            if (verificarExistencia != null)
            {
                int cantidad = verificarExistencia.Producto.Cantidad + 1;
                if (cantidad <= Program.listaProductosAutocompletar.obtenerProducto(idLineaProducto).Producto.Cantidad)
                    Program.listaProductosVenta.AgregarCantidad(cantidad, idLineaProducto);
                else
                    MessageBox.Show("No se puede agregar la cantidad que necesita por que se excede la existencia del almacén.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
            else
            {
                Program.listaProductosVenta.Insertar(Producto);
                this.Close();
            }
            
        }
    }
}
