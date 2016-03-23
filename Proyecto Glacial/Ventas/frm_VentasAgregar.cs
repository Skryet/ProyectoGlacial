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
    public partial class frm_VentasAgregar : Form
    {
        private Consultas.consultasVentas consultas = new Consultas.consultasVentas();

        public frm_VentasAgregar()
        {
            InitializeComponent();
        }

        private void frm_VentasAgregar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.vista_venta_lista_productos' Puede moverla o quitarla según sea necesario.
            this.vista_venta_lista_productosTableAdapter.Fill(this.glacial_almacenDataSet.vista_venta_lista_productos);
            this.Location = new Point(300, 100);
        }

        private void btn_SeleccionarCliente_Click(object sender, EventArgs e)
        {
            Form agregarCliente = new frm_VentaSeleccionCliente();
            agregarCliente.ShowDialog();
            if (Program.idComprador != 0)
            {
                string nombreCliente = "";
                consultas.obtenerNombreCliente(ref nombreCliente, Program.idComprador);
                txt_Cliente.Text = nombreCliente;
            }
            else
                MessageBox.Show("Ha ocurrido un error al seleccionar el cliente, seleccionelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_SeleccionarEmpresa_Click(object sender, EventArgs e)
        {
            Form agregarEmpresa = new frm_VentasSeleccionEmpresa();
            agregarEmpresa.ShowDialog();
            if (Program.idComprador != 0)
            {
                string nombreEmpresa = "";
                consultas.obtenerNombreEmpresa(ref nombreEmpresa, Program.idComprador);
                txt_Empresa.Text = nombreEmpresa;
            }
            else
                MessageBox.Show("Ha ocurrido un error al seleccionar el cliente, seleccionelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void rbt_SinRegistro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_SinRegistro.Checked == true)
            {
                Program.idComprador = 0;
                txt_Cliente.Text = "";
                txt_Empresa.Text = "";
                txt_Cliente.Enabled = false;
                txt_Empresa.Enabled = false;
                btn_SeleccionarEmpresa.Enabled = false;
                btn_SeleccionarCliente.Enabled = false;
            }
        }

        private void rbt_Cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Cliente.Checked == true)
            {
                Program.idComprador = 0;
                txt_Cliente.Text = "";
                txt_Empresa.Text = "";
                txt_Cliente.Enabled = true;
                txt_Empresa.Enabled = false;
                btn_SeleccionarEmpresa.Enabled = false;
                btn_SeleccionarCliente.Enabled = true;
            }
        }

        private void rbt_Empresa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Empresa.Checked == true)
            {
                Program.idComprador = 0;
                txt_Cliente.Text = "";
                txt_Empresa.Text = "";
                txt_Cliente.Enabled = false;
                txt_Empresa.Enabled = true;
                btn_SeleccionarEmpresa.Enabled = true;
                btn_SeleccionarCliente.Enabled = false;
            }
        }
    }
}
