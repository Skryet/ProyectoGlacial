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
        private Consultas.consultasVentas consultas;

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
            if (Program.idClienteVenta != 0)
            {
                string nombreCliente = "";
                consultas.obtenerNombreCliente(ref nombreCliente, Program.idClienteVenta);
                txt_Cliente.Text = nombreCliente;
            }
            else
                MessageBox.Show("Ha ocurrido un error al seleccionar el cliente, seleccionelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_SeleccionarEmpresa_Click(object sender, EventArgs e)
        {
            Form agregarEmpresa = new frm_VentasSeleccionEmpresa();
            agregarEmpresa.ShowDialog();
            if (Program.idClienteVenta != 0)
            {
                string nombreEmpresa = "";
                consultas.obtenerNombreCliente(ref nombreEmpresa, Program.idClienteVenta);
                txt_Cliente.Text = nombreEmpresa;
            }
            else
                MessageBox.Show("Ha ocurrido un error al seleccionar el cliente, seleccionelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
