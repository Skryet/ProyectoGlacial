using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Empresa
{
    public partial class frm_EmpresaBuscar : Form
    {
        public frm_EmpresaBuscar()
        {
            InitializeComponent();
        }

        private void empresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_EmpresaBuscar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'glacial_almacenDataSet.empresa' table. You can move, or remove it, as needed.
          //  this.empresaTableAdapter.Fill(this.glacial_almacenDataSet.empresa);

        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
       //     this.empresaTableAdapter.Fill(this.glacial_almacenDataSet.empresa);
            if (empresaDataGridView.RowCount != 0)
                empresaDataGridView.CurrentRow.Selected = false;
            Program.idEmpresa = 0;
            txt_Buscar.Text = "";
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {          
            switch (cbb_Opciones.Text)
            {
                case "Nombre":
                 //   empresaTableAdapter.BuscarNombre(this.glacial_almacenDataSet.empresa, "%" + txt_Buscar.Text + "%");
                    txt_Buscar.Text = "";
                    break;
                case "Estado":
               //     empresaTableAdapter.BuscarEstado(this.glacial_almacenDataSet.empresa, "%" + txt_Buscar.Text + "%");
                    txt_Buscar.Text = "";
                    break;
                default:
                    MessageBox.Show("No se ha seleccionado la opcion de busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void empresaDataGridView_Click(object sender, EventArgs e)
        {
            Program.idEmpresa = Convert.ToInt32(empresaDataGridView.Rows[empresaDataGridView.CurrentCellAddress.Y].Cells[0].Value);            
        }

        private void empresaDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            this.empresaDataGridView.Columns[1].DefaultCellStyle.Format = "##00000";
        }
    }    
}
