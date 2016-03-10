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
        public event insertarID Insertar;
        private int id;

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

        private void proveedoresDataGridView_Click(object sender, EventArgs e)
        {
            id = Convert.ToInt32(proveedoresDataGridView.Rows[proveedoresDataGridView.CurrentCellAddress.Y].Cells[0].Value);
            Insertar(id);            
        }
    }
}
