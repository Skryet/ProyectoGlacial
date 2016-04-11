using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Ventas
{
    public partial class frm_VentaSeleccionCliente : Form
    {
        public frm_VentaSeleccionCliente()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_VentaSeleccionCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);
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
                        if (txt_Buscar.Text.GetType() == Type.GetType("System.Int32")) //Verificar si es número
                        {
                            this.clientesTableAdapter.FillByBuscarClienteId(this.glacial_almacenDataSet.clientes, Convert.ToInt32(txt_Buscar.Text));
                            if (clientesDataGridView.RowCount == 0)
                                MessageBox.Show("No se encontró un registro con este número", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                            MessageBox.Show("Por favor introduzca un número válido");
                        break;

                    case "Apellido Paterno":
                        this.clientesTableAdapter.FillByBuscarClientePorApellidoP(this.glacial_almacenDataSet.clientes, "%" + txt_Buscar.Text + "%");
                        if (clientesDataGridView.RowCount == 0)
                            MessageBox.Show("No se encontró un registro con este apellido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
        }

        private void clientesDataGridView_Click(object sender, EventArgs e)
        {
            Program.idClienteVenta = Convert.ToInt32(clientesDataGridView.Rows[clientesDataGridView.CurrentCellAddress.Y].Cells[0].Value);
        }

        private void btn_SeleccionarCliente_Click(object sender, EventArgs e)
        {
            if (Program.idClienteVenta == 0)
            {
                DialogResult resultadoDialogo = MessageBox.Show("No se ha seleccionado ningun cliente, ¿Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultadoDialogo == DialogResult.Yes)
                {
                    Program.idClienteVenta = 0;
                    this.Close();
                }
            }
            else
                this.Close();                 
        }

        private void btn_AgregarCiente_Click(object sender, EventArgs e)
        {
            Form agregarCliente = new frm_ClientesAgregar();
            agregarCliente.ShowDialog();
            this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);
        }
    }
}
