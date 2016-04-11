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
    public partial class frm_Proveedores : Form
    {                
        private Proveedores.frm_ProveedorBuscar form;
        private Proveedores.frm_ProveedorBuscar ProveedorBuscar;

        public frm_Proveedores()
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
       
        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Program.idProveedor != 0)
            {
                DialogResult resultadoDialogo = MessageBox.Show("Esta seguro de eliminar el proveedor ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultadoDialogo == DialogResult.Yes)
                {
                    proveedoresTableAdapter.BorrarProveedor(Program.idProveedor);
                    proveedoresTableAdapter.Fill(this.glacial_almacenDataSet.proveedores);
                    Program.idProveedor = 0;
                    ProveedorBuscar.Close();
                    form = Application.OpenForms.OfType<Proveedores.frm_ProveedorBuscar>().FirstOrDefault();
                    ProveedorBuscar = form ?? new Proveedores.frm_ProveedorBuscar();                    
                    AddFormInPanel(ProveedorBuscar);
                }
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
            AddFormInPanel(ProveedorBuscar);
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
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
