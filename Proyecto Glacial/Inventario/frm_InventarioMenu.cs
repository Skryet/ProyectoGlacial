using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Inventario
{
    public partial class frm_InventarioMenu : Form
    {
        public frm_InventarioMenu()
        {
            InitializeComponent();
        }

        public Inventario.frm_InventarioAgregar InventarioAgregarProductos;

        public void AddFormInPanel(Form fh)
        {
            if (this.pnl_ContenidoCentro.Controls.Count > 0)
                this.pnl_ContenidoCentro.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.pnl_ContenidoCentro.Controls.Add(fh);
            this.pnl_ContenidoCentro.Tag = fh;
            fh.Show();
        }

        private void pnl_ContenidoCentro_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_BuscarTodo_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            InventarioAgregarProductos = Application.OpenForms.OfType<Inventario.frm_InventarioAgregar>().FirstOrDefault();
            InventarioAgregarProductos = InventarioAgregarProductos ?? new Inventario.frm_InventarioAgregar();
            AddFormInPanel(InventarioAgregarProductos);
            lbl_Estado.Text = "Almacén - Agregar Productos";
            
        }
    }
}
