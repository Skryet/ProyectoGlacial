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
    public partial class frm_InventarioModificar : Form
    {
        public frm_InventarioModificar()
        {
            InitializeComponent();
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_InventarioModificar_Load(object sender, EventArgs e)
        {
            this.productosTableAdapter.FillByBuscarProductoPorID(this.glacial_almacenDataSet.productos,Program.idProducto);

        }

        private void txt_precio1_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDecimalPoint(e);
        }

        private void txt_precio2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDecimalPoint(e);
        }

        private void txt_precio3_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDecimalPoint(e);
        }

        private void txt_existencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDigit(e);
        }

        private void cantidad_minimaTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDigit(e);
        }

        private void isDigit(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDigit(e);
        }

        private void isDecimal(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDecimalPoint(e);
        }


        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            this.productosTableAdapter.ActualizarProductoPorID((txt_lineaProducto.Text).ToString(),
                txt_nombre.Text, txt_descripcion.Text, Convert.ToInt32(txt_existencia.Text),
                Convert.ToInt32(txt_cantidadMinima.Text), txt_unidadMedida.Text,
                Convert.ToDouble(txt_precio1.Text), Convert.ToDouble(txt_precio2.Text),
                Convert.ToDouble(txt_precio3.Text),Program.idProducto);
            MessageBox.Show("Registro actualizado con éxito");
            this.Close();
        }
    }
}
