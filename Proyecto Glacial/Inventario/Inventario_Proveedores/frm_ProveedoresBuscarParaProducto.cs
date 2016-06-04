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
    public partial class frm_ProveedoresBuscarParaProducto : Form
    {
        public frm_ProveedoresBuscarParaProducto()
        {
            InitializeComponent();
        }

        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_ProveedoresBuscarParaProducto_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.proveedores' Puede moverla o quitarla según sea necesario.
            this.proveedoresTableAdapter.Fill(this.glacial_almacenDataSet.proveedores);

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            
            switch (cbb_Opciones.Text)
            {
                case "Nombre":
                    proveedoresTableAdapter.BuscarNombre(this.glacial_almacenDataSet.proveedores, "%" + txt_Buscar.Text + "%");
                    break;
                case "Estado":
                    proveedoresTableAdapter.BuscarEstado(this.glacial_almacenDataSet.proveedores, "%" + txt_Buscar.Text + "%");
                    break;
                default:
                    MessageBox.Show("No se ha seleccionado la opcion de busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void proveedoresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            if(proveedoresDataGridView.SelectedCells[0].Value.ToString() != "")
            { 
                Int32 selectedCellCount = proveedoresDataGridView.GetCellCount(DataGridViewElementStates.Selected);
                Program.idProveedor = Convert.ToInt32(proveedoresDataGridView.SelectedCells[0].Value.ToString());
                Program.nombreProveedor = proveedoresDataGridView.SelectedCells[1].Value.ToString();
                this.Close();
            }
        }

        private void proveedoresDataGridView_Click(object sender, EventArgs e)
        {
            btn_seleccionar.Enabled = true;
        }
    }
}
