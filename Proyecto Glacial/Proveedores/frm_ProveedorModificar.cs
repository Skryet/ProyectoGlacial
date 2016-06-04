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
    public partial class frm_ProveedorModificar : Form
    {
        private void despintarTexto(object sender, EventArgs e)
        {
            TextBox limpiar = (TextBox)sender;
            limpiar.BackColor = Color.White;
        }        

        private bool validarCampos()
        {
            bool vacio = false;
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox && ctrl.Text == "")
                {
                    ctrl.BackColor = Color.Red;
                    vacio = true;
                }
            }
            return vacio;
        }

        public frm_ProveedorModificar()
        {
            InitializeComponent();
        }       

        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_ProveedorModificar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'glacial_almacenDataSet.proveedores' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.BuscarID(this.glacial_almacenDataSet.proveedores, Program.idProveedor);
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {            
            if (validarCampos() != true)
            {                
                DialogResult resultadoDialogo = MessageBox.Show("Esta seguro de modificar el proveedor " + txt_Nombre.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultadoDialogo == DialogResult.Yes)
                {
                    
                    this.proveedoresTableAdapter.ModificarProveedor(txt_Nombre.Text, txt_Telefono.Text, txt_Direccion.Text, txt_Colonia.Text, txt_Estado.Text, txt_Email.Text, txt_cp.Text, txt_RFC.Text, Program.idProveedor);
                    Program.idProveedor = 0;
                    AutoClosingMessageBox msg = new AutoClosingMessageBox("El registro ha sido modificado", "Mensaje", 1200); ;
                    this.Close();
                }
            }
            else
                MessageBox.Show("Faltan campos por agregar por favor agreguelos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultadoDialogo = MessageBox.Show("¿Esta seguro de cancelar la modificación del proveedor" + txt_Nombre.Text +"?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultadoDialogo == DialogResult.Yes)
            {
                Program.idProveedor = 0;
                this.Close();
            }
        }
    }
}
