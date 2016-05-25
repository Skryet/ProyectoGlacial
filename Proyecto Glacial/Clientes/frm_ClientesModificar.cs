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
    public partial class frm_ClientesModificar : Form
    {

        generarConexion Conexion = new generarConexion();
        bool tieneCredito = false;
        public frm_ClientesModificar()
        {
            InitializeComponent();
        }

        public int buscarUltimoIdLista()
        {

            int ultimoIdExistente = 0; //SELECT `id_lista_proveedores` FROM `proveedor_codigo` ORDER BY `id_lista_proveedores` DESC LIMIT 1
            MySqlCommand consulta = new MySqlCommand("SELECT precio_asignado FROM clientes WHERE id_Cliente=" + Program.idCliente, generarConexion.obtenerConexion);
            Conexion.abrirConexion();

            try
            {

                MySqlDataReader lector = consulta.ExecuteReader();

                while (lector.Read())
                {
                    if (lector.GetValue(0).ToString() == "")
                    {
                        ultimoIdExistente = 1;
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

        public int obtenerCredito()
        {
            int ultimoIdExistente = 0; //SELECT `id_lista_proveedores` FROM `proveedor_codigo` ORDER BY `id_lista_proveedores` DESC LIMIT 1
            MySqlCommand consulta = new MySqlCommand("SELECT credito FROM clientes WHERE id_cliente="
                + "'" + Program.idCliente + "'", generarConexion.obtenerConexion);
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

        private void clientesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.clientesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.glacial_almacenDataSet);

        }

        private void frm_ClientesModificar_Load(object sender, EventArgs e)
        {

            
            switch (buscarUltimoIdLista())
            {
                case 0:
                    cmb_precioSeleccionar.Text = "Precio Libre";
                    break;
                case 1:
                    cmb_precioSeleccionar.Text = "Precio Uno";
                    break;
                case 2:
                    cmb_precioSeleccionar.Text = "Precio Dos";
                    break;
                case 3:
                    cmb_precioSeleccionar.Text = "Precio Tres";
                    break;
                case 4:
                    cmb_precioSeleccionar.Text = "Precio Especial";
                    break;
            }
            // TODO: esta línea de código carga datos en la tabla 'glacial_almacenDataSet.clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter.FillByBuscarClienteId(this.glacial_almacenDataSet.clientes,Program.idCliente);

            if (check_tieneCredito.Checked)
                rb_credito.Checked = true;
            else
                rb_efectivo.Checked = true;

            //Visualizar cliente
            int numero = Convert.ToInt32(txt_cliente.Text);
            string cadena = numero.ToString("D4");
            txt_cliente.Text = cadena;

            int consecutivo = Convert.ToInt32(txt_cliente.Text);

            txt_numeroCliente.Text = "C" + consecutivo.ToString("D4");
            
            //Visualizar credito
            numero = Convert.ToInt32(obtenerCredito().ToString());
            string cadena2 = numero.ToString("N2");
            txt_credito.Text = cadena2;


        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
           // this.clientesTableAdapter.FillByBuscarClienteId(this.glacial_almacenDataSet.clientes, Convert.ToInt32(txtIdCliente.Text));
            //btn_Modificar.Enabled = true;
        }

       

      

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            int precioReferencial = 0;
            switch(cmb_precioSeleccionar.Text)
            {
                case "Precio Libre":
                    precioReferencial = 0;
                    break;
                case "Precio Uno":
                    precioReferencial = 1;
                    break;
                case "Precio Dos":
                    precioReferencial = 2;
                    break;
                case "Precio Tres":
                    precioReferencial = 3;
                    break;
                case "Precio Cuatro":
                    precioReferencial = 4;
                    break;

            }

            var resultado = MessageBox.Show("¿Está seguro de acctualizar este registro?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                
                this.clientesTableAdapter.UpdateClientesPorId(txt_Nombre.Text, txt_direccion.Text, txt_colonia.Text, txt_ciudad.Text,
                    txt_cp.Text, txt_correo.Text, txt_rfc.Text, txt_telefono.Text, txt_CURP.Text, Convert.ToInt32(precioReferencial),tieneCredito
                    , Convert.ToDouble(txt_credito.Text), Convert.ToInt32(txt_diasCredito.Text), Program.idCliente);
                MessageBox.Show("Registro Actualizado con éxito!", "Completado");
                //this.Close();
                this.Refresh();

                //Deshabilitar Campos
                txt_Nombre.Enabled = false;
                txt_direccion.Enabled = false;
                txt_colonia.Enabled = false;
                txt_ciudad.Enabled = false;
                txt_cp.Enabled = false;
                txt_correo.Enabled = false;
                txt_rfc.Enabled = false;
                txt_telefono.Enabled = false;
                rb_credito.Enabled = false;
                rb_efectivo.Enabled = false;
                txt_credito.Enabled = false;
                txt_diasCredito.Enabled = false;
            }
           
            

            
        }

       

       

        private void rb_credito_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_credito.Checked)
            {
                tieneCredito = true;
                grp_credito.Visible = true;
            }
        }

        private void rb_efectivo_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_efectivo.Checked)
            {  
                tieneCredito = false;
                grp_credito.Visible = false;
            }
        }

        private void txt_credito_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                decimal val = Convert.ToDecimal(txt_credito.Text);
                txt_credito.Text = val.ToString("N2");
            }
        }

        private void txt_credito_Leave(object sender, EventArgs e)
        {
            decimal val = Convert.ToDecimal(txt_credito.Text);
            txt_credito.Text = val.ToString("N2");
        }
    }
}
