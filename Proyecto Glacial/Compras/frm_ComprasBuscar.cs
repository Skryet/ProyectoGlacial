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
    public partial class frm_ComprasBuscar : Form
    {
        string fechaInicio;
        string fechaFin;
        public frm_ComprasBuscar()
        {
            InitializeComponent();
        }

        private void comprasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_ComprasBuscar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.glacial_almacenDataSet.compras);

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
             fechaInicio = date_inicio.Value.Date.ToString("yyyy-MM-dd");
             fechaFin = date_fin.Value.Date.ToString("yyyy-MM-dd");
            this.comprasTableAdapter.FillByBuscarComprasPorRango(this.glacial_almacenDataSet.compras, fechaInicio, fechaFin);
        }

        private void date_inicio_ValueChanged(object sender, EventArgs e)
        {
            btn_Buscar.Enabled = true;
        }

        private void btn_BuscarTodo_Click(object sender, EventArgs e)
        {
            this.comprasTableAdapter.Fill(this.glacial_almacenDataSet.compras);
        }

        private void comprasDataGridView_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            Int32 selectedCellCount =
                comprasDataGridView.GetCellCount(DataGridViewElementStates.Selected);
            Program.idCompra = Convert.ToInt32(comprasDataGridView.SelectedCells[0].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form detallesCompra = new Compras.frm_ComprasBuscarDetalles();
            detallesCompra.ShowDialog();
            this.comprasTableAdapter.Fill(this.glacial_almacenDataSet.compras);
        }

        private void frm_ComprasBuscar_Activated(object sender, EventArgs e)
        {
            this.comprasTableAdapter.Fill(this.glacial_almacenDataSet.compras);
        }

        private void frm_ComprasBuscar_Enter(object sender, EventArgs e)
        {
            this.comprasTableAdapter.Fill(this.glacial_almacenDataSet.compras);
        }
    }
}
