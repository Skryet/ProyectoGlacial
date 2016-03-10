using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial
{
    public delegate void insertarID(int id);    

    public partial class frm_Proveedores : Form
    {        
        private int id;
        private Proveedores.frm_ProveedorBuscar form;
        private Proveedores.frm_ProveedorBuscar ProveedorBuscar;

        public frm_Proveedores()
        {            
            InitializeComponent();
            id = 0;            
        }

        public void insertado(int idInsertado)
        {
            id = idInsertado;
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
       
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (id != 0)
            {
                proveedoresTableAdapter.BorrarProveedor(id);
                proveedoresTableAdapter.Fill(this.glacial_almacenDataSet.proveedores);
                id = 0;
                ProveedorBuscar.Close();
                form = Application.OpenForms.OfType<Proveedores.frm_ProveedorBuscar>().FirstOrDefault();
                ProveedorBuscar = form ?? new Proveedores.frm_ProveedorBuscar();
                ProveedorBuscar.Insertar += new insertarID(insertado);                
                AddFormInPanel(ProveedorBuscar);
            }
            else
                MessageBox.Show("No se a seleccionado ningun registro para la eliminacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }        

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Proveedores.frm_ProveedorAgregar form = Application.OpenForms.OfType<Proveedores.frm_ProveedorAgregar>().FirstOrDefault();
            Proveedores.frm_ProveedorAgregar ProveedorAgregar= form ?? new Proveedores.frm_ProveedorAgregar();
            AddFormInPanel(ProveedorAgregar);
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            form = Application.OpenForms.OfType<Proveedores.frm_ProveedorBuscar>().FirstOrDefault();
            ProveedorBuscar = form ?? new Proveedores.frm_ProveedorBuscar();
            ProveedorBuscar.Insertar += new insertarID(insertado);
            AddFormInPanel(ProveedorBuscar);
        }

        private void proveedoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.proveedoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_Proveedores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'glacial_almacenDataSet.proveedores' table. You can move, or remove it, as needed.
            this.proveedoresTableAdapter.Fill(this.glacial_almacenDataSet.proveedores);

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Program.idProveedor != 0)
            {
                Proveedores.frm_ProveedorModificar form = Application.OpenForms.OfType<Proveedores.frm_ProveedorModificar>().FirstOrDefault();
                Proveedores.frm_ProveedorModificar ProveedorModificar = form ?? new Proveedores.frm_ProveedorModificar();
                AddFormInPanel(ProveedorModificar);                
            }
            else
                MessageBox.Show("No se a seleccionado ningun registro para la modificación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }        
    }
}
