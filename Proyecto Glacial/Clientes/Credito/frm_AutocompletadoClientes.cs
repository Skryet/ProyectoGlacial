using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Proyecto_Glacial.Clientes.Credito
{
    public partial class frm_AutocompletadoClientes : Form
    {
        private Consultas.autocompletado_clientes autocompletado;
        private string buscar;
        private string TipoBusqueda;
        private Point posicion;

        public frm_AutocompletadoClientes(
            string busqueda,
            string tipoBusqueda, 
            Point localizacion,
            ref Label codigo_cliente,
            ref Label nombre_cliente,
            ref Label saldo,
            ref Label fecha_expiracion)
        {
            InitializeComponent();
            autocompletado = new Consultas.autocompletado_clientes(ref dgv_Clientes);
            buscar = busqueda;
            TipoBusqueda = tipoBusqueda;
            posicion = localizacion;           
        }

        private void frm_AutocompletadoClientes_Load(object sender, EventArgs e)
        {
            posicion.Y += +235;
            posicion.X += 400;
            this.Location = posicion;
            if (TipoBusqueda == "nombre")
                autocompletado.AgregarClientesNombre(buscar);
            if (TipoBusqueda == "codigo")
                autocompletado.AgregarClientesNombre(buscar);
        }

        private void dgv_Clientes_DoubleClick(object sender, EventArgs e)
        {
            /*Reacomodar los codigos de cliente
                
            int idCliente = Convert.ToInt32(dgv_Clientes.Rows[dgv_Clientes.CurrentCellAddress.Y].Cells[0].Value);
            string comando = "SELECT id_cliente, nombre"
                + " FROM clientes WHERE nombre LIKE '%" + nombre + "%' AND tiene_credito = 1;";
            MySqlCommand consulta = new MySqlCommand(comando, generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                    ListaClientes.Rows.Add("C" + lector.GetInt32(0).ToString("##00000"), lector.GetString(1));
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.cerrarConexion();
            */
        }
    }
}
