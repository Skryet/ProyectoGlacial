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
            Ventas.frm_VentasAgregar generarVenta = form ?? new Ventas.frm_VentasAgregar();
            AddFormInPanel(generarVenta);
            Program.ventaCreada = true;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            if (Program.ventaCreada == true)
            {
                generar.crearVenta(ref Program.idVenta, Program.idClienteVenta, Program.idEmpresaVenta);
            }
            Ventas.frm_VentasAgregarProducto form = Application.OpenForms.OfType<Ventas.frm_VentasAgregarProducto>().FirstOrDefault();
            Ventas.frm_VentasAgregarProducto agregarProducto = form ?? new Ventas.frm_VentasAgregarProducto();
            AddFormInPanel(agregarProducto);
        }
    }
}
