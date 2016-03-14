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
    public partial class frm_EmpresaAgregar : Form
    {
        public frm_EmpresaAgregar()
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

        private void despintarTexto(object sender, EventArgs e)
        {
            TextBox limpiar = (TextBox)sender;
            limpiar.BackColor = Color.White;
        }

        private void empresaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void empresaBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.empresaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_EmpresaAgregar_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'glacial_almacenDataSet.empresa' table. You can move, or remove it, as needed.
            this.empresaTableAdapter.Fill(this.glacial_almacenDataSet.empresa);

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (validarCampos() != true)
            {
                this.empresaTableAdapter.InsertarEmpresa(txt_Nombre.Text, txt_Telefono.Text, txt_Direccion.Text, txt_Colonia.Text, txt_Estado.Text);
                limpiarCampos();

                AutoClosingMessageBox msg = new AutoClosingMessageBox("El registro ha sido agregado", "Mensaje", 1200); ;
            }
            else
                MessageBox.Show("Faltan campos por agregar por favor agreguelos", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            DialogResult resultadoDialogo = MessageBox.Show("¿Esta seguro de regresar al menu principal?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resultadoDialogo == DialogResult.Yes)
            {
                Program.idProveedor = 0;
                this.Close();
            }
        }
    }
}
