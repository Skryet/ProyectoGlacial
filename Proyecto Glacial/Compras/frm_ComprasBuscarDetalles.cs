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
    public partial class frm_ComprasBuscarDetalles : Form
    {
        public int idProducto2;
        public int cantidad2;
        public string unidad_medida;
        public double total2;
        public double totalCompra;
        public string nombre;
        public int idListaMaterialCompra;

        

        public frm_ComprasBuscarDetalles()
        {
            InitializeComponent();
        }

        private void lista_proveedores_productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lista_proveedores_productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_ComprasBuscarDetalles_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.glacial_almacenDataSet.compras);
            this.Location = new Point(310, 20);
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.lista_material_compras' Puede moverla o quitarla según sea necesario.
            this.lista_material_comprasTableAdapter.FillByBuscarProductosPorIdCompra(this.glacial_almacenDataSet.lista_material_compras,Program.idCompra);
           

        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            Form modificarDetallesCompra = new Compras.frm_ComprasModificarDetallesCompra();
            modificarDetallesCompra.ShowDialog();
        }

        private void frm_ComprasBuscarDetalles_Activated(object sender, EventArgs e)
        {
            this.lista_material_comprasTableAdapter.FillByBuscarProductosPorIdCompra(this.glacial_almacenDataSet.lista_material_compras, Program.idCompra);
        }

        private void lista_material_comprasDataGridView_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Int32 selectedCellCount =
                lista_material_comprasDataGridView.GetCellCount(DataGridViewElementStates.Selected);
            Program.idListaCompra = Convert.ToInt32(lista_material_comprasDataGridView.SelectedCells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            var resultado = MessageBox.Show("¿Está seguro de eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.lista_material_comprasTableAdapter.BorrarListaCompras(Program.idListaCompra);
                MessageBox.Show("Registro Eliminado con éxito!", "Completado");
                this.lista_material_comprasTableAdapter.FillByBuscarProductosPorIdCompra(this.glacial_almacenDataSet.lista_material_compras,Program.idCompra);
                // this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);
            }
        }

        private void frm_ComprasBuscarDetalles_FormClosed(object sender, FormClosedEventArgs e)
        {
            total2 = 0;
            totalCompra = 0;
            for (int i = 0; i < lista_material_comprasDataGridView.Rows.Count; i++)//Ciclo para calcular total
            {
                total2 = Convert.ToDouble(lista_material_comprasDataGridView.Rows[i].Cells[6].Value);
                totalCompra += total2;
            }
            this.comprasTableAdapter.ActualizarCompraPorId(totalCompra, Program.idCompra);
        }
    }
}
