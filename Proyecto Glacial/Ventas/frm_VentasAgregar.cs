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
                rbt_SinRegistro.Enabled = false;
            }
        }

        private void limpiarVariablesVenta()
        {
            //Variables de Ventas
            Program.idClienteVenta = 0;            
            Program.idVenta = 0;
            Program.idProductoVenta = 999;
            Program.ventaCreada = false;
        }

        private void generarTotalVenta()
        {
            double subtotal = 0;
            double iva = 0;
            double total = 0;

            if (dgv_ListaVenta.RowCount != 0)
            {
                for (int i = 0; i < dgv_ListaVenta.RowCount; i++)
                    subtotal += Convert.ToDouble(dgv_ListaVenta.Rows[i].Cells[5].Value);
                subtotal = Math.Round(subtotal, 2);
                iva = subtotal * 0.16;
                total = subtotal + iva;
                txt_Subtotal.Text = subtotal.ToString();
                txt_IVA.Text = iva.ToString();
                txt_Total.Text = total.ToString();
            }
        }

        private void frm_VentasAgregar_Load(object sender, EventArgs e)
        {
            //Llenar dgv_ListaProductos
            Ventas.Objetos.materialVenta[] lista = Program.listaProductos.obtenerLista();
            for (int i = 0; i < Program.listaProductos.obtenerLargo(); i++)
                dgv_ListaVenta.Rows.Add(lista[i].Linea, lista[i].Codigo, lista[i].Descripcion, lista[i].unidadMedida, lista[i].Cantidad, lista[i].precioUnidad, lista[i].Total);
   
            if (dgv_ListaVenta.RowCount != 0)
                dgv_ListaVenta.CurrentRow.Selected = false;                      

            this.Location = new Point(300, 100);
            generarTotalVenta();

            //Mostar nombre de cliente al regresar al menu
            if (Program.idClienteVenta != 0)
            {
                int temp_idClienteVenta = Program.idClienteVenta;
                string nombreCliente = "";
                consultas.obtenerNombreCliente(ref nombreCliente, Program.idClienteVenta);
                rbt_Cliente.Checked = true;
                txt_Cliente.Text = nombreCliente;
                Program.idClienteVenta = temp_idClienteVenta;             
            }
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
       
        private void rbt_SinRegistro_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_SinRegistro.Checked == true)
            {
                Program.idClienteVenta = 0;                
                txt_Cliente.Text = "";                
                txt_Cliente.Enabled = false;
                btn_SeleccionarCliente.Enabled = false;
            }
        }

        private void rbt_Cliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rbt_Cliente.Checked == true)
            {
                Program.idClienteVenta = 0;                
                txt_Cliente.Text = "";                
                txt_Cliente.Enabled = true;                
                btn_SeleccionarCliente.Enabled = true;
            }
        }       

        private void btn_Cancelar_Click(object sender, EventArgs e)
         {
            if (Program.ventaCreada == true)
            {
                consultasVentas.borrarVenta(Program.idVenta);
                limpiarVariablesVenta();
                Program.ventaCreada = false;
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

        private void btn_Finalizar_Click(object sender, EventArgs e)
        {
            if (dgv_ListaVenta.RowCount != 0)
            {
                Objetos.Venta venta = new Objetos.Venta();
                //ASIGNAR VARIABLES DE VENTA
                venta.idCliente = Program.idCliente;
                venta.Subtotal = Convert.ToDouble(txt_Subtotal.Text);
                venta.Descuento = Convert.ToDouble(txt_Descuento.Text);
                venta.IVA = Convert.ToDouble(txt_IVA.Text);
                venta.Total = Convert.ToDouble(txt_Total.Text);
                venta.Fecha = DateTime.Now;
                consultasVentas.agregarVenta(venta);

                //AGREGAR PRODUCTOS A LA CONSULTA
                for (int i = 0; i < Program.listaProductos.obtenerLargo(); i++)                
                    consultasVentas.agregarProductos(Program.listaProductos.obtenerProducto(i));

                //EJECUTAR CONSULTA
                consultasVentas.ejecutarConsulta();                


                Program.enActividadVenta = false;
                Program.ventaCreada = false;
                limpiarVariablesVenta();
                this.Close();
            }
            else
                MessageBox.Show("No se han agregado productos a la venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void frm_VentasAgregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
        private void validarDecimas(object sender, KeyPressEventArgs e)

        {
            TextBox textEvalua = new TextBox();
            if (sender is Control)            
                textEvalua = sender as TextBox;                            

            if (e.KeyChar == 8)
            {
                e.Handled = false;
                return;
            }

            bool IsDec = false;
            int nroDec = 0;
            for (int i = 0; i < textEvalua.Text.Length; i++)
            {
                if (textEvalua.Text[i] == '.')
                    IsDec = true;

                if (IsDec && nroDec++ >= 2)
                {
                    e.Handled = true;
                    return;
                }
            }

            if (e.KeyChar >= 48 && e.KeyChar <= 57)
                e.Handled = false;
            else if (e.KeyChar == 46)
                e.Handled = (IsDec) ? true : false;
            else
                e.Handled = true;
        }

        private void txt_DescuentoPorcentaje_Leave(object sender, EventArgs e)
        {
            double subtotal = Convert.ToDouble(txt_Subtotal.Text);
            double descuento = subtotal * (Convert.ToDouble(txt_DescuentoPorcentaje.Text)/100);
            subtotal = subtotal - descuento;
            if (subtotal > 0)
                txt_Descuento.Text = descuento.ToString();
            else
            {
                MessageBox.Show("La cantidad que desea descontar es mayor que el subtotal", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_DescuentoPorcentaje.Text = "0.00";
            }
        }

        private void dgv_ListaVenta_Click(object sender, EventArgs e)
        {
            if (Convert.ToString(dgv_ListaVenta.Rows[0].Cells[0].Value) != "")
                Program.idProductoVenta = Convert.ToInt32(dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[1].Value);
        }

        private void dgv_ListaVenta_Enter(object sender, EventArgs e)
        {
            dgv_ListaVenta.AllowUserToAddRows = true;
        }

        private void dgv_ListaVenta_Leave(object sender, EventArgs e)
        {
            dgv_ListaVenta.AllowUserToAddRows = false;
        }
    }
}
