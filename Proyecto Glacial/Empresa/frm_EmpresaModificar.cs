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
    public partial class frm_EmpresaModificar : Form
    {
        public frm_EmpresaModificar()
        {
            InitializeComponent();
        }

        private void empresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_EmpresaModificar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'glacial_almacenDataSet.empresa' table. You can move, or remove it, as needed.
            this.empresaTableAdapter.Fill(this.glacial_almacenDataSet.empresa);

        }
    }
}
