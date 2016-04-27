using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Empresa
{
    public partial class frm_Empresas : Form
    {
        private Empresa.frm_EmpresaBuscar form;
        private Empresa.frm_EmpresaBuscar EmpresaBuscar;

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

        public frm_Empresas()
        {
            InitializeComponent();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            form = Application.OpenForms.OfType<Empresa.frm_EmpresaBuscar>().FirstOrDefault();
            EmpresaBuscar = form ?? new Empresa.frm_EmpresaBuscar();
            AddFormInPanel(EmpresaBuscar);
            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Empresa.frm_EmpresaAgregar form = Application.OpenForms.OfType<Empresa.frm_EmpresaAgregar>().FirstOrDefault();
            Empresa.frm_EmpresaAgregar EmpresaAgregar = form ?? new Empresa.frm_EmpresaAgregar();
            AddFormInPanel(EmpresaAgregar);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (Program.idProveedor != 0)
            {
                DialogResult resultadoDialogo = MessageBox.Show("Esta seguro de eliminar la empresa ", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (resultadoDialogo == DialogResult.Yes)
                {
                    //      empresaTableAdapter.BorrarEmpresa(Program.idProveedor);
                    // empresaTableAdapter.Fill(this.glacial_almacenDataSet.empresa);
                    Program.idEmpresa = 0;
                    EmpresaBuscar.Close();
                    form = Application.OpenForms.OfType<Empresa.frm_EmpresaBuscar>().FirstOrDefault();
                    EmpresaBuscar = form ?? new Empresa.frm_EmpresaBuscar();
                    AddFormInPanel(EmpresaBuscar);
                }
            }
            else
                MessageBox.Show("No se a seleccionado ningun registro para la eliminacion", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if (Program.idEmpresa != 0)
            {
                Empresa.frm_EmpresaModificar form = Application.OpenForms.OfType<Empresa.frm_EmpresaModificar>().FirstOrDefault();
                Empresa.frm_EmpresaModificar EmpresaModificar = form ?? new Empresa.frm_EmpresaModificar();
                AddFormInPanel(EmpresaModificar);
            }
            else
                MessageBox.Show("No se a seleccionado ningun registro para la modificación", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
