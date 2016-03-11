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
        public void NombreMetodo(string mensaje)
        {
            lbl_Agregar.Text = mensaje;
        }

        public Clientes.frm_ClientesModificar form;
        public Clientes.frm_ClientesModificar ClientesModificar;

        public Clientes.frm_ClientesBuscar form2;
        public Clientes.frm_ClientesBuscar ClientesBuscar;

        
        public frm_ClientesMenu()
        {
            InitializeComponent();
        }

        
        public String TextBoxText
        {
            get { return lbl_Agregar.Text; }
            set
            {
                lbl_Agregar.Text = value;
            }
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

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Program.isOpenMainClientForm = true;
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
            if (Program.idCliente == 0)
                MessageBox.Show("Seleccione un registro para trabajar");
            else
                { 
                btn_Eliminar.Enabled = true;
                btn_Modificar.Enabled = true;
                var resultado = MessageBox.Show("¿Está seguro de eliminar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    ClientesBuscar.Close();
                    this.clientesTableAdapter.EliminarClientePorId(Program.idCliente);
                    MessageBox.Show("Registro Eliminado con éxito!","Completado");


                    form2 = Application.OpenForms.OfType<Clientes.frm_ClientesBuscar>().FirstOrDefault();
                    ClientesBuscar = form2 ?? new Clientes.frm_ClientesBuscar();
                    AddFormInPanel(ClientesBuscar);
                    lbl_Estado.Text = "Glacial - Buscar Clientes";
                    this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);
                    // this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);
                }
            }


        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            
            if(!Program.isOpenMainClientForm)
            {
                ClientesBuscar.Close();
            }
            if (Program.isOpenMainClientForm)
            {
                Program.isOpenMainClientForm = false;
            }
            if(btn_Modificar.Enabled)
                ClientesModificar.Close();
            form2 = Application.OpenForms.OfType<Clientes.frm_ClientesBuscar>().FirstOrDefault();
            ClientesBuscar = form2 ?? new Clientes.frm_ClientesBuscar();
            AddFormInPanel(ClientesBuscar);
            lbl_Estado.Text = "Glacial - Buscar Clientes";
            this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);

            btn_Eliminar.Enabled = true;
            btn_Modificar.Enabled = true;




        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            if(Program.idCliente == 0)
            {
                MessageBox.Show("Selecccione un registro para trabajar");
            }
            else
            { 
                form = Application.OpenForms.OfType<Clientes.frm_ClientesModificar>().FirstOrDefault();
                ClientesModificar = form ?? new Clientes.frm_ClientesModificar();
                AddFormInPanel(ClientesModificar);
                lbl_Estado.Text = "Glacial - Modificar Clientes";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frm_ClientesMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
             Program.isOpenMainClientForm = true;
        }



        // this.clientesTableAdapter.Fill(this.glacial_almacenDataSet.clientes);





    }
}
