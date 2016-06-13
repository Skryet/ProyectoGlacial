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
    public partial class frm_Creditos : Form
    {
        private generarConexion conexion;

        public frm_Creditos()
        {
            InitializeComponent();
            conexion = new generarConexion();
        }

        private void CargarClientes()
        {
            bool tieneCredito = false;
            string comando = "SELECT id_cliente, nombre, tiene_credito, credito, fecha_limite_credito, credito_usado, fecha_expiracion_credito"
                + " FROM clientes;";
            MySqlCommand consulta = new MySqlCommand(comando, generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    if (lector.GetInt32(2) == 1)
                        tieneCredito = true;
                    dgv_Clientes.Rows.Add("C"+lector.GetInt32(0).ToString("##00000"), lector.GetString(1), tieneCredito, lector.GetDouble(3).ToString("C"),
                        lector.GetString(4), lector.GetDouble(5).ToString("C"), lector.GetString(6));
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error: " + e.ToString(), "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conexion.cerrarConexion();
        }

        private void frm_Creditos_Load(object sender, EventArgs e)
        {
            CargarClientes();
        }
    }
}
