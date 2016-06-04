using MySql.Data.MySqlClient;
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

        private void btn_reporte_Click(object sender, EventArgs e)
        {
            int idCompra = 0;
            MySqlDataAdapter adapter = null;
            MySqlDataAdapter adapter2 = null;
            CrystalReport1 objRpt = null;
            CrystalReport1 objRpt2 = null;
            Compras.frm_ComprasReporte rpt = new Compras.frm_ComprasReporte();
            string Query = "";
            string Query2 = "";
            objRpt = new CrystalReport1();
            objRpt2 = new CrystalReport1();
            glacial_almacenDataSet Ds = new glacial_almacenDataSet();
            String ConnStr = @"server=glacialcolima.ddns.net;user id=SGAglacial;password=Glacial_MASTER16;persistsecurityinfo=True;database=glacial_almacen";
            MySqlConnection myConnection = new MySqlConnection(ConnStr);


            for (int i = 0; i < comprasDataGridView.Rows.Count; i++)//Ciclo para agregar la Lista
            {
                idCompra = Convert.ToInt32(comprasDataGridView.Rows[i].Cells[0].Value);
                Query = "SELECT * FROM compras WHERE id_compra = " + idCompra; // ESTE ES NUESTRO QUERY
                Query2 = "SELECT * FROM lista_material_compras WHERE id_compra = " + idCompra;

                adapter = new MySqlDataAdapter(Query, ConnStr);
                adapter2 = new MySqlDataAdapter(Query2, ConnStr);

                adapter.Fill(Ds, "compras");
                adapter2.Fill(Ds, "lista_material_compras");
                objRpt.SetDataSource(Ds);

                rpt.crystalReportViewer1.ReportSource = objRpt;
                rpt.ShowDialog(); // AQUI LO MUESTR

                Ds = new glacial_almacenDataSet();
                // ESTE ES NUESTRO REPORT VIEWER                           

            }

        }
    }
}
