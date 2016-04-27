using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial
{
    public partial class frm_ClientesAgregar : Form
    {
        
    
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
        
        public frm_ClientesAgregar()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            txtNombre.Text = "";
            txtApellidoP.Text = "";
            txtApellidoM.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtCodigoPostal.Text = "";
            txtColonia.Text = "";
            
        }

        private void frm_ClientesAgregar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.clientes' Puede moverla o quitarla según sea necesario.
            //this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);

        }

        private void btn_AgregarCliente_Click(object sender, EventArgs e)
        {

            //Verificar espacios en blanco
            if (validarCampos())
            {
                MessageBox.Show("Faltan campos por llenar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                //Agregar Cliente a la BDD
                this.clientesTableAdapter.InsertarNuevoCliente(
                    txtNombre.Text, txtApellidoP.Text, txtApellidoM.Text,
                    txtDireccion.Text, txtColonia.Text, txtCiudad.Text,
                    txtCodigoPostal.Text, txt_correo.Text, txt_rfc.Text,txt_telefono.Text);
                //Mensaje de Confirmación            
                Limpiar();
                Program.isOpenMainClientForm = false;
                var resultado = MessageBox.Show("Cliente Registrado con Éxito, ¿Desea Agregar otro Cliente ? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

        private void despintarTexto(object sender, EventArgs e)
        {
            TextBox limpiar = (TextBox)sender;
            limpiar.BackColor = Color.White;
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
