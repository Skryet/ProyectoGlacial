﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
        private Consultas.GenerarAutocompletado autocompletado = new Consultas.GenerarAutocompletado();
        private frm_AutocompletadoProductos autocompletar;
        private int cantidadPrevia;


        public frm_VentasAgregar()
        {
            InitializeComponent();
            Program.manipularDatos = new Objetos.Manipular_DataGirdView(ref dgv_ListaVenta, ref txt_Subtotal, ref txt_IVA, ref txt_Total, ref txt_Descuento, ref txt_DescuentoPorcentaje);
        }

        private void limpiarVariablesVenta()
        {
            //Variables de Ventas
            Program.idClienteVenta = 0;            
            Program.idVenta = 0;
            Program.idProductoVenta = "";
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
            this.Location = new Point(300, 100);
            generarTotalVenta();

            //Mostar nombre de cliente al regresar al menu
            if (Program.idClienteVenta != 0)
            {
                int temp_idClienteVenta = Program.idClienteVenta;
                string nombreCliente = "";
                consultas.obtenerNombreCliente(ref nombreCliente, Program.idClienteVenta);                
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
                Program.manipularDatos.generarTotalVenta();
            }            
        }               

        private void btn_Finalizar_Click(object sender, EventArgs e)
        {
            if (dgv_ListaVenta.RowCount != 0)
            {
                /*Objetos.Venta venta = new Objetos.Venta();
                //ASIGNAR VARIABLES DE VENTA
                venta.idCliente = Program.idCliente;
                venta.Subtotal = Convert.ToDouble(txt_Subtotal.Text);
                venta.Descuento = Convert.ToDouble(txt_Descuento.Text);
                venta.IVA = Convert.ToDouble(txt_IVA.Text);
                venta.Total = Convert.ToDouble(txt_Total.Text);
                venta.Fecha = DateTime.Now;
                consultasVentas.agregarVenta(venta);

                //AGREGAR PRODUCTOS A LA CONSULTA
                

                //EJECUTAR CONSULTA
                consultasVentas.ejecutarConsulta();*/


                Program.enActividadVenta = false;
                Program.ventaCreada = false;
                limpiarVariablesVenta();
                this.Close();
            }
            else
                MessageBox.Show("No se han agregado productos a la venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

            if (e.KeyChar == (char)Keys.Enter)
            {
                Program.manipularDatos.generarTotalVenta();
            }
        }

        private void txt_DescuentoPorcentaje_Leave(object sender, EventArgs e)
        {
            if (txt_DescuentoPorcentaje.Text == "")
                txt_DescuentoPorcentaje.Text = "0.00";
        }

        private void dgv_ListaVenta_Click(object sender, EventArgs e)
        {
            if (dgv_ListaVenta.Rows.Count != 0)
            {
                if (Convert.ToString(dgv_ListaVenta.Rows[0].Cells[0].Value) != "")
                    Program.idProductoVenta = dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[0].Value.ToString();
            }                                     
        }     

        private void Activar_Referencia(object sender, EventArgs e)
        {
            if (rbt_Cheque.Checked == true || rbt_TarjetaDebito.Checked == true || rbt_TarjetaCredito.Checked == true)
                txt_Referencia.Enabled = true;
            else
                txt_Referencia.Enabled = false;
        }

        private void txt_Producto_KeyUp(object sender, KeyEventArgs e)
        {            
            if (e.KeyCode != Keys.Enter && e.KeyCode != Keys.Escape)
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    string nombreForm = Application.OpenForms[i].ToString();
                    Form abierto = Application.OpenForms[i];
                    if (nombreForm.Contains("frm_AutocompletadoProductos") != false)
                    {
                        abierto.Close();
                    }
                }
                Program.listaProductosAutocompletar = new Objetos.ListaEnlazadaProductos();
                if (cbx_TipoBusqueda.SelectedItem.ToString() == "Código")
                {                    
                    string codigo = txt_Producto.Text.ToString();
                    autocompletado.llenarListaAutocompletarCodigo(codigo, Program.listaProductosAutocompletar, false);
                    Point localizacion = txt_Producto.Location;
                    Form activeform = Form.ActiveForm;
                    autocompletar = new frm_AutocompletadoProductos(localizacion, ref txt_Producto);
                    autocompletar.Show(this);                    
                    activeform.BringToFront();                                        
                }
                else if (cbx_TipoBusqueda.SelectedItem.ToString() == "Descripción")
                {
                    string descripcion = txt_Producto.Text.ToString();
                    autocompletado.llenarListaAutocompletarDescripcion(descripcion, Program.listaProductosAutocompletar, false);
                    Point localizacion = txt_Producto.Location;
                    Form activeform = Form.ActiveForm;
                    autocompletar = new frm_AutocompletadoProductos(localizacion, ref txt_Producto);
                    autocompletar.Show(this);
                    activeform.BringToFront();
                }                
            }
            if (txt_Producto.Text == "")
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    string nombreForm = Application.OpenForms[i].ToString();
                    Form abierto = Application.OpenForms[i];
                    if (nombreForm.Contains("frm_AutocompletadoProductos") != false)
                    {
                        abierto.Close();
                    }
                }
            }
            if (e.KeyCode == Keys.Escape)
            {
                for (int i = 0; i < Application.OpenForms.Count; i++)
                {
                    string nombreForm = Application.OpenForms[i].ToString();
                    Form abierto = Application.OpenForms[i];
                    if (nombreForm.Contains("frm_AutocompletadoProductos") != false)
                    {
                        abierto.Close();
                    }
                }
            }
        }        

        private void dgv_ListaVenta_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (e.Control is DataGridViewComboBoxEditingControl)
            {
                DataGridViewComboBoxEditingControl CellComboBox = (DataGridViewComboBoxEditingControl)e.Control;
                CellComboBox.SelectionChangeCommitted -= new EventHandler(Verificar_ComboBox);
                if (dgv_ListaVenta.CurrentCell.ColumnIndex == 7)
                {
                    CellComboBox.SelectionChangeCommitted += new EventHandler(Verificar_ComboBox);
                }
            }
        }

        void Verificar_ComboBox(object sender, EventArgs e)
        {
            ComboBox cbx = (ComboBox)sender;        
            string precio = dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[7].Value.ToString();
            string codigo = dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[0].Value.ToString();

            switch (cbx.SelectedItem.ToString())
            {
                case "Especial":
                    dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[5].Value = (Program.listaProductosVenta.obtenerProducto(codigo).Producto.PrecioEspecial).ToString("C");
                    Program.listaProductosVenta.EstablecerPrecio(Program.listaProductosVenta.obtenerProducto(codigo).Producto.PrecioEspecial, codigo);
                    break;
                case "Precio 1":
                    dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[5].Value = (Program.listaProductosVenta.obtenerProducto(codigo).Producto.Precio1).ToString("C");
                    Program.listaProductosVenta.EstablecerPrecio(Program.listaProductosVenta.obtenerProducto(codigo).Producto.Precio1, codigo);
                    break;
                case "Precio 2":
                    dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[5].Value = (Program.listaProductosVenta.obtenerProducto(codigo).Producto.Precio2).ToString("C");
                    Program.listaProductosVenta.EstablecerPrecio(Program.listaProductosVenta.obtenerProducto(codigo).Producto.Precio2, codigo);
                    break;
                case "Precio 3":
                    dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[5].Value = (Program.listaProductosVenta.obtenerProducto(codigo).Producto.Precio3).ToString("C");
                    Program.listaProductosVenta.EstablecerPrecio(Program.listaProductosVenta.obtenerProducto(codigo).Producto.Precio3, codigo);
                    break;
                case "Libre":
                    frm_AsignarPrecioLibre asignarPrecio = new frm_AsignarPrecioLibre(dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[0].Value.ToString());                    
                    asignarPrecio.ShowDialog();
                    dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[5].Value = Program.listaProductosVenta.obtenerProducto(dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[0].Value.ToString()).Producto.PrecioEstablecido;
                    break;
            }
            int cantidad = Convert.ToInt32(dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[3].Value);
            double precioUnidad = double.Parse(dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[5].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
            dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[6].Value = (cantidad * precioUnidad).ToString("C");
            Program.manipularDatos.generarTotalVenta();
        }

        private void dgv_ListaVenta_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[3].IsInEditMode)
            {
                if (Program.listaProductosVenta.ComprobarExistencia(Convert.ToInt32(dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[3].Value), dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[0].Value.ToString()) == false)
                {
                    int cantidad = Convert.ToInt32(dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[3].Value);
                    double precio = double.Parse(dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[5].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[6].Value = (cantidad * precio).ToString("C");
                    Program.manipularDatos.generarTotalVenta();
                }
                else
                {
                    dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[3].Value = cantidadPrevia;
                    MessageBox.Show("La cantidad asignada supera el límite de la cantidad existente en almacén.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void dgv_ListaVenta_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            cantidadPrevia = Convert.ToInt32(dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[3].Value);
        }

        private void dgv_ListaVenta_DoubleClick(object sender, EventArgs e)
        {
            int id = Program.listaProductosVenta.obtenerProducto(dgv_ListaVenta.Rows[dgv_ListaVenta.CurrentCellAddress.Y].Cells[0].Value.ToString()).Producto.idProducto;
            Program.idProducto = id;
            Inventario.frm_InventarioVisualizarProducto DetalleProducto = new Inventario.frm_InventarioVisualizarProducto();
            DetalleProducto.ShowDialog();
            Program.idProducto = 0;
        }

        private void txt_DescuentoPorcentaje_Enter(object sender, EventArgs e)
        {
            txt_DescuentoPorcentaje.Text = "";
        }
    }
}
