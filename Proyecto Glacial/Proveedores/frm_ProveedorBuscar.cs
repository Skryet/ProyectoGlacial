using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Proveedores
{
    public partial class frm_ProveedorBuscar : Form
    {

        public frm_ProveedorBuscar()
        {            
            InitializeComponent();            
        }

        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_ProveedorBuscar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'glacial_almacenDataSet.proveedores' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.Fill(this.glacial_almacenDataSet.proveedores);
            if (proveedoresDataGridView.RowCount != 0)
                proveedoresDataGridView.CurrentRow.Selected = false;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            switch (cbb_Opciones.Text)
            {
                case "Nombre":
                    proveedoresTableAdapter.BuscarNombre(this.glacial_almacenDataSet.proveedores, "%" + txt_Buscar.Text + "%");
                    txt_Buscar.Text = "";
                    break;
                case "Estado":
                    proveedoresTableAdapter.BuscarEstado(this.glacial_almacenDataSet.proveedores, "%" + txt_Buscar.Text + "%");
                    txt_Buscar.Text = "";
                    break;
                default:
                    MessageBox.Show("No se ha seleccionado la opcion de busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }     

        private void proveedoresDataGridView_Click(object sender, EventArgs e)
        {
            Program.idProveedor = Convert.ToInt32(proveedoresDataGridView.Rows[proveedoresDataGridView.CurrentCellAddress.Y].Cells[1].Value);
            MessageBox.Show(Program.idProveedor.ToString());
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            this.proveedoresTableAdapter.Fill(this.glacial_almacenDataSet.proveedores);
            if (proveedoresDataGridView.RowCount != 0)
                proveedoresDataGridView.CurrentRow.Selected = false;
            Program.idProveedor = 0;
            txt_Buscar.Text = "";
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void proveedoresDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.proveedoresDataGridView.Columns[1].DefaultCellStyle.Format = "##00000";
        }

        private void proveedoresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
