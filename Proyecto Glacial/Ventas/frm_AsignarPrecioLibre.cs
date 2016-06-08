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
    public partial class frm_AsignarPrecioLibre : Form
    {
        string CodigoProducto;

        public frm_AsignarPrecioLibre(string codigoProducto)
        {
            InitializeComponent();
            CodigoProducto = codigoProducto;
            lbl_Poducto.Text += " " +codigoProducto + ":";
        }

        private void txt_PrecioLibre_KeyPress(object sender, KeyPressEventArgs e)
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
                if (Program.listaProductosVenta.obtenerProducto(CodigoProducto).Producto.Precio1 < Convert.ToDouble(txt_PrecioLibre.Text))
                {
                    Program.listaProductosVenta.obtenerProducto(CodigoProducto).Producto.PrecioEstablecido = Convert.ToDouble(txt_PrecioLibre.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("El precio establecido supera el limite", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txt_PrecioLibre.Text = "";
                }       
            }
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (Program.listaProductosVenta.obtenerProducto(CodigoProducto).Producto.Precio1 < Convert.ToDouble(txt_PrecioLibre.Text))
            {
                Program.listaProductosVenta.obtenerProducto(CodigoProducto).Producto.PrecioEstablecido = Convert.ToDouble(txt_PrecioLibre.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("El precio establecido supera el limite", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txt_PrecioLibre.Text = "";
            }
        }
    }
}
