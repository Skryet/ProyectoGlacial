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
using System.Globalization;

namespace Proyecto_Glacial.Clientes.Credito
{
    public partial class btn_Pago : Form
    {
        private generarConexion conexion;

        public btn_Pago()
        {
            InitializeComponent();
            conexion = new generarConexion();
        }

        private void CargarClientes(string filtro)
        {
            dgv_Clientes.Rows.Clear();
            bool tieneCredito = false;
            string fechaLimite = "N/A";
            var isoDateTimeFormat = CultureInfo.InvariantCulture.DateTimeFormat;
            string comando = "SELECT id_cliente, nombre, tiene_credito, credito, fecha_limite_credito, credito_usado, fecha_expiracion_credito"
                + " FROM clientes;";
            MySqlCommand consulta = new MySqlCommand(comando, generarConexion.obtenerConexion);
            conexion.abrirConexion();
            try
            {
                MySqlDataReader lector = consulta.ExecuteReader();
                while (lector.Read())
                {
                    if (lector.GetValue(6).ToString() != "01/01/0001 12:00:00 a. m.")
                    {
                        fechaLimite = lector.GetValue(6).ToString();
                        if (DateTime.Parse(fechaLimite) <= DateTime.Now && lector.GetDecimal(3) < lector.GetDecimal(5))
                            tieneCredito = true;
                    }
                    else
                        tieneCredito = true;
                    
                    switch (filtro)
                    {
                        case "uso":
                            if (lector.GetInt32(2) == 1 && lector.GetDecimal(5) > 0)
                            {
                                dgv_Clientes.Rows.Add("C" + lector.GetInt32(0).ToString("##00000"), lector.GetString(1), tieneCredito, lector.GetDecimal(3).ToString("C"),
                                    lector.GetValue(4).ToString(), lector.GetDecimal(5).ToString("C"), fechaLimite);
                            }
                            break;
                        case "sin_uso":
                            if (lector.GetInt32(2) == 1 && lector.GetDecimal(5) == 0)
                            {
                                dgv_Clientes.Rows.Add("C" + lector.GetInt32(0).ToString("##00000"), lector.GetString(1), tieneCredito, lector.GetDecimal(3).ToString("C"),
                                    lector.GetValue(4).ToString(), lector.GetDecimal(5).ToString("C"), fechaLimite);
                            }
                            break;
                        case "expirados":
                            if (tieneCredito == false)
                            {
                                dgv_Clientes.Rows.Add("C" + lector.GetInt32(0).ToString("##00000"), lector.GetString(1), tieneCredito, lector.GetDecimal(3).ToString("C"),
                                    lector.GetValue(4).ToString(), lector.GetDecimal(5).ToString("C"), fechaLimite);
                            }
                            break;
                        default:
                            if (lector.GetInt32(2) == 1)
                            {                                
                                dgv_Clientes.Rows.Add("C" + lector.GetInt32(0).ToString("##00000"), lector.GetString(1), tieneCredito, lector.GetDecimal(3).ToString("C"),
                                    lector.GetValue(4).ToString(), lector.GetDecimal(5).ToString("C"), fechaLimite);                                
                            }
                            break;                            
                    }                    
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
            CargarClientes("");
        }

        private void FiltroCreditos(object sender, EventArgs e)
        {
            if (rbt_MostrarTodo.Checked == true)
                CargarClientes("");
            else if (rbt_CreditosUso.Checked == true)
                CargarClientes("uso");
            else if (rbt_CreditosSinUso.Checked == true)
                CargarClientes("sin_uso");
            else if (rbt_CreditosExpirados.Checked == true)
                CargarClientes("expirados");            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_Pagos pagos = new frm_Pagos();
            pagos.ShowDialog();
        }
    }
}
