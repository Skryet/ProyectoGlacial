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
    public partial class frm_VentasSeleccionEmpresa : Form
    {
        public frm_VentasSeleccionEmpresa()
        {
            InitializeComponent();
        }       

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            this.empresaTableAdapter.Fill(this.glacial_almacenDataSet.empresa);
            if (empresaDataGridView.RowCount != 0)
                empresaDataGridView.CurrentRow.Selected = false;
            Program.idEmpresa = 0;
            txt_Buscar.Text = "";
        }

        private void frm_VentasSeleccionEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.empresa' Puede moverla o quitarla según sea necesario.
            this.empresaTableAdapter.Fill(this.glacial_almacenDataSet.empresa);

        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            switch (cbb_Opciones.Text)
            {
                case "Nombre":
                    empresaTableAdapter.BuscarNombre(this.glacial_almacenDataSet.empresa, "%" + txt_Buscar.Text + "%");
                    txt_Buscar.Text = "";
                    break;
                case "Estado":
                    empresaTableAdapter.BuscarEstado(this.glacial_almacenDataSet.empresa, "%" + txt_Buscar.Text + "%");
                    txt_Buscar.Text = "";
                    break;
                default:
                    MessageBox.Show("No se ha seleccionado la opcion de busqueda", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
            }
        }

        private void empresaDataGridView_Click(object sender, EventArgs e)
        {
            Program.idEmpresaVenta = Convert.ToInt32(empresaDataGridView.Rows[empresaDataGridView.CurrentCellAddress.Y].Cells[0].Value);
        }

        private void btn_AgregarEmpresa_Click(object sender, EventArgs e)
        {
            Form AgregarEmpresa = new Empresa.frm_EmpresaAgregar();
            AgregarEmpresa.ShowDialog();
            this.empresaTableAdapter.Fill(this.glacial_almacenDataSet.empresa);

        }

        private void btn_SeleccionarEmpresa_Click(object sender, EventArgs e)
        {
            if (Program.idEmpresaVenta == 0)
            {
                DialogResult resultadoDialogo = MessageBox.Show("No se ha seleccionado ninguna empresa, ¿Desea salir?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (resultadoDialogo == DialogResult.Yes)
                {
                    Program.idEmpresaVenta = 0;
                    this.Close();
                }
            }
            else
                this.Close();
        }
    }
}
