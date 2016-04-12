using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Compras
{
    public partial class frm_ComprasModificarDetallesCompra : Form
    {
        public int idProducto2;
        public int cantidad2;
        public string unidad_medida;
        public double total2;
        public string nombre;
        public double totalCompra;
        public int idListaMaterialCompra;

        public frm_ComprasModificarDetallesCompra()
        {
            InitializeComponent();
        }

        private void lista_material_comprasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lista_material_comprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_ComprasModificarDetallesCompra_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.glacial_almacenDataSet.compras);
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.lista_material_compras' Puede moverla o quitarla según sea necesario.
            this.lista_material_comprasTableAdapter.FillByBuscarProductosPorIdCompra(this.glacial_almacenDataSet.lista_material_compras,Program.idCompra);
            this.Location = new Point(400, 20);
        }

        private void lista_material_comprasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.lista_material_comprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);


        }

  

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lista_material_comprasDataGridView.Rows.Count - 1; i++)//Ciclo para agregar la Lista
            {
                idProducto2 = Convert.ToInt32(lista_material_comprasDataGridView.Rows[i].Cells[1].Value);
                cantidad2 = Convert.ToInt32(lista_material_comprasDataGridView.Rows[i].Cells[3].Value);
                unidad_medida = lista_material_comprasDataGridView.Rows[i].Cells[5].Value.ToString();
                total2 = Convert.ToDouble(lista_material_comprasDataGridView.Rows[i].Cells[4].Value);
                totalCompra += total2;
                nombre = lista_material_comprasDataGridView.Rows[i].Cells[2].Value.ToString();
                idListaMaterialCompra = Convert.ToInt32(lista_material_comprasDataGridView.Rows[i].Cells[0].Value);
                this.lista_material_comprasTableAdapter.UpdateDetallesProducto(Program.idCompra, total2, cantidad2, idProducto2, unidad_medida, nombre, Program.idListaCompra);
            }
            this.comprasTableAdapter.ActualizarCompraPorId(totalCompra, Program.idCompra);
        }

        private void frm_ComprasModificarDetallesCompra_Enter(object sender, EventArgs e)
        {
            this.lista_material_comprasTableAdapter.FillByBuscarProductosPorIdCompra(this.glacial_almacenDataSet.lista_material_compras, Program.idCompra);
        }
    }
}
