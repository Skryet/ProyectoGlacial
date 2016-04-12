using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Inventario.Inventario_Proveedores
{
    public partial class frm_InventarioAgregarDatosProveedoProducto : Form
    {
        public frm_InventarioAgregarDatosProveedoProducto()
        {
            InitializeComponent();
        }

        //Limpiar campos
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

        //Despintar texto
        private void despintarTexto(object sender, EventArgs e)
        {
            TextBox limpiar = (TextBox)sender;
            limpiar.BackColor = Color.White;
        }

        //Validar Campos
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
        private void but_agregarProveedor_Click(object sender, EventArgs e)
        {
            btn_agregar.Enabled = true;
            Form frm_ProveedoresBuscar = new Inventario.Inventario_Proveedores.frm_ProveedoresBuscarParaProducto();
            frm_ProveedoresBuscar.Show();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (!validarCampos())
            {
                //Agregar Proveedor a la lista de proveedores del producto
                this.proveedor_codigoTableAdapter.InsertarProveedorCodigoConIdLista(Convert.ToInt32(txt_idProveedor.Text), txt_codigo.Text, Convert.ToDouble(txt_precio.Text), txt_Medida.Text, Program.idListaProveedorActual);

                //Mensaje de Confirmación            
                var resultado = MessageBox.Show("Proveedor del Producto Registrado con Éxito, ¿Desea Agregar otro Proveedor ? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.No)
                {
                    this.Close();
                }
                else
                {
                    limpiarCampos();
                    btn_agregar.Enabled = false;
                }
            }
            else
            {
                MessageBox.Show("Faltan campos por llenar");
            }


        }

        private void frm_InventarioAgregarDatosProveedoProducto_Activated(object sender, EventArgs e)
        {
            txt_idProveedor.Text = Program.idProveedor.ToString();
            txt_proveedor.Text = Program.nombreProveedor;
        }

        private void proveedor_codigoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();

        }

        private void proveedor_codigoBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedor_codigoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_InventarioAgregarDatosProveedoProducto_Load(object sender, EventArgs e)
        {
            
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.proveedor_codigo' Puede moverla o quitarla según sea necesario.
            //this.proveedor_codigoTableAdapter.Fill(this.glacial_almacenDataSet.proveedor_codigo);

        }



        private void txt_Medida_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isChar(e);
        }

        private void txt_precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Program.metodosOptimizar.isDecimalPoint(e);
        }


        private void frm_InventarioAgregarDatosProveedoProducto_FormClosed(object sender, FormClosedEventArgs e)
        {
            limpiarCampos();
            Program.idProveedor = 0;
            Program.nombreProveedor = "";
        }

        private void frm_InventarioAgregarDatosProveedoProducto_Load_1(object sender, EventArgs e)
        {
            this.Location = new Point(300, 100);
        }
    }
}
