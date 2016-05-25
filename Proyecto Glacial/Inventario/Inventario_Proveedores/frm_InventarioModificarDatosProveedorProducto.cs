using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Inventario.Inventario_Proveedores
{
    
    public partial class frm_InventarioModificarDatosProveedorProducto : Form
    {
        public frm_InventarioModificarDatosProveedorProducto()
        {
            InitializeComponent();
        }

        private void proveedor_codigoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedor_codigoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_InventarioModificarDatosProveedorProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.proveedor_codigo' Puede moverla o quitarla según sea necesario.
            this.proveedor_codigoTableAdapter.FillByBuscarPorIdProveedorCodigo(this.glacial_almacenDataSet.proveedor_codigo,Program.idProveedorCodigo);

        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.proveedor_codigoTableAdapter.ActualizarRegistroProductosProveedorPorID(txt_codigo.Text, Convert.ToDouble(txt_precio.Text), txt_unidadMedida.Text, Program.idProveedorCodigo);
            MessageBox.Show("Registro actualizado con éxito");
            this.Close();
        }

        private void txt_codigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDecimalPoint(e);
        }

        private void txt_unidadMedida_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isChar(e);
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDecimalPoint(e);
        }
    }
}
