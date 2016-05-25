using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Glacial.Clientes
{
    public partial class frm_ClientesVisualizarIndividual : Form
    {

        generarConexion Conexion = new generarConexion();
        public int buscarUltimoIdLista()
        {

            int ultimoIdExistente = 0; //SELECT `id_lista_proveedores` FROM `proveedor_codigo` ORDER BY `id_lista_proveedores` DESC LIMIT 1
            MySqlCommand consulta = new MySqlCommand("SELECT credito FROM clientes WHERE id_cliente=" 
                + "'"  + Program.idCliente + "'", generarConexion.obtenerConexion);
            Conexion.abrirConexion();

            try
            {

                MySqlDataReader lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    if (lector.GetValue(0).ToString() == "")
                    {
                        ultimoIdExistente = 0;
                        Conexion.cerrarConexion();
                        return ultimoIdExistente;
                        
                    }
                    else
                    {
                        
                        ultimoIdExistente = lector.GetInt32(0);
                        Conexion.cerrarConexion();
                        return ultimoIdExistente;
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.cerrarConexion();
            return 0;
        }


        public frm_ClientesVisualizarIndividual()
        {
            InitializeComponent();
        }

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_ClientesVisualizarIndividual_Load(object sender, EventArgs e)
        {

            buscarUltimoIdLista();

            
            this.Location = new Point(30, 30);
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.FillByBuscarClienteId(this.glacial_almacenDataSet.clientes,Program.idCliente);
            int consecutivo = 0;
            consecutivo = Convert.ToInt32(id_clienteTextBox.Text);

            string cadena = "C" + consecutivo.ToString("D4");
            txt_codigoClienteFormato.Text = cadena;

            int numero = Convert.ToInt32(buscarUltimoIdLista().ToString());
            string cadena2 = numero.ToString("N2");
            txt_credito.Text = cadena2;
            txt_credito.Enabled = false;

             


            if (CHECK_tieneCredito.Checked)
            {
                rb_credito.Checked = true;
                grp_credito.Visible = true;
            }
            else
            {
                rb_efectivo.Checked = true;
                grp_credito.Visible = false;
            }
        }

        
    }
}
