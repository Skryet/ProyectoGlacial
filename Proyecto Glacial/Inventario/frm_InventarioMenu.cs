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
        Form banFormModificar;
        Form banFormAgregar;
        Form banFormBuscar;
        public frm_InventarioMenu()
        {
            InitializeComponent();
        }
        
        public Inventario.frm_InventarioAgregar InventarioAgregarProductos;

        public Inventario.frm_InventarioBuscar InventarioBuscar;

        public Inventario.frm_InventarioModificar InventarioModificar;

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
            banFormModificar = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_InventarioModificar);
            banFormAgregar = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_InventarioAgregar);
            banFormBuscar = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_InventarioBuscar);
            if (banFormModificar != null)
                InventarioModificar.Close();
            if (banFormAgregar != null)
                InventarioAgregarProductos.Close();
            if (banFormBuscar != null)
                InventarioBuscar.Close();

            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
            InventarioBuscar = Application.OpenForms.OfType<Inventario.frm_InventarioBuscar>().FirstOrDefault();
            InventarioBuscar = InventarioBuscar ?? new Inventario.frm_InventarioBuscar();
            AddFormInPanel(InventarioBuscar);
            lbl_Estado.Text = "Almacén - Buscar Productos";        
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Form agregarProductos = new Inventario.frm_InventarioAgregar();
            agregarProductos.ShowDialog();
            //InventarioAgregarProductos = Application.OpenForms.OfType<Inventario.frm_InventarioAgregar>().FirstOrDefault();
            //InventarioAgregarProductos = InventarioAgregarProductos ?? new Inventario.frm_InventarioAgregar();
            //AddFormInPanel(InventarioAgregarProductos); 
            lbl_Estado.Text = "Almacén - Agregar Productos";
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Desea Eliminar este Producto con todos sus proveedores? ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Registro Eliminado con éxito!");
                this.productosTableAdapter.BorrarProductoPorID(Program.idProducto);
                this.proveedor_codigoTableAdapter.BorrarProductosProveedoresPorIDlista(Program.idListaProveedorActual);
                InventarioBuscar.Close();
                InventarioBuscar = Application.OpenForms.OfType<Inventario.frm_InventarioBuscar>().FirstOrDefault();
                InventarioBuscar = InventarioBuscar ?? new Inventario.frm_InventarioBuscar();
                AddFormInPanel(InventarioBuscar);
            }
        }

        private void productosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_InventarioMenu_Load(object sender, EventArgs e)
        {
            
            this.Location = new Point(300, 20);
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.proveedor_codigo' Puede moverla o quitarla según sea necesario.
            this.proveedor_codigoTableAdapter.Fill(this.glacial_almacenDataSet.proveedor_codigo);
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.productos' Puede moverla o quitarla según sea necesario.
            this.productosTableAdapter.Fill(this.glacial_almacenDataSet.productos);

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            InventarioModificar = Application.OpenForms.OfType<Inventario.frm_InventarioModificar>().FirstOrDefault();
            InventarioModificar = InventarioModificar ?? new Inventario.frm_InventarioModificar();
            AddFormInPanel(InventarioModificar);
            lbl_Estado.Text = "Almacén - Modificar Productos";
        }
    }
}
