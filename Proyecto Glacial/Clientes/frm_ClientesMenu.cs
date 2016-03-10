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
    public partial class frm_ClientesMenu : Form
    {
        public frm_ClientesMenu()
        {
            InitializeComponent();
        }

        private void AddFormInPanel(Form fh)
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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            
            frm_ClientesAgregar form = Application.OpenForms.OfType<frm_ClientesAgregar>().FirstOrDefault();
            frm_ClientesAgregar clientesAgregar = form ?? new frm_ClientesAgregar();
            AddFormInPanel(clientesAgregar);
            lbl_Estado.Text = "Glacial - Agregar Nuevos Clientes";

            //Deshabilitar Modificar y Eliminar
            btn_Modificar.Enabled = false;
            btn_Eliminar.Enabled = false;
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            var resultado = MessageBox.Show("¿Está seguro de eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            { 
                this.clientesTableAdapter.EliminarClientePorId(Program.idCliente);
                MessageBox.Show("Registro Eliminado con éxito!","Completado");
                this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);
            }


        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            Clientes.frm_ClientesBuscar form = Application.OpenForms.OfType<Clientes.frm_ClientesBuscar>().FirstOrDefault();
            Clientes.frm_ClientesBuscar clientesBuscar = form ?? new Clientes.frm_ClientesBuscar();
            AddFormInPanel(clientesBuscar);
            lbl_Estado.Text = "Glacial - Buscar Clientes";
            this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);

            //Habilitar Eliminar y Modificar            
            btn_Modificar.Enabled = true;
            btn_Eliminar.Enabled = true;
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {

            Clientes.frm_ClientesModificar form = Application.OpenForms.OfType<Clientes.frm_ClientesModificar>().FirstOrDefault();
            Clientes.frm_ClientesModificar clientesModificar = form ?? new Clientes.frm_ClientesModificar();
            AddFormInPanel(clientesModificar);
            lbl_Estado.Text = "Glacial - Modificar Clientes";
        }

       

           // this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);
        

        

        
    }
}
