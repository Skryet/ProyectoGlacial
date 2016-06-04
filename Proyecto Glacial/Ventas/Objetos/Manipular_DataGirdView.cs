using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Ventas.Objetos
{
    class Manipular_DataGirdView
    {
        private DataGridView dgv;
        private TextBox SubTotal;
        private TextBox IVA;
        private TextBox Total;
        private TextBox Descuento;
        private TextBox DescuentoPorcentage;

        public Manipular_DataGirdView(ref DataGridView data, ref TextBox subtotal, ref TextBox iva, ref TextBox total, ref TextBox descuento, ref TextBox descuentoPorcentage)
        {
            dgv = data;
            Descuento = descuento;
            DescuentoPorcentage = descuentoPorcentage;   
            SubTotal = subtotal;
            IVA = iva;
            Total = total;
        }

        public void MostrarDatos_DataGridView()
        {
            dgv.Rows.Clear();
            Objetos.NodoProducto tmp = Program.listaProductosVenta.ObtenerLista();
            Objetos.NodoProducto recorrerLista = tmp;
            double limiteDescuento = 0;
            if (tmp != null)
            {
                for (int i = 0; i < Program.listaProductosVenta.CantidadElementos(); i++)
                {
                    double total = recorrerLista.Producto.PrecioEstablecido * recorrerLista.Producto.Cantidad;
                    string precio = "";
                    if (recorrerLista.Producto.PrecioEstablecido == recorrerLista.Producto.Precio1)
                        precio = "Precio 1";
                    else if (recorrerLista.Producto.PrecioEstablecido == recorrerLista.Producto.Precio2)
                        precio = "Precio 2";
                    else if (recorrerLista.Producto.PrecioEstablecido == recorrerLista.Producto.Precio3)
                        precio = "Precio 3";
                    else if (recorrerLista.Producto.PrecioEstablecido == recorrerLista.Producto.PrecioEspecial)
                        precio = "Especial";
                    else
                        precio = "Libre";                    
                    dgv.Rows.Add(recorrerLista.Producto.idLineaProducto, recorrerLista.Producto.Nombre, recorrerLista.Producto.Descripcion, recorrerLista.Producto.Cantidad.ToString(),
                        recorrerLista.Producto.UnidadMedida, recorrerLista.Producto.PrecioEstablecido.ToString("C"), total.ToString("C"), precio);
                    recorrerLista = recorrerLista.Siguiente;
                }
            }
            dgv.Refresh();
        }

        public void generarTotalVenta()
        {
            double subtotal = 0;
            double iva = 0;
            double total = 0;
            double limiteDescuento = 0;

            if (dgv.RowCount != 0)
            {
                for (int i = 0; i < dgv.RowCount; i++)
                {
                    subtotal += double.Parse(dgv.Rows[i].Cells[6].Value.ToString(), NumberStyles.Currency, CultureInfo.GetCultureInfo("en-US"));
                    limiteDescuento += Program.listaProductosVenta.obtenerProducto(dgv.Rows[i].Cells[0].Value.ToString()).Producto.Precio1 * Convert.ToInt32(dgv.Rows[i].Cells[3].Value);
                }
                double descuento = CalcularDescuento(subtotal);
                if (limiteDescuento > subtotal - descuento)
                {
                    MessageBox.Show("El descuento no puede ser aplicado ya que supera el límite permitido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    subtotal = Math.Round(subtotal, 2);
                    Descuento.Text = "$0.00";
                    DescuentoPorcentage.Text = "0.00";
                }
                else                
                    subtotal = Math.Round(subtotal, 2) - descuento;
                iva = subtotal * 0.16;
                total = subtotal + iva;                
            }

            SubTotal.Text = subtotal.ToString("C");
            IVA.Text = decimal.Round(Convert.ToDecimal(iva), 2).ToString("C");
            Total.Text = decimal.Round(Convert.ToDecimal(total), 2).ToString("C");
        }

        private double CalcularDescuento(double subtotal)
        {
            double CantidadDescuento = 0;
            double PorcentageDescontar = Convert.ToDouble(DescuentoPorcentage.Text) / 100;
            CantidadDescuento = Convert.ToDouble(decimal.Round(Convert.ToDecimal(subtotal * PorcentageDescontar), 2));
            Descuento.Text = CantidadDescuento.ToString("C");
            return CantidadDescuento;
        }
    }
}
