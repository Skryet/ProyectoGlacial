﻿using System;
using System.Collections.Generic;
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

        public Manipular_DataGirdView(ref DataGridView data, ref TextBox subtotal, ref TextBox iva, ref TextBox total)
        {
            dgv = data;
            SubTotal = subtotal;
            IVA = iva;
            Total = total;
        }

        public void MostrarDatos_DataGridView()
        {
            dgv.Rows.Clear();
            Objetos.NodoProducto tmp = Program.listaProductosVenta.ObtenerLista();
            Objetos.NodoProducto recorrerLista = tmp;
            if (tmp != null)
            {
                for (int i = 0; i < Program.listaProductosVenta.CantidadElementos(); i++)
                {
                    double total = recorrerLista.Producto.Precio1 * recorrerLista.Producto.Cantidad;
                    dgv.Rows.Add(recorrerLista.Producto.idLineaProducto, recorrerLista.Producto.Nombre, recorrerLista.Producto.Descripcion, recorrerLista.Producto.Cantidad.ToString(),
                        recorrerLista.Producto.UnidadMedida, recorrerLista.Producto.Precio1.ToString(), total, "Precio 1");
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

            if (dgv.RowCount != 0)
            {
                for (int i = 0; i < dgv.RowCount; i++)
                    subtotal += Convert.ToDouble(dgv.Rows[i].Cells[6].Value);
                subtotal = Math.Round(subtotal, 2);
                iva = subtotal * 0.16;
                total = subtotal + iva;
                SubTotal.Text = subtotal.ToString();
                IVA.Text = iva.ToString();
                Total.Text = total.ToString();
            }
        }
    }
}
