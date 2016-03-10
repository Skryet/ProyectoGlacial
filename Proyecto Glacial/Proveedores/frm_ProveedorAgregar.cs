using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Proyecto_Glacial.Proveedores
{
    public partial class frm_ProveedorAgregar : Form
    {
        public frm_ProveedorAgregar()
        {
            InitializeComponent();
        }        

        private void limpiarCampos()
        {
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is TextBox)
                {
                    ctrl.Text = "";
                }
            }
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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (validarCampos() != true)
            {
                this.proveedoresTableAdapter.InsertarProveedor(txt_Nombre.Text, txt_Telefono.Text, txt_Direccion.Text, txt_Colonia.Text, txt_Estado.Text);
                limpiarCampos();

                AutoClosingMessageBox msg = new AutoClosingMessageBox("El registro ha sido agregado", "Mensaje",  1200); ;                
            }
            else
                MessageBox.Show("Faltan campos por agregar por favor agreguelos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void despintarTexto(object sender, EventArgs e)
        {
            TextBox limpiar = (TextBox)sender;
            limpiar.BackColor = Color.White;
        }

        private void frm_ProveedorAgregar_Load(object sender, EventArgs e)
        {

        }
    }
}
