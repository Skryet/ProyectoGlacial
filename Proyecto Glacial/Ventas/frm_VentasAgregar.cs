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
        private Consultas.generarVenta consultasVentas = new Consultas.generarVenta();
                            
        public frm_VentasAgregar()
        {
            InitializeComponent();
            if (Program.ventaCreada == true)
            {
                rbt_Cliente.Enabled = false;
                rbt_Empresa.Enabled = false;
                rbt_SinRegistro.Enabled = false;
            }
        }

        private void limpiarVariablesVenta()
        {
            //Variables de Ventas
            Program.idClienteVenta = 0;
            Program.idEmpresaVenta = 0;
            Program.idVenta = 0;
            Program.idProductoVenta = 0;
            Program.ventaCreada = false;
        }        

        private void frm_VentasAgregar_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.vista_venta_lista_productos' Puede moverla o quitarla según sea necesario.
            this.vista_venta_lista_productosTableAdapter.BuscarIDVenta(this.glacial_almacenDataSet.vista_venta_lista_productos, Program.idVenta);
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
            if (Program.idEmpresaVenta != 0)
            {
                string nombreEmpresa = "";
                consultas.obtenerNombreEmpresa(ref nombreEmpresa, Program.idEmpresaVenta);
                txt_Empresa.Text = nombreEmpresa;
            }
            else
                MessageBox.Show("Ha ocurrido un error al seleccionar el cliente, seleccionelo de nuevo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void rbt_SinRegistro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_SinRegistro.Checked == true)
            {
                Program.idClienteVenta = 0;
                Program.idEmpresaVenta = 0;
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
                Program.idClienteVenta = 0;
                Program.idEmpresaVenta = 0;
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
                Program.idClienteVenta = 0;
                Program.idEmpresaVenta = 0;
                txt_Cliente.Text = "";
                txt_Empresa.Text = "";
                txt_Cliente.Enabled = false;
                txt_Empresa.Enabled = true;
                btn_SeleccionarEmpresa.Enabled = true;
                btn_SeleccionarCliente.Enabled = false;
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            if (Program.ventaCreada == true)
            {
                consultasVentas.borrarVenta(Program.idVenta);
                limpiarVariablesVenta();
                this.Close();
            }
            else
            {
                limpiarVariablesVenta();
                this.Close();
            }
        }

        private void btn_Descuento_Click(object sender, EventArgs e)
        {
            if (btn_Descuento.Text == "Aplicar Descuento")
            {
                btn_Descuento.Text = "Quitar descuento";
                pnl_Descuento.Visible = true;
            }

            else if (btn_Descuento.Text == "Quitar descuento")
            {
                btn_Descuento.Text = "Aplicar Descuento";
                foreach (Control ctr in pnl_Descuento.Controls)
                {
                    if (ctr is TextBox)
                        ctr.Text = "0.00";
                }
                pnl_Descuento.Visible = false;
            }            
        }

        private void rbt_Porcentage_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Porcentage.Checked == false)
            {
                lbl_Porcentaje.Enabled = false;
                txt_DescuentoPorcentaje.Text = "0.00";
                txt_DescuentoPorcentaje.Enabled = false;
            }
            else
            {
                lbl_Porcentaje.Enabled = true;                
                txt_DescuentoPorcentaje.Enabled = true;
            }
        }

        private void rdb_Cantidad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Cantidad.Checked == false)
            {
                lbl_Cantidad.Enabled = false;
                txt_DescuentoCantidad.Text = "0.00";
                txt_DescuentoCantidad.Enabled = false;
            }
            else
            {
                lbl_Cantidad.Enabled = true;
                txt_DescuentoCantidad.Enabled = true;
            }
        }
    }
}
