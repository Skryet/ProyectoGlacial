using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Compras
{
    public partial class frm_ComprasMenu : Form
    {
        Form banFormModificar;
        Form banFormAgregar;
        Form banFormBuscar;

        //public Compras.frm_ClientesModificar ClientesModificar;
        public Compras.frm_ComprasBuscar ComprasBuscar;
        public Compras.frm_ComprasAgregar ComprasAgregar;

        public frm_ComprasMenu()
        {
            InitializeComponent();
        }

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

        private void btn_BuscarTodo_Click(object sender, EventArgs e)
        {
            banFormModificar = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Clientes.frm_ClientesModificar);
            banFormAgregar = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_ClientesAgregar);
            banFormBuscar = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Clientes.frm_ClientesBuscar);
            if (banFormModificar != null)
                banFormModificar.Close();
            if (banFormAgregar != null)
                banFormAgregar.Close();
            if (banFormBuscar != null)
                banFormBuscar.Close();

            ComprasBuscar = Application.OpenForms.OfType<Compras.frm_ComprasBuscar>().FirstOrDefault();
            ComprasBuscar = ComprasBuscar ?? new Compras.frm_ComprasBuscar();
            AddFormInPanel(ComprasBuscar);
            lbl_Estado.Text = "Glacial - Buscar Compras";
            // this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);

            btn_Eliminar.Enabled = true;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            banFormModificar = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Clientes.frm_ClientesModificar);
            banFormAgregar = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_ClientesAgregar);
            banFormBuscar = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Clientes.frm_ClientesBuscar);
            if (banFormModificar != null)
                banFormModificar.Close();
            if (banFormAgregar != null)
                banFormAgregar.Close();
            if (banFormBuscar != null)
                banFormBuscar.Close();

            ComprasAgregar = Application.OpenForms.OfType<Compras.frm_ComprasAgregar>().FirstOrDefault();
            ComprasAgregar = ComprasAgregar ?? new Compras.frm_ComprasAgregar();
            AddFormInPanel(ComprasAgregar);
            lbl_Estado.Text = "Glacial - Agregar Compras";
           // this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);

            btn_Eliminar.Enabled = false;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("¿Está seguro de eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {

                //Eliminar Compra y Lista
                ComprasBuscar.Close();
                this.comprasTableAdapter.BorrarCompraPorID(Program.idCompra);
                this.lista_material_comprasTableAdapter.BorrarListaCompras(Program.idCompra);
                MessageBox.Show("Registro Eliminado con éxito!", "Completado");

                //Mandar a llamar el formulario de BuscarTodo
                ComprasBuscar = Application.OpenForms.OfType<Compras.frm_ComprasBuscar>().FirstOrDefault();
                ComprasBuscar = ComprasBuscar ?? new Compras.frm_ComprasBuscar();
                AddFormInPanel(ComprasBuscar);
                lbl_Estado.Text = "Glacial - Buscar Compras";
            }
        }

        private void comprasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.comprasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_ComprasMenu_Load(object sender, EventArgs e)
        {
            this.Location = new Point(300, 5);
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.lista_material_compras' Puede moverla o quitarla según sea necesario.
            this.lista_material_comprasTableAdapter.Fill(this.glacial_almacenDataSet.lista_material_compras);
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.compras' Puede moverla o quitarla según sea necesario.
            this.comprasTableAdapter.Fill(this.glacial_almacenDataSet.compras);

        }
    }
}
