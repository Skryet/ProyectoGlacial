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
        Validaciones validar;

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
            Control.ControlCollection[] controles = new Control.ControlCollection [this.Controls.Count];
            this.Controls.CopyTo(controles, 0);
            if (validar.validarCampos(controles))
            {
                DialogResult resultadoDialogo = MessageBox.Show("Esta seguro de modificar el proveedor " + txt_Nombre.Text, "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultadoDialogo == DialogResult.Yes)
                {
                    this.proveedoresTableAdapter.ActualizarProveedor(txt_Nombre.Text, txt_Telefono.Text, txt_Direccion.Text, txt_Colonia.Text, txt_Estado.Text, Program.idProveedor);
                    Program.idProveedor = 0;
                    this.Close();
                }
            }
            else
                MessageBox.Show("Faltan campos por agregar por favor agreguelos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
