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
    public partial class frm_Ventas : Form
    {        
        private Consultas.generarVenta generar = new Consultas.generarVenta();
        Ventas.frm_VentasAgregar generarVenta;

        private void limpiarVariablesVenta()
        {
            //Variables de Ventas
            Program.idClienteVenta = 0;
            Program.idVenta = 0;
            Program.idProductoVenta = 0;
            Program.ventaCreada = false;
        }

        public frm_Ventas()
        {
            InitializeComponent();            
        }

        private void AddFormInPanel(Form fh)
        {
            if (this.pnl_Contenido.Controls.Count > 0)
                this.pnl_Contenido.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.pnl_Contenido.Controls.Add(fh);
            this.pnl_Contenido.Tag = fh;
            fh.Show();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Ventas.frm_VentasAgregar form = Application.OpenForms.OfType<Ventas.frm_VentasAgregar>().FirstOrDefault();
            generarVenta = form ?? new Ventas.frm_VentasAgregar();
            AddFormInPanel(generarVenta);
            if (Program.ventaCreada == false)
            {                
                Program.ventaCreada = true;
            }
            Program.enActividadVenta = true;

            foreach (Control ctr in pnl_Menu.Controls)
            {
                if (ctr is Label)
                    ctr.Enabled = true;
                if (ctr is Button)
                    ctr.Enabled = true;
            }                        
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {            
            /*Ventas.frm_VentasAgregarProducto form = Application.OpenForms.OfType<Ventas.frm_VentasAgregarProducto>().FirstOrDefault();
            Ventas.frm_VentasAgregarProducto agregarProducto = form ?? new Ventas.frm_VentasAgregarProducto();
            AddFormInPanel(agregarProducto);                      */
            Ventas.frm_VentasAgregarProducto agregarProducto = new frm_VentasAgregarProducto();
            agregarProducto.ShowDialog();
            generarVenta.Close();
            Ventas.frm_VentasAgregar form = Application.OpenForms.OfType<Ventas.frm_VentasAgregar>().FirstOrDefault();
            generarVenta = form ?? new Ventas.frm_VentasAgregar();
            AddFormInPanel(generarVenta);

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            generar.restablecerID(1,"clientes");
            
            /*if (Program.idProductoVenta != 999)
            {
                Program.listaProductos.eliminarProducto(Program.idProductoVenta);
                generarVenta.Close();
                Ventas.frm_VentasAgregar form = Application.OpenForms.OfType<Ventas.frm_VentasAgregar>().FirstOrDefault();
                generarVenta = form ?? new Ventas.frm_VentasAgregar();
                AddFormInPanel(generarVenta);
            }
            else
                MessageBox.Show("No se ha seleccionado ningún producto para eliminar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        private void frm_Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.ventaCreada == true)
            {
                DialogResult resultadoDialogo = MessageBox.Show("Hay una venta sin finalizar se perderá los datos de la venta si usted sale. ¿Esta seguro que desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultadoDialogo == DialogResult.Yes)
                {
                    generarVenta.Close();
                    Program.ventaCreada = false;
                    limpiarVariablesVenta();
                    this.Close();
                }
                else
                    e.Cancel = true;         
            }            
        }
    }
}
