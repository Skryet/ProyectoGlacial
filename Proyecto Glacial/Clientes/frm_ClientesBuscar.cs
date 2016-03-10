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
    public partial class frm_ClientesBuscar : Form
    {
        public frm_ClientesBuscar()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_ClientesBuscar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.clientes' Puede moverla o quitarla según sea necesario.
              this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.FillByBuscarClienteId(this.glacial_almacenDataSet.clientes, Convert.ToInt32(txt_Buscar.Text));
            if (clientesDataGridView.RowCount == 0)
                MessageBox.Show("No se encontró un registro con este número", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btn_BuscarTodos_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscar.Text != "")
                btn_Buscar.Enabled = true;
            else if (txt_Buscar.Text == "")
                btn_Buscar.Enabled = false;
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {       

            //Metodo para hacer la búsqueda
            if (cmb_SelccionarTipo.Text == "Seleccione")
                MessageBox.Show("Seleccione un tipo de búsqueda", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            { 
                switch (cmb_SelccionarTipo.Text)
                {
                    case "Número de Cliente":
                        this.clientesTableAdapter.FillByBuscarClienteId(this.glacial_almacenDataSet.clientes, Convert.ToInt32(txt_Buscar.Text));
                        if (clientesDataGridView.RowCount == 0)
                            MessageBox.Show("No se encontró un registro con este número", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case "Apellido Paterno":
                        this.clientesTableAdapter.FillByBuscarClientePorApellidoP(this.glacial_almacenDataSet.clientes, "%" + txt_Buscar.Text + "%");
                        if (clientesDataGridView.RowCount == 0)
                            MessageBox.Show("No se encontró un registro con este apellido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            if (txt_Buscar.Text != "")
                btn_Buscar.Enabled = true;
            else if (txt_Buscar.Text == "" || cmb_SelccionarTipo.Text == "Seleccione")
                btn_Buscar.Enabled = false;
        }

        private void btn_BuscarTodo_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);
        }

        private void clientesDataGridView_Click(object sender, EventArgs e)
        {

            Int32 selectedCellCount =
                clientesDataGridView.GetCellCount(DataGridViewElementStates.Selected);
            Program.idCliente = Convert.ToInt32(clientesDataGridView.SelectedCells[0].Value.ToString());
       
        }
    }
}
