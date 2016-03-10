using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Clientes
{
    public partial class frm_ClientesModificar : Form
    {
        public frm_ClientesModificar()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_ClientesModificar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
           // this.clientesTableAdapter.FillByBuscarClienteId(this.glacial_almacenDataSet.clientes, Convert.ToInt32(txtIdCliente.Text));
            //btn_Modificar.Enabled = true;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
