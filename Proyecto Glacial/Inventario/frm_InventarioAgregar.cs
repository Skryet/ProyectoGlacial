using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Inventario
{
    public partial class frm_InventarioAgregar : Form
    {

        bool banderaRealizarPeticionFinal = false;
        bool agregarProveedoresProducto = false;

        private void habilitarTexto()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Enabled = true;
                }
            }
        }
        public frm_InventarioAgregar()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void txt_nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void productosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_InventarioAgregar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.lista_proveedores_productos' Puede moverla o quitarla según sea necesario.
            this.lista_proveedores_productosTableAdapter.Fill(this.glacial_almacenDataSet.lista_proveedores_productos);
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.vista_listar_proveedores_producto' Puede moverla o quitarla según sea necesario.
            //this.vista_listar_proveedores_productoTableAdapter.Fill(this.glacial_almacenDataSet.vista_listar_proveedores_producto);
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.productos' Puede moverla o quitarla según sea necesario.
            //this.productosTableAdapter.Fill(this.glacial_almacenDataSet.productos);

        }

        private void btn_AgregarProveedor_Click(object sender, EventArgs e)
        {
            Form frm_AgregarProveedorProducto = new Inventario.Inventario_Proveedores.frm_InventarioAgregarProductosProveedor();
            frm_AgregarProveedorProducto.Show();
        }

        private void btn_proveedoresAgregado_Click(object sender, EventArgs e)
        {
            this.productosTableAdapter.InsertarProductosConProveedores(Convert.ToInt32(txt_lineaProducto.Text),
                Program.idListaProveedorActual, txt_nombre.Text, txt_descripcion.Text, Convert.ToInt32
                (txt_existencia.Text), Convert.ToInt32(txt_cantidadMinima.Text), txt_unidadMedida.Text,
                Convert.ToInt32(txt_precio1.Text), Convert.ToInt32(txt_precio2.Text),
                Convert.ToInt32(txt_precio3.Text));
            this.lista_proveedores_productosTableAdapter.InsertarListaNuevaDeProveedoresProductos();
        }

        private void frm_InventarioAgregar_Activated(object sender, EventArgs e)
        {
            this.vista_listar_proveedores_productoTableAdapter.FillByBuscarProductosPorIdListaProveedoresProducto(this.glacial_almacenDataSet.vista_listar_proveedores_producto,Program.idListaProveedorActual);
        }

        private void frm_InventarioAgregar_MouseEnter(object sender, EventArgs e)
        {
            if(!banderaRealizarPeticionFinal && Program.agregarProveedoresProducto)
            {
                MessageBox.Show("Si entró");
                this.vista_listar_proveedores_productoTableAdapter.FillByBuscarProductosPorIdListaProveedoresProducto(this.glacial_almacenDataSet.vista_listar_proveedores_producto, Program.idListaProveedorActual);
                banderaRealizarPeticionFinal = true;
                habilitarTexto();
                btn_AgregarProveedor.Enabled = false;
            }

        }
    }
}
