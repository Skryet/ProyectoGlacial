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
    public partial class frm_ClientesVisualizarIndividual : Form
    {
        public frm_ClientesVisualizarIndividual()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_ClientesVisualizarIndividual_Load(object sender, EventArgs e)
        {
           
            this.Location = new Point(30, 30);
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.FillByBuscarClienteId(this.glacial_almacenDataSet.clientes,Program.idCliente);
            int consecutivo = 0;
            consecutivo = Convert.ToInt32(id_clienteTextBox.Text);
            string cadena = "C" + consecutivo.ToString("D4");
            txt_codigoClienteFormato.Text = cadena;
            if (CHECK_tieneCredito.Checked)
            {

                grp_credito.Visible = true;
            }
            else if (!CHECK_tieneCredito.Checked)
            {
                grp_credito.Visible = false;
            }

        }
    }
}
