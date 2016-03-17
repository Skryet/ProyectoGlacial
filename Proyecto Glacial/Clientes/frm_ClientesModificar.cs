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
            this.clientesTableAdapter.FillByBuscarClienteId(this.glacial_almacenDataSet.clientes,Program.idCliente);


        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
           // this.clientesTableAdapter.FillByBuscarClienteId(this.glacial_almacenDataSet.clientes, Convert.ToInt32(txtIdCliente.Text));
            //btn_Modificar.Enabled = true;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            
        }

        private void frm_ClientesModificar_Enter(object sender, EventArgs e)
        {
          
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro de acctualizar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                this.clientesTableAdapter.UpdateClientesPorId(txt_Nombre.Text, txt_apellidoP.Text, txt_apellidoP.Text, txt_direccion.Text, txt_colonia.Text, txt_ciudad.Text, txt_cp.Text, Program.idCliente);
                MessageBox.Show("Registro Actualizado con éxito!", "Completado");
                //this.Close();
                this.Refresh();

                //Deshabilitar Campos
                txt_Nombre.Enabled = false;
                txt_apellidoP.Enabled = false;
                txt_apellidoM.Enabled = false;
                txt_direccion.Enabled = false;
                txt_colonia.Enabled = false;
                txt_ciudad.Enabled = false;
                txt_cp.Enabled = false;
            }
           
            

            
        }
    }
}
